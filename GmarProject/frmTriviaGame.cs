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

namespace GmarProject
{
    public partial class frmTrivia : Form  /// פורם שנועד לשחק את משחק הטריוויה
    {
        bool practice = false; // משתנה בוליאני האם המשחק הוא תרגול או שקר
        string rAnswer1; // משתנה ששומר את תשובה אקראית מספר 1
        string rAnswer2; // משתנה ששומר את תשובה אקראית מספר 2
        string rAnswer3; // משתנה ששומר את תשובה אקראית מספר 3
        int counter = 0; // משתנה שסופר את אינדקס של השאלה השגויות שיש להציג את התשובה שלה
        int timeCounter = 0; //משתנה של השניות- משך זמן המשחק
        int score = 0, correct = 0, wrong = 0; // משתנים של תשובות נכונות,שגויות ונקודות
        string mail; // משתנה בו נשמר כתובת המייל של המשתמש
        List<Questions> qList = new List<Questions>(); // אוסף לכל השאלות מהקובץ
        List<Questions> qRandomList = new List<Questions>(); // אוסף המכיל מספר שאלות אקראיות
        List<int> qWList = new List<int>(); // אוסף המכיל את מספרי השאלות בהם טעה המשתמש
        int quest=0; // אינדקס מספר השאלה שמוצגת
        public frmTrivia(string mail1, List<Questions>  qlist)
        {
            InitializeComponent(); 
            mail = mail1;
            qList = qlist;
        }
        ///אירוע שנועד להתחלת המשחק
        private void btnStartGame_Click(object sender, EventArgs e)  
        {
            timer1.Start(); // התחלת הטיימר
            Questions.LoadQuestionsFromFile();
            btnStartGame.Visible = false;
            this.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\DATA\wallspaper\trivia.jpeg");
            CreateRandomList();
            ShowQuestion(7);
            return;
        }
        ///מתודה שאחראית להצגת השאלות למשתמש לפי סוג השאלה
        public void ShowQuestion(int limit) // הארגומנט בפנים הוא מספר השאלות שיש להציג
        {
            btnChoice1.Visible = true;
            btnChoice2.Visible = true;
            btnChoice2.Text = "";
            btnChoice3.Visible = true;
            if (quest < limit)
            {
                Questions q = qRandomList[quest];
                Random rnd = new Random(); // משתנה אקראי לבחירת התשובות באופן אקראי להצגתן
                // סיווג השאלות להצגתן
                switch (q.Qtype) 
                {
                    case 0:             
                        btnChoice2.Visible = false;
                        lblTop.Text = q.Question;
                        btnChoice1.Text = "לא";
                        btnChoice3.Text = "כן";
                        break;
                    case 1:
                        btnChoice2.Enabled = true;
                        lblTop.Text = q.Question;
                        string[] arraystr = new string[] {q.CAnswer,q.WAnswer1,q.WAnswer2};
                        List<string> answers = new List<string>(arraystr);
                        int i = rnd.Next(answers.Count);
                        btnChoice1.Text = answers[i];
                        answers.RemoveAt(i);
                        btnChoice2.Text = answers[0];
                        btnChoice3.Text = answers[1];
                        break;
                    case 2:
                        QuestionsWimage q1 = q as QuestionsWimage;
                        lblTop.Text = q1.Question;
                        btnChoice1.Text = "לא";
                        btnChoice3.Text = "כן";
                        btnChoice2.Enabled = false;
                        btnChoice2.BackgroundImage=Image.FromFile(Application.StartupPath + $@"\DATA\QIMAGES\{q1.Picture}");
                        break;
                    case 3:
                        
                     btnChoice2.Enabled = true;
                        lblTop.Text = q.Question;
                        string[] arraystr1 = new string[] { q.CAnswer, q.WAnswer1, q.WAnswer2 };
                        List<string> answers1 = new List<string>(arraystr1);
                        i = rnd.Next(answers1.Count);
                        btnChoice1.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\DATA\QIMAGES\{answers1[i]}");
                        rAnswer1 = answers1[i];
                        answers1.RemoveAt(i);
                        rAnswer2 = answers1[0];
                        rAnswer3 = answers1[1];
                        btnChoice2.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\DATA\QIMAGES\{answers1[0]}");
                        btnChoice3.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\DATA\QIMAGES\{answers1[1]}");
                        break;
                }
                quest++;
                return;
            }
            else GameOver();
            return;
        }
        public void GameOver()         //מתודה שתפקידה להציג לשחקן שהמשחק נגמר, ולהכניס את נתוניו לסטטיסטיקה ואיפוס הפקדים
        {
            if (practice == false)
            {
                timer1.Stop();
                lblTop.Text = "המשחק נגמר";
                btnChoice1.Visible = false;
                btnChoice2.Visible = false;
                btnChoice3.Visible = false;
                string[] name = mail.Split('@');
                string uName = name[0] + "_" + DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’_’mm’_’ss");
                StreamWriter sw = new StreamWriter(Application.StartupPath + $@"\DATA\{uName}.txt");
                sw.WriteLine("the time is" + timeCounter + "\r\n wrong answers:" + wrong + "\r\n correct answers:" + correct + "\r\n your score is:" + score);
                sw.WriteLine(" ---the question numbers with mistakes---");
                for (int i = 0; i < qWList.Count - 1; i++)
                    sw.Write(qWList[i] + ",");
                if (qWList.Count != 0)
                    sw.Write(qWList[qWList.Count - 1]);
                sw.Close();
                MessageBox.Show($"{correct}: שאלות נכונות" +" \r\n" + $"{wrong}: שאלות שגויות" + "\r\n" + $"{score}: נקודות");
            }
            score = 0;
            wrong = 0;
            quest=0;
            correct = 0;
            timeCounter = 0;
            practice = false;
            ShowMenu();
            return;
        }
        public void CheckAnswer(string answer, string str ,string correctA)   ///מתודה שתפקידה לבדוק האם התשובה שהמשתמש בחר היא נכונה
        {
            if (qRandomList[quest-1].Qtype == 3)
                answer = str;
            if (answer == correctA)
            {
                MessageBox.Show("!צדקת");
                correct++;
                score += 10;
            }
            else
            {
                MessageBox.Show("טעית");
                wrong++;
                qWList.Add(qRandomList[quest-1].Qnumber);
            }
            ClearAnswers();
            ShowQuestion(qRandomList.Count);
            return;
        }
        private void btnChoice1_Click(object sender, EventArgs e)    ///אירוע לחיצת כפתור בחירת תשובה 
        {
            CheckAnswer(btnChoice1.Text, rAnswer1,qRandomList[quest-1].CAnswer);
            return;
        }

