using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmarProject
{
    public class Questions ////מחקלת שאלות 
    {
        protected static int sqNumber = 0;
        protected int qnumber;
        protected int qtype;
        protected string question;
        protected string cAnswer;
        protected string wAnswer1;
        protected string wAnswer2;
        public int Qnumber { get => qnumber;}
        public int Qtype { get => qtype; set => qtype = value; }
        public string Question { get => question; set => question = value; }
        public string CAnswer { get => cAnswer; set => cAnswer = value; }
        public string WAnswer1 { get => wAnswer1; set => wAnswer1 = value; }
        public string WAnswer2 { get => wAnswer2; set => wAnswer2 = value; }

        public Questions(int qtype, string question,string cAnswer,string wAnswer1)
        {
            qnumber = ++sqNumber;
            Qtype = qtype;
            Question = question;
            CAnswer = cAnswer;
            WAnswer1 = wAnswer1;
            WAnswer2 = "";
        }
        public Questions(int qtype, string question,string cAnswer,string wAnswer1,string wAnswer2) :this(qtype,question,cAnswer,wAnswer1)
        {
            WAnswer2 = wAnswer2;
        }
        public static void LoadQuestionsFromFile()  
        {
            sqNumber = 0;
        }
    }
}
