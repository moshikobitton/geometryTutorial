namespace GmarProject
{
    partial class frmTrivia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrivia));
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblTop = new System.Windows.Forms.Label();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSameGame = new System.Windows.Forms.Button();
            this.btnPractice = new System.Windows.Forms.Button();
            this.btncAnswers = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStartGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Maroon;
            this.btnStartGame.Location = new System.Drawing.Point(380, 458);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(157, 74);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "!התחל";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTop.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.Maroon;
            this.lblTop.Location = new System.Drawing.Point(228, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(417, 42);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "ברוכים הבאים למשחק הטריוויה שלנו";
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChoice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoice1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.ForeColor = System.Drawing.Color.Maroon;
            this.btnChoice1.Location = new System.Drawing.Point(623, 222);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(209, 218);
            this.btnChoice1.TabIndex = 2;
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Visible = false;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChoice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoice2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.ForeColor = System.Drawing.Color.Maroon;
            this.btnChoice2.Location = new System.Drawing.Point(347, 222);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(220, 218);
            this.btnChoice2.TabIndex = 3;
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Visible = false;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChoice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoice3.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice3.ForeColor = System.Drawing.Color.Maroon;
            this.btnChoice3.Location = new System.Drawing.Point(73, 231);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(218, 218);
            this.btnChoice3.TabIndex = 4;
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Visible = false;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFinal
            // 
            this.btnFinal.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinal.Location = new System.Drawing.Point(671, 327);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(121, 98);
            this.btnFinal.TabIndex = 5;
            this.btnFinal.Text = "לחזור למסך הראשי";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Visible = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(559, 156);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(125, 93);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "משחק חדש";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSameGame
            // 
            this.btnSameGame.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSameGame.Location = new System.Drawing.Point(400, 326);
            this.btnSameGame.Name = "btnSameGame";
            this.btnSameGame.Size = new System.Drawing.Size(121, 99);
            this.btnSameGame.TabIndex = 7;
            this.btnSameGame.Text = "חזרה על אותו המשחק";
            this.btnSameGame.UseVisualStyleBackColor = true;
            this.btnSameGame.Visible = false;
            this.btnSameGame.Click += new System.EventHandler(this.btnSameGame_Click);
            // 
            // btnPractice
            // 
            this.btnPractice.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPractice.Location = new System.Drawing.Point(255, 156);
            this.btnPractice.Name = "btnPractice";
            this.btnPractice.Size = new System.Drawing.Size(121, 93);
            this.btnPractice.TabIndex = 8;
            this.btnPractice.Text = "תרגול השאלות השגויות";
            this.btnPractice.UseVisualStyleBackColor = true;
            this.btnPractice.Visible = false;
            this.btnPractice.Click += new System.EventHandler(this.btnPractice_Click);
            // 
            // btncAnswers
            // 
            this.btncAnswers.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncAnswers.Location = new System.Drawing.Point(113, 278);
            this.btncAnswers.Name = "btncAnswers";
            this.btncAnswers.Size = new System.Drawing.Size(121, 162);
            this.btncAnswers.TabIndex = 9;
            this.btncAnswers.Text = "צפייה בתשובות הנכונות של לשאלות שטעית";
            this.btncAnswers.UseVisualStyleBackColor = true;
            this.btncAnswers.Visible = false;
            this.btncAnswers.Click += new System.EventHandler(this.btncAnswers_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(82, 472);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 49);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 533);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btncAnswers);
            this.Controls.Add(this.btnPractice);
            this.Controls.Add(this.btnSameGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.btnStartGame);
            this.Name = "frmTrivia";
            this.Text = "TriviaGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSameGame;
        private System.Windows.Forms.Button btnPractice;
        private System.Windows.Forms.Button btncAnswers;
        private System.Windows.Forms.Button btnNext;
    }
}