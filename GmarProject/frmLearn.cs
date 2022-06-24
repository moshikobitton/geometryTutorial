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
    public partial class frmLearning : Form ///פורם שנועד להצגת פרטי מידע הנבחרים לצורך למידה
    {
        ArrayList dataList = new ArrayList(); // אוסף של כל פריטי המידע שקיימים בקובץ
        int index = -1; // משתנה אינדקס של הפריט המידע שמופיע בדף
        public frmLearning(ArrayList dataList1)   // בבנאי אנו נכניס את כל הנתונים מהקובץ אל האוסף שהגדרנו
        {
            InitializeComponent();
            dataList = dataList1;
            foreach (DataItem d in dataList1)
                cmbMenu.Items.Add(d.Topic);  // הכנסת הנושאים לפקד cmb
        }
        // באירוע לחיצה אנו נבדוק באיזה פריט מידע המשתמש בחר ונציג לו את הנתונים עליו
        private void btnChoose_Click(object sender, EventArgs e)  ///אירוע בחירת נושא וקבלת מידע עליו
        {
            index = cmbMenu.SelectedIndex;
            picTopic.Visible = false;
            lblheadTopic.Text = cmbMenu.Text;
            rchInfo.Text = ((DataItem)dataList[cmbMenu.SelectedIndex]).Content;
            if (dataList[cmbMenu.SelectedIndex] is DataItemWImage)
            {
                picTopic.Visible = true;
                DataItemWImage d1 = (DataItemWImage)dataList[cmbMenu.SelectedIndex];
                picTopic.Image = Image.FromFile(Application.StartupPath + $@"\DATA\DIMAGES\{(d1.Image).Substring(1,d1.Image.Length-1)}");       
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // כפתור ״הבא״ שמציג את הנושא והתוכן הבאים ובמידה והגעת לסוף תקבל הודעה מתאימה
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (++index < dataList.Count)
            {
                picTopic.Visible = false;
                lblheadTopic.Text = ((DataItem)dataList[index]).Topic;
                rchInfo.Text = ((DataItem)dataList[index]).Content;
                if (dataList[index] is DataItemWImage)
                {
                    picTopic.Visible = true;
                    DataItemWImage d1 = (DataItemWImage)dataList[index];
                    picTopic.Image = Image.FromFile(Application.StartupPath + $@"\DATA\DIMAGES\{(d1.Image).Substring(1, d1.Image.Length - 1)}");
                }
                return;
            }
            MessageBox.Show("כל הכבוד! הגעת לסוף");
        }
    }
}