        private void btnChoice2_Click(object sender, EventArgs e)    ///אירוע לחיצת כפתור בחירת תשובה 
        {
            CheckAnswer(btnChoice2.Text,rAnswer2 ,qRandomList[quest-1].CAnswer);
            return;
        }

        private void timer1_Tick(object sender, EventArgs e)    //אירוע שמתייסים לחישוב זמן המשחק של השחקן
        {
            timeCounter++;
        }

        private void btnChoice3_Click(object sender, EventArgs e)     ///אירוע לחיצת כפתור בחירת תשובה 
        {
            CheckAnswer(btnChoice3.Text,rAnswer3 ,qRandomList[quest-1].CAnswer);
            return;
        }

        private void btnFinal_Click(object sender, EventArgs e)   ///אירוע חזרה למסך הראשי
        {
            this.Close();
        }

        private void btnSameGame_Click(object sender, EventArgs e)   ///אירוע חזרה על אותו משחק ששיחק בפעם האחרונה
        {
            timer1.Start();
            qWList.Clear();
            ClearMenu();
            ShowQuestion(7);
        }
         public void ClearMenu()            ///אירוע שנועד להסתיר את המקשים הלא רלוונטים לדף הנוכחי בו נמצא המשתמש
        {
            btnPractice.Visible = false;
            btnFinal.Visible = false;
            btnSameGame.Visible = false;
            btncAnswers.Visible = false;
            btnNewGame.Visible = false;  
        }

        private void btnNewGame_Click(object sender, EventArgs e)   ///אירוע שנועד ליצור משחק טריוויה חדש 
        {
            timer1.Start();
            qWList.Clear();
            qRandomList.Clear();
            CreateRandomList();
            ClearMenu();
            ShowQuestion(7);
        }

        public void ClearAnswers()       ///אירוע שנועד לאפס את תשובות שרשומות בכפתורים,ואיפוס הרקעים
        {
            btnChoice1.Text ="";
            btnChoice2.Text ="";
            btnChoice3.Text ="";
            btnChoice1.BackgroundImage = null;
            btnChoice2.BackgroundImage = null;
            btnChoice3.BackgroundImage = null;
        }

