using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmarProject
{
    class DataItemWImage : DataItem ///מחלקת פרטי מידע עם תמונה
    {
        protected string image;
        public string Image { get => image; set => image = value; }

        public DataItemWImage(string topic, string content, string image) : base(topic,content)
        {
            Image = image;
        }
    }
}
