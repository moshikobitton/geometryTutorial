namespace GmarProject
{
    partial class frmEnter
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLearn = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Maroon;
            this.lblLogin.Location = new System.Drawing.Point(744, 146);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(313, 42);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = ":שלום,הכנס את המייל שלך";
            // 
            // btnLearn
            // 
            this.btnLearn.Enabled = false;
            this.btnLearn.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.ForeColor = System.Drawing.Color.Maroon;
            this.btnLearn.Location = new System.Drawing.Point(86, 465);
            this.btnLearn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(230, 169);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "למידה";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Maroon;
            this.btnPlay.Location = new System.Drawing.Point(435, 465);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(230, 169);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "משחק טריוויה";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnData
            // 
            this.btnData.Enabled = false;
            this.btnData.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.Maroon;
            this.btnData.Location = new System.Drawing.Point(796, 465);
            this.btnData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(230, 169);
            this.btnData.TabIndex = 3;
            this.btnData.Text = "הוספת תוכן";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogIn.Location = new System.Drawing.Point(435, 266);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(230, 112);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "התחבר";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(346, 146);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 36);
            this.txtEmail.TabIndex = 6;
            // 
            // frmEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GmarProject.Properties.Resources.WhatsApp_Image_2021_07_12_at_11_34_27;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 949);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.lblLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEnter";
            this.Text = "Log In Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