        private void btncAnswers_Click(object sender, EventArgs e) //	בחירת אפשרות לראות את התשובות הנכונות לשאלות בהן השחקן טעה
        {
            btnChoice1.Enabled = false;
            btnChoice2.Enabled = false;
            quest = qWList.Count;
            ClearMenu();
            lblTop.Visible = true;
            btnChoice1.Visible = true;  
            ShowAnswers();
            btnNext.Visible = true;
        }
        private void ShowAnswers()         ////מתודה שמציגה את התשובה הנכונה לשאלה שהמשתמש טעה
        {  
            while(counter < 7)
            {
                if(qWList.Contains(qRandomList[counter].Qnumber))
                {
                    Questions q = qRandomList[counter];
                    lblTop.Text = q.Question;
                    if (q.Qtype < 2) // סיווג השאלות והצגת השאלה והתשובה או התמונה הנכונה
                    { 
                        btnChoice2.Visible = false;
                        btnChoice1.Text = q.CAnswer;
                        btnChoice1.BackgroundImage = null;
                    }
                    else if (q.Qtype == 2)
                    {
                        btnChoice1.Text = q.CAnswer;
                        btnChoice2.Visible = true;
                        btnChoice1.BackgroundImage = null;
                        btnChoice2.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\DATA\QIMAGES\{((QuestionsWimage)q).Picture}");
                    }
                    else 
                    {
                        btnChoice1.Text = "";
                        btnChoice2.Visible = false;
                        btnChoice1.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\DATA\QIMAGES\{q.CAnswer}"); 
                    }
                    counter++;
                    return;     
                }
                counter++;
            } 
            MessageBox.Show("צפית בכל התשובות לשאלות השגויות-נחזור למסך הראשי");
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e) ///אירוע שנועד לעבור לשאלה הבאה, בקטגוריית צפייה בתשובות הנכונות של השאלות השגויות
        {
            ShowAnswers();
        }

        private void btnPractice_Click(object sender, EventArgs e)  ///אירוע שנועד לתרגל את השאלות השגויות מכל משחקי הטרוייה שהשחקן הנוכחי שיחק
        {
           
            practice = true;
            string[] name = mail.Split('@');
            string[] files = Directory.GetFiles(Application.StartupPath + $@"\DATA",$"{name[0]}*.txt"); // מערך בעל כל השמות של הקבצים של המשתמש בנוכחי
            qWList.Clear();
            for(int i=0;i<files.Length;i++)
            {
                StreamReader sr = new StreamReader(files[i]);
                string lastLine = File.ReadLines(files[i]).Last();
                if (lastLine != " ---the question numbers with mistakes---")
                {
                    string[] number = lastLine.Split(',');
                    List<int> numbers = new List<int>();
                    for (int j = 0; j < number.Length; j++)
                    {
                        numbers.Add(int.Parse(number[j]));
                        if (!qWList.Contains(numbers[j]))      // בדיקה כפילויות של שאלות בהן טעה המשתמש
                            qWList.Add(numbers[j]);            // הוספת שאלות שהמשתמש בטעה בהן     
                    }
                    numbers.Clear();
                }
                sr.Close();
            }
            if (qWList.Count == 0) //למשתמש אין טעויות נציג הודעה מתאימה
            {
                MessageBox.Show("לא נמצאו טעויות שאותן תוכל לתרגל");
                return;
            }
            quest = 0;
            qRandomList.Clear();
            for (int i = 0; i < qList.Count; i++) // נוסיף את השאלות לרשימה שמציגה את השאלות
            {
                if(qWList.Contains(i+1))
                    qRandomList.Add(qList[i]);
            }

            ClearMenu();
            ShowQuestion(qWList.Count); //נציג את השאלות השגויות ע״י המתודה ונשלח לה גם את מספר השאלות
        }
        
        public void ShowMenu()    ///מתודה להצגת תפריט, והסתרת דברים לא רלוונטים
        {
            btnChoice1.Visible = false;
            btnChoice2.Visible = false;
            btnChoice3.Visible = false;
            btnPractice.Visible = true;
            btnFinal.Visible = true;
            btnSameGame.Visible = true;
            btncAnswers.Visible = true;
            btnNewGame.Visible = true;  
        }
        public void CreateRandomList()     /// מתודה שאחראית על יצירת רשימה של שאלות רנדומליות
        {
            List<int> array = new List<int>();
            Random ran = new Random();
            int rnd;
            for (int i = 0; i < 7; i++)
            {
                rnd = ran.Next(0, 39);
                if(array.Contains(rnd))
                    i--;
                else 
                {
                    array.Add(rnd);
                    qRandomList.Add(qList[rnd]);
                }
            }
        }
    }
 } 

