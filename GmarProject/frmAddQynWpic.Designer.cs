namespace GmarProject
{
    partial class frmAddQynWpic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQynWpic));
            this.lblTopic2 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblImage2 = new System.Windows.Forms.Label();
            this.btnAddD = new System.Windows.Forms.Button();
            this.btnOpenn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.lblQuest = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopic2
            // 
            this.lblTopic2.AutoSize = true;
            this.lblTopic2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic2.ForeColor = System.Drawing.Color.Maroon;
            this.lblTopic2.Location = new System.Drawing.Point(288, 69);
            this.lblTopic2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopic2.Name = "lblTopic2";
            this.lblTopic2.Size = new System.Drawing.Size(304, 42);
            this.lblTopic2.TabIndex = 0;
            this.lblTopic2.Text = "שאלות כן או לא עם תמונה";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.Color.Maroon;
            this.lblText1.Location = new System.Drawing.Point(531, 182);
            this.lblText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(282, 42);
            this.lblText1.TabIndex = 2;
            this.lblText1.Text = "סמן את התשובה הנכונה";
            // 
            // lblImage2
            // 
            this.lblImage2.AutoSize = true;
            this.lblImage2.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage2.ForeColor = System.Drawing.Color.Maroon;
            this.lblImage2.Location = new System.Drawing.Point(531, 412);
            this.lblImage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage2.Name = "lblImage2";
            this.lblImage2.Size = new System.Drawing.Size(168, 42);
            this.lblImage2.TabIndex = 6;
            this.lblImage2.Text = "הוספת תמונה";
            // 
            // btnAddD
            // 
            this.btnAddD.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddD.ForeColor = System.Drawing.Color.Maroon;
            this.btnAddD.Location = new System.Drawing.Point(18, 571);
            this.btnAddD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddD.Name = "btnAddD";
            this.btnAddD.Size = new System.Drawing.Size(112, 62);
            this.btnAddD.TabIndex = 7;
            this.btnAddD.Text = "שמור";
            this.btnAddD.UseVisualStyleBackColor = true;
            this.btnAddD.Click += new System.EventHandler(this.btnAddD_Click);
            // 
            // btnOpenn
            // 
            this.btnOpenn.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenn.ForeColor = System.Drawing.Color.Maroon;
            this.btnOpenn.Location = new System.Drawing.Point(18, 412);
            this.btnOpenn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenn.Name = "btnOpenn";
            this.btnOpenn.Size = new System.Drawing.Size(112, 62);
            this.btnOpenn.TabIndex = 8;
            this.btnOpenn.Text = "פתח";
            this.btnOpenn.UseVisualStyleBackColor = true;
            this.btnOpenn.Click += new System.EventHandler(this.btnOpenn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYes.ForeColor = System.Drawing.Color.Maroon;
            this.rdbYes.Location = new System.Drawing.Point(295, 182);
            this.rdbYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbYes.Size = new System.Drawing.Size(64, 46);
            this.rdbYes.TabIndex = 9;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "כן";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.ForeColor = System.Drawing.Color.Maroon;
            this.rdbNo.Location = new System.Drawing.Point(404, 182);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbNo.Size = new System.Drawing.Size(74, 46);
            this.rdbNo.TabIndex = 10;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "לא";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // txtQuest
            // 
            this.txtQuest.Location = new System.Drawing.Point(140, 258);
            this.txtQuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuest.Multiline = true;
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.Size = new System.Drawing.Size(338, 121);
            this.txtQuest.TabIndex = 11;
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.ForeColor = System.Drawing.Color.Maroon;
            this.lblQuest.Location = new System.Drawing.Point(531, 258);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(101, 42);
            this.lblQuest.TabIndex = 12;
            this.lblQuest.Text = "השאלה";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(140, 412);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(340, 220);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(718, 517);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 115);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "חזור לדף הקודם";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddQynWpic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 676);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.txtQuest);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbYes);
            this.Controls.Add(this.btnOpenn);
            this.Controls.Add(this.btnAddD);
            this.Controls.Add(this.lblImage2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblTopic2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddQynWpic";
            this.Text = "frmAddQynWpic";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopic2;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.Label lblImage2;
        private System.Windows.Forms.Button btnAddD;
        private System.Windows.Forms.Button btnOpenn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnClose;
    }
}