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
    public partial class frmInfoNoPic : Form  ///פורם שנועד להוספת מידע ללא תמונה
    {
        ArrayList dataList = new ArrayList(); // אוסף של כל הפריטי מידע הקיימים בקובץ
        public frmInfoNoPic(ArrayList dataList1)
        {
            dataList = dataList1;
            InitializeComponent();
        }

        private void btnSave1_Click(object sender, EventArgs e) ///אירוע לחיצת כפתור שמירת הנתונים
        {        
            string topic = txtSubject.Text;
            string details = txtinfo2.Text;
            if (topic != "" && details != "")
            {
                // בלולאה זו נבדוק שהתוכן של הפריט מידע אינו קיים באוסף שלנו
                foreach (DataItem d in dataList)
                {
                    if (String.Compare(d.Content,details, new CultureInfo("he-IL"),CompareOptions.None) == 0)
                        throw new ArgumentException("This data item is already exist");
                }
                int sizeOfData = 0;
                StreamReader sr = new StreamReader(Application.StartupPath + $@"\DATA\infoData.txt");
                while (sr.ReadLine() != null)
                    sizeOfData++; // משתנה זה סופר את כמות פריטי המידע על ידי ספירת השורות בקובץ
                sizeOfData++;
                sr.Close();
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\infoData.txt",true);
                sw.Write("\n" + sizeOfData + ";" + details + ";" + topic); // כתיבה לקובץ
                sw.Close();
                MessageBox.Show("הוספת פריט מידע בהצלחה!");
                txtSubject.Text = "";
                txtinfo2.Text = "";
                return;
            }
                else MessageBox.Show("חסר מידע, אנא מלא את השדות החסרים");
                return;
        }
        // חזרה לדף הקודם
        private void btnClose_Click(object sender, EventArgs e) 
        {
            this.Close();
        }
    }
}
