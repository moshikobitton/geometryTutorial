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
    public partial class frm3AnswersWPic : Form // פורם של הוספת שאלה עם שלוש תשובות שהן תמונות
    {
        string imageName1 = ""; // תמונה 1 היא התשובה הנכונה
        string imageName2 = ""; // תמונה 2
        string imageName3 = ""; // תמונה 3
        List<Questions> qList = new List<Questions>(); // אוסף של כלל השאלות
        public frm3AnswersWPic(List<Questions> qlist1)
        {
            qList = qlist1;
            InitializeComponent();
        }
        // אירוע של כפתור שמור - בו נשמור את התמונות בתיקייה המתאימה ונרשום לקובץ את המידע שהוזן
        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtQuest.Text!="") && (pictureBox1.Image != null) && (pictureBox2.Image != null) && (pictureBox3.Image != null))
            {
                string question = txtQuest.Text;
                foreach (Questions q in qList)
                {
                    if (String.Compare(q.Question,question, new CultureInfo("he-IL"),CompareOptions.None) == 0)
                        throw new ArgumentException("This question is already exist");
                }
                int sizeOfQuest = 1;
                StreamReader sr = new StreamReader(Application.StartupPath + $@"\DATA\gameData.txt"); 
                while (sr.ReadLine() != null) 
                    sizeOfQuest++;       // קראנו את כל השורות בקובץ ובו זמנית פתחתו משתנה שיספור כמה שורות שזה כמות השאלות
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\gameData.txt",true);
                imageName1 = GetName(pictureBox1.ImageLocation , sizeOfQuest);
                imageName2 = GetName(pictureBox2.ImageLocation , sizeOfQuest);
                imageName3 = GetName(pictureBox3.ImageLocation , sizeOfQuest);
                pictureBox1.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName1);
                pictureBox2.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName2);
                pictureBox3.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName3);
                sw.Write("\n" +  sizeOfQuest + ";" + "3" + ";" + question + ";" + imageName1 + ";" + imageName2 + ";" + imageName3);
                sw.Close();
                MessageBox.Show("הוספת פריט מידע בהצלחה!");
                Clear();
                return;
            }
            MessageBox.Show("חסר מידע, אנא מלא את השדות החסרים");
            return;
            
        }
        public void Clear()    ///מתודה שנועדה לאפס את ערכי שדות הטקסט והתמונות
        {
            imageName1 = "";
            imageName2 = "";
            imageName3 = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            txtQuest.Text = null;
        }
        public string GetName(string str , int sizeOfQuest) ///מתודה שנועדה להחזיר את שם התמונה שנבחרה
        {
            string[] name = str.Split('\\');
            return ("Num" + sizeOfQuest + name[name.Length - 1]);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)   
        {
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox2.ImageLocation = openFileDialog2.FileName;
        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox3.ImageLocation = openFileDialog3.FileName;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox1.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName1);
            return;
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox2.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName2);
            return;
        }

        private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            pictureBox3.Image.Save(Application.StartupPath + $@"\DATA\QIMAGES\"+imageName3);
            return;
        }

        private void btnOpen3_Click(object sender, EventArgs e)   ////אירוע בחירת תמונה מתוך עיון בקבצים
        {
            openFileDialog3.ShowDialog();
            return;
        }

        private void btnOpen2_Click(object sender, EventArgs e)    ////אירוע בחירת תמונה מתוך עיון בקבצים
        {
            openFileDialog2.ShowDialog();
            return;
        }

        private void btnOpen1_Click(object sender, EventArgs e)    ////אירוע בחירת תמונה מתוך עיון בקבצים
        {
            openFileDialog1.ShowDialog();
            return;
        }

        private void btnClose_Click(object sender, EventArgs e) //חזרה לדף הקודם
        {
            this.Close();
        }
    }
}
