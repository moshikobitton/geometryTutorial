using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmarProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmEnter());
            }
            // נזרוק חריגה אם הפורמט של השאלות או פריטי המידע בקובצים אינו נכון
            //נזרוק חריגה אם מספר סוג השאלה אינו קיים
            catch (ArgumentException e) // זרקנו חריגה בחלון של הוספת שאלה ריבוי תשובות ללא תמונה כאשר התשובות הן מספריות בלבד
            {                           //זרקנו חריגה כאשר מוסיפים שאלה או פריט מידע שקיים כבר
                MessageBox.Show(e.Message);
            }
            // חריגה אחת  compareto 
            catch (Exception ee) // נזרוק חריגה כאשר הוא אינו אותו סוג אובייקט
            {
              MessageBox.Show(ee.Message);
           }
   
        }
    }
}
