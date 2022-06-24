namespace GmarProject
{
    partial class frmAddInfoPics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInfoPics));
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblTopic1 = new System.Windows.Forms.Label();
            this.lblDetailes = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.txtDetailes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblpicture = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAdd.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.Maroon;
            this.lblAdd.Location = new System.Drawing.Point(345, 14);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(571, 64);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "ברוכים הבאים לדף הוספת מידע";
            // 
            // lblTopic1
            // 
            this.lblTopic1.AutoSize = true;
            this.lblTopic1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic1.ForeColor = System.Drawing.Color.Maroon;
            this.lblTopic1.Location = new System.Drawing.Point(674, 131);
            this.lblTopic1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopic1.Name = "lblTopic1";
            this.lblTopic1.Size = new System.Drawing.Size(146, 42);
            this.lblTopic1.TabIndex = 3;
            this.lblTopic1.Text = "נושא המידע";
            // 
            // lblDetailes
            // 
            this.lblDetailes.AutoSize = true;
            this.lblDetailes.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailes.ForeColor = System.Drawing.Color.Maroon;
            this.lblDetailes.Location = new System.Drawing.Point(639, 237);
            this.lblDetailes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetailes.Name = "lblDetailes";
            this.lblDetailes.Size = new System.Drawing.Size(182, 42);
            this.lblDetailes.TabIndex = 4;
            this.lblDetailes.Text = "מידע על הנושא";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(244, 131);
            this.txtTopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTopic.Multiline = true;
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(301, 56);
            this.txtTopic.TabIndex = 5;
            // 
            // txtDetailes
            // 
            this.txtDetailes.Location = new System.Drawing.Point(244, 237);
            this.txtDetailes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDetailes.Multiline = true;
            this.txtDetailes.Name = "txtDetailes";
            this.txtDetailes.Size = new System.Drawing.Size(301, 213);
            this.txtDetailes.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(84, 620);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 52);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "שמור";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdImage";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Maroon;
            this.btnOpen.Location = new System.Drawing.Point(84, 525);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(112, 54);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "פתח";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(246, 512);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(302, 209);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            // 
            // lblpicture
            // 
            this.lblpicture.AutoSize = true;
            this.lblpicture.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpicture.ForeColor = System.Drawing.Color.Maroon;
            this.lblpicture.Location = new System.Drawing.Point(576, 512);
            this.lblpicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpicture.Name = "lblpicture";
            this.lblpicture.Size = new System.Drawing.Size(245, 42);
            this.lblpicture.TabIndex = 11;
            this.lblpicture.Text = "מקום להוספת תמונה";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(872, 620);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(169, 101);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "חזור לדף הקודם";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddInfoPics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 740);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblpicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtDetailes);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.lblDetailes);
            this.Controls.Add(this.lblTopic1);
            this.Controls.Add(this.lblAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddInfoPics";
            this.Text = "frmAddInfo";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblTopic1;
        private System.Windows.Forms.Label lblDetailes;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.TextBox txtDetailes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblpicture;
        private System.Windows.Forms.Button btnClose;
    }
}