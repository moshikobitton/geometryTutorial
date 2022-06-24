using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GmarProject
{
    public partial class frmMainInfo : Form    ///פורם שנועד להצגת תפריט אופציות הוספת תוכן
    {
        List<Questions> qList = new List<Questions>(); // אוסף לכל השאלות מהקובץ
        ArrayList dataList = new ArrayList(); //אוסף שונה לכל הפריטי מידע שקיימים

        public frmMainInfo(List<Questions> qlist1, ArrayList datalist1)
        {
            qList = qlist1;
            dataList = datalist1;
            InitializeComponent();
        }

        private void btnAddInformation_Click(object sender, EventArgs e)  ///אירוע שפותח פורם הוספת פריט מידע ללא תמונה
        {
            frmInfoNoPic frmt = new frmInfoNoPic(dataList);
            frmt.Show();
        }

        private void btnInfo2_Click(object sender, EventArgs e)        ///אירוע שפותח פורם הוספת פריט מידע עם תמונה
        {
            frmAddInfoPics frmm = new frmAddInfoPics(dataList);
            frmm.Show();
        }

        private void btnAddQuest_Click(object sender, EventArgs e)      ///אירוע הוספת שאלת כן או לא ללא תמונה
        {
            frmAddQuest frmt = new frmAddQuest(qList);
            frmt.Show();
        }

        private void btnYNWithPic_Click(object sender, EventArgs e)      ///אירוע הוספת שאלת כן או לא עם תמונה
        {
            frmAddQynWpic frmt = new frmAddQynWpic(qList);
            frmt.Show();
        }

        private void btn3WPic_Click(object sender, EventArgs e)        ///אירוע הוספת שאלת ריבוי בחירה עם תמונה
        {
            frm3AnswersWPic frm = new frm3AnswersWPic(qList);
            frm.Show();
        }

        private void btn3Answers_Click(object sender, EventArgs e)      ///אירוע הוספת שאלת ריבוי בחירה ללא תמונה
        {
            frm3Answer frm = new frm3Answer(qList);
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e) /// חזרה למסך הראשי
        {
            this.Close();
        }
    }
}
