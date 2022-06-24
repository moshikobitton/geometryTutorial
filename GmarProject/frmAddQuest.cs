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
    public partial class frmAddQuest : Form ///פורם שנועד להוספת שאלת כן לא ללא תמונה
    {
        List<Questions> qList = new List<Questions>(); // אוסף של כל השאלות שקיימות בקובץ
        public frmAddQuest(List<Questions> qlist1)
        {
            qList = qlist1;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)  ///אירוע לחיצת כפתור הוספת שאלה
        {
            if ((rdbYes.Checked==true||rdbNo.Checked==true)&& txtQuest.Text!="")
            {
                string question = txtQuest.Text;
                // לולאה שנועדה לבדוק האם קיימת השאלה שמוסיפים לאוסף השאלות הקיים
               
                foreach (Questions q in qList)
                {
                    if (String.Compare(q.Question,question, new CultureInfo("he-IL"),CompareOptions.None) == 0)
                        throw new ArgumentException("This question is already exist");
                }
                string no = "לא";
                string yes = "כן";
                int sizeOfQuest = 1;
                StreamReader sr = new StreamReader(Application.StartupPath + $@"\DATA\gameData.txt"); 
                while (sr.ReadLine() != null) // קריאת השורות מקובץ השאלות כדי לדעת כמה שאלת יש
                    sizeOfQuest++;
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\gameData.txt",true);
                if (rdbYes.Checked==true)
                    sw.Write("\n" + sizeOfQuest + ";0;" + no + ";" + yes + ";" + question);
                else sw.Write("\n" + sizeOfQuest + ";0;" +  yes + ";" + no + ";" + question);
                sw.Close();
                MessageBox.Show("הוספת שאלה בהצלחה!");
                txtQuest.Text = "";
                return;
            }
            MessageBox.Show("חסר מידע, אנא מלא את השדות החסרים");
        }

        private void btnClose_Click(object sender, EventArgs e) // חזרה לדף הקודם
        {
            this.Close();
        }
    }
}
