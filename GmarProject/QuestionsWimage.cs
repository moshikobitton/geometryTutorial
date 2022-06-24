using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmarProject
{
    class QuestionsWimage:Questions //מחלקת שאלות עם תמונות
    {
        string picture;
        public string Picture { get => picture; set => picture = value; }
    
    public QuestionsWimage(int qtype, string question, string pic, string cAnswer, string wAnswer1) :base(qtype, question, cAnswer, wAnswer1)
        {
            picture = pic;
        }


       
    }
   
}
