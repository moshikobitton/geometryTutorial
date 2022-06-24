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
    public partial class frmAddQynWpic : Form   ///פורם שנועד להוספת שאלת כן או לא עם תמונה
    {
        string imageName = ""; // שם התמונה
        List<Questions> qList = new List<Questions>(); // אוסף השאלות הקיימות
        public frmAddQynWpic(List<Questions> qlist1)
        {
            qList = qlist1;
            InitializeComponent();
        }

        private void btnOpenn_Click(object sender, EventArgs e)   ///אירוע לחיצת כפתור לעיון ובחירת תמונה
        {
            openFileDialog1.ShowDialog();
            return;
        }

        private void btnAddD_Click(object sender, EventArgs e)  ///אירוע לחיצת כפתור להוספת השאלה לקובץ
        {
            if ((rdbYes.Checked==true||rdbNo.Checked==true) && (txtQuest.Text!="") && (picBox.Image != null))
            {
                string no = "לא";
                string yes = "כן";
                string question = txtQuest.Text;
                // לולאה שבודקת האם השאלה כבר קיימת באוסף
                foreach (Questions q in qList)
                {
                    if (String.Compare(q.Question,question, new CultureInfo("he-IL"),CompareOptions.None) == 0)
                        throw new ArgumentException("This question is already exist");
                }
                int sizeOfQuest = 1;
                StreamReader sr = new StreamReader(Application.StartupPath + $@"\DATA\gameData.txt"); 
                while (sr.ReadLine() != null)
                    sizeOfQuest++; // ספירת השורות בקובץ כדי לדעת כמה שאלות יש
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\gameData.txt",true);
                string str = picBox.ImageLocation;
                string[] name = str.Split('\\');
                imageName = "Num" + sizeOfQuest + name[name.Length - 1]; // חילוץ שם התמונה שנבחרה
                picBox.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName); //שמירות התמונה במקום המיועד
                if (rdbYes.Checked==true)
                    sw.Write("\n" + sizeOfQuest + ";2;" + no + ";" + yes + ";" + question + ";" + imageName);
                else sw.Write("\n" + sizeOfQuest + ";2;" +  yes + ";" + no + ";" + question+ ";" + imageName);
                sw.Close();
                MessageBox.Show("הוספת שאלה בהצלחה!");
                txtQuest.Text = "";
                imageName = "";
                picBox.Image = null;
                return;
            }
            MessageBox.Show("חסר מידע, אנא מלא את השדות החסרים");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picBox.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName);
            return;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picBox.ImageLocation = openFileDialog1.FileName;
        }

        private void btnClose_Click(object sender, EventArgs e) // חזרה לדף הקודם
        {
            this.Close();
        }
    }
}
