using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GmarProject
{
    class DataItem : IComparable ////מחלקת פרטי מידע 
    {
        static protected int number = 0;   //משתנה סטטי לספירת כמות השאלות
        protected string topic;           //נושא פריט המידע 
        protected string content;         //תוכן פריט המידע

        public int Number { get => number;}
        public string Content { get => content; set => content = value; }
        public string Topic { get => topic; set => topic = value; }

        public DataItem(string topic, string content)
        {
            number++;
            Topic = topic;
            Content = content;
        }
        public int CompareTo(object obj)
        {
            if (!(obj is DataItem))
                throw new Exception("Object is not a DataItem, can not compare!!");

            DataItem d = (DataItem)obj;
            return String.Compare(Topic,d.Topic, new CultureInfo("he-IL") ,CompareOptions.None);
      }

    }
}
