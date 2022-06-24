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
using System.Globalization;

namespace GmarProject
{
    public partial class frmAddInfoPics : Form  ///פורם שנועד להוספת פריט מידע עם תמונה
    {
        string imageName = ""; // שם התמונה
        ArrayList dataList = new ArrayList(); // אוסף של כל הפריטי מידע שקיימים
        public frmAddInfoPics(ArrayList datalist1)
        {
            dataList = datalist1;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) ///אירוע לחיצת כפתור שומר נתונים
        {
            string topic = txtTopic.Text;
            string details = txtDetailes.Text;
            if (topic != "" && details != "" && picBox.Image != null)
            {
                // בלולאה זו נבדוק שהתוכן של הפריט מידע אינו קיים באוסף שלנו
                foreach (DataItem d in dataList)
                {
                    if (String.Compare(d.Content,details, new CultureInfo("he-IL"),CompareOptions.None) == 0)
                        throw new ArgumentException("This data item is already exist");
                }
                int sizeOfData = 1;
                StreamReader sr = new StreamReader(Application.StartupPath + $@"\DATA\infoData.txt");
                while (sr.ReadLine() != null)
                    sizeOfData++; // משתנה זה סופר את כמות פריטי המידע על ידי ספירת השורות בקובץ
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\infoData.txt",true);
                string str = picBox.ImageLocation;
                string[] name = str.Split('\\');
                imageName = "Num" + sizeOfData + name[name.Length - 1];  // נחלץ את שם התמונה שנבחרה
                picBox.Image.Save(Application.StartupPath + $@"\DATA\DIMAGES\"+imageName); // נשמור אותה במקום המיועד
                sw.Write("\n" +  sizeOfData  + ";"  + details + ";" + topic + ";" + imageName); // נרשום לקובץ בפורמט המבוקש את נתוני פריט המידע
                sw.Close();
                MessageBox.Show("הוספת פריט מידע בהצלחה!");
                Clear();
                return;
            }
            MessageBox.Show("חסר מידע, אנא מלא את השדות החסרים");
            return;
        }
        public void Clear()      ///מתודה שנועדה לאפס את שדות הטקסט והתמונה
        {
            txtTopic.Text = "";
            txtDetailes.Text = "";
            picBox.Image = null;
            imageName = "";
            return;
        }

        private void btnOpen_Click(object sender, EventArgs e)   ////אירוע לחיצת כפתור על מנת לעיין ולבחור בתמונות
        {
            openFileDialog1.ShowDialog();
            return;
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picBox.Image.Save(Application.StartupPath + $@"\DATA\DIMAGES\"+imageName);
            return;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            picBox.ImageLocation = openFileDialog1.FileName;
        }
        //חזרה לדף הקודם
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
