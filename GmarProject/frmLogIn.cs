using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace GmarProject
{
    public partial class frmEnter : Form ///פורם שנועד לכניסת משתמש עם המייל האישי, ובחירת אחת מהאטרקציות
    {
        string mail; 
        List<Questions> qList = new List<Questions>(); // אוסף לכל השאלות מהקובץ
        ArrayList dataList = new ArrayList(); //אוסף שונה לכל הפריטי מידע שקיימים 
        public frmEnter()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader((@"DATA\gameData.txt"));
            string line = "";
            while ((line = sr.ReadLine()) != null) // לולאה שנועדה לקרוא את השאלות למבנה נתונים שלו
            {
                string[] words = line.Split(';'); 
                //נזרוק חריגה אם התוכן שבקובץ לא מסודר לפי הפורמט הנכון
                if (words.Length !=5 && words.Length !=6)
                    throw new ArgumentException("text is not order right"); 
                int qtype = int.Parse(words[1]);
                // סיווג השאלות לפי סוג והוספתם לאוסף
                switch (qtype) 
                {
                    case 0: // כן לא בלי תמונה
                       qList.Add(new Questions(qtype, words[4], words[3], words[2]));
                       break;

                    case 1: // ריבוי בחירה בלי תמונה
                        qList.Add(new Questions(qtype,words[5],words[4],words[3],words[2]));
                        break;

                    case 2: // כן לא עם תמונה
                        qList.Add(new QuestionsWimage(qtype, words[4], words[5], words[3],words[2]));
                        break;

                    case 3: // ריבוי בחירה עם תמונה
                        qList.Add(new Questions(qtype,words[2],words[3],words[5],words[4]));
                        break;

                    default: //נזרוק חריגה אם אין לנו את סוג השאלה
                        throw new ArgumentException("You don't have number question type like this" + qtype); 
                        
                }
                words = null;
            }
            sr.Close();
            StreamReader sr1 = new StreamReader(@"DATA\infoData.txt");
            line = "";
            while ((line = sr1.ReadLine()) != null) // לולאה שנועדה לקרוא את הפריטי מידע למבנה נתונים שלו
            {
                string[] words = line.Split(';');
                //נזרוק חריגה אם התוכן שבקובץ לא מסודר לפי הפורמט הנכון
                if (words.Length !=3 && words.Length !=4)
                    throw new ArgumentException("text is not order right"); 
                if (words.Length == 4) // פריט מידע עם תמונה
                    dataList.Add(new DataItemWImage(words[2], words[1], words[0]));
                else // פריט מידע בלי תמונה
                    dataList.Add(new DataItem(words[1], words[0]));
            }
            sr1.Close();
            dataList.Sort(); // מיון הנושאים לפי א״ב
        }
        private void btnLogIn_Click(object sender, EventArgs e) ///אירוע התחברות שנועד לבדוק האם המייל תקין, במידה וכן ימשיך לבחירת האטרקציות
        {
            mail = txtEmail.Text;
            string[] name = mail.Split('@');
            int dotC = 0;
            int PositionCrucit = -1;
            if(name[0]==""||name.Length>2)
            {
                MessageBox.Show("מייל אינו תקין, אנא הכנס שוב ");
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("הכנס את המייל שלך  ");
                return;
            }
            for (int i = 0; i < txtEmail.Text.Length; i++)
            {
                if (mail[i] == ' ')
                {
                    MessageBox.Show("מייל אינו תקין, אנא הכנס שוב ");
                    return;
                }
                if (mail[i] == '@')
                {
                    PositionCrucit = i;
                    break;
                }
            }
            if (PositionCrucit == -1)
            {
                MessageBox.Show("מייל אינו תקין, אנא הכנס שוב ");
                return;
            }
            for (int j = PositionCrucit + 1; j < txtEmail.Text.Length; j++)
            {
                if (mail[j] == ' ')
                {
                    MessageBox.Show("מייל אינו תקין, אנא הכנס שוב ");
                    return;
                }
                if (mail[j] == '.')
                    dotC++;
            }
            if (dotC != 0)
            {
                btnLearn.Enabled = true;
                btnData.Enabled = true;
                btnPlay.Enabled = true;
                txtEmail.Enabled = false;
                btnLogIn.Visible = false;
            }
            else
            {
                MessageBox.Show("מייל אינו תקין, אנא הכנס שוב ");
                return;
            }
            
            // אם הגענו לכאן אז המייל תקין ונבדוק בקובץ users
            // אם המייל הוא משתמש חוזר ונתייחס אליו בהתאם בכותרת
            StreamReader sr2 = new StreamReader(Application.StartupPath + $@"\DATA\users.txt");
            string line = "";
            while ((line = sr2.ReadLine()) != null)
            {
                if (line == mail)
                {
                    //משתמש חוזר
                    lblLogin.Text = "ברוכים השבים"; 
                    sr2.Close();
                    return;
                }
            }
            sr2.Close();

            StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\users.txt", true);
            sw.WriteLine(mail);
            sw.Close();
            // משתמש חדש
            lblLogin.Text = "ברוך הבא";
        }
        private void btnLearn_Click(object sender, EventArgs e)     ///אירוע פתיחת פורם הלמידה
        {
            frmLearning frml = new frmLearning(dataList);
            frml.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)     ///אירוע פתיחת פורם המשחק
        {
            frmTrivia frmt = new frmTrivia(mail, qList);
            frmt.Show();
        }

        private void btnData_Click(object sender, EventArgs e)     ///אירוע פתיחת פורם הוספת מידע
        {
            frmMainInfo frmMinfo = new frmMainInfo(qList, dataList);
            frmMinfo.Show();
        }
    }
}
