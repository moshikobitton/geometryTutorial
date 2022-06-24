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
using System.Globalization;

namespace GmarProject
{
    public partial class frm3Answer : Form ///פורם לשאלות ריבוי תשובות ללא תמונה
    {
        List<Questions> qList = new List<Questions>(); // מבנה נתונים לכלל השאלות שקיימות
        public frm3Answer(List<Questions> qlist1)
        {
            qList = qlist1;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)//אירוע לחיצת כפתור שמור
        {
            // בדיקת תקינות שלא מוכנס בתשובות מספרים
            if ((textBox1.Text).Any(c=>char.IsDigit(c)) || (textBox2.Text).Any(c => char.IsDigit(c)) || (textBox3.Text).Any(c => char.IsDigit(c)))
                throw new ArgumentException("הכנס רק תווים בעברית בתשובות - ללא מספרים");
            else if (txtQuest.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" )
                {
                string question = txtQuest.Text , cAnswer = textBox1.Text , wAnswer1 = textBox2.Text , wAnswer2 = textBox3.Text;
                foreach (Questions q in qList)
                {
                    if (String.Compare(q.Question,question, new CultureInfo("he-IL"),CompareOptions.None) == 0)
                        throw new ArgumentException("This question is already exist");
                }
                int sizeOfQuest = 1;
                StreamReader sr = new StreamReader(Application.StartupPath + $@"\DATA\gameData.txt"); 
                while (sr.ReadLine() != null) // לולאה שנועדה לספור שאלות בפועל כדי לדעת את מספר השאלה שתתווסף
                    sizeOfQuest++;
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\gameData.txt",true);
                sw.Write("\n" +  sizeOfQuest + ";" + "1" + ";" + wAnswer2 + ";" + wAnswer1 + ";" + cAnswer + ";" + question); // 
                sw.Close();
                MessageBox.Show("הוספת שאלה בהצלחה!");
                Clear();
                return;
               }
            MessageBox.Show("חסר מידע, אנא מלא את השדות החסרים");
            return;
        }
        public void Clear()//מתודה שנועדה לאפס את ערכי שדות הטקסט
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtQuest.Text = "";
        }
        private void btnClose_Click(object sender, EventArgs e) // אירוע חזרה למסך הקודם
        {
            this.Close();
        }
    }
}
