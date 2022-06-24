namespace GmarProject
{
    partial class frmLearning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLearning));
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblheadTopic = new System.Windows.Forms.Label();
            this.picTopic = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.rchInfo = new System.Windows.Forms.RichTextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTopic)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(910, 115);
            this.cmbMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(354, 28);
            this.cmbMenu.TabIndex = 0;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.White;
            this.lblTopic.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.Maroon;
            this.lblTopic.Location = new System.Drawing.Point(1164, 52);
            this.lblTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(95, 48);
            this.lblTopic.TabIndex = 1;
            this.lblTopic.Text = ":נושא";
            // 
            // lblheadTopic
            // 
            this.lblheadTopic.AutoSize = true;
            this.lblheadTopic.BackColor = System.Drawing.Color.White;
            this.lblheadTopic.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheadTopic.ForeColor = System.Drawing.Color.Maroon;
            this.lblheadTopic.Location = new System.Drawing.Point(274, 35);
            this.lblheadTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblheadTopic.Name = "lblheadTopic";
            this.lblheadTopic.Size = new System.Drawing.Size(0, 75);
            this.lblheadTopic.TabIndex = 2;
            // 
            // picTopic
            // 
            this.picTopic.BackColor = System.Drawing.Color.White;
            this.picTopic.Location = new System.Drawing.Point(160, 514);
            this.picTopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picTopic.Name = "picTopic";
            this.picTopic.Size = new System.Drawing.Size(314, 303);
            this.picTopic.TabIndex = 4;
            this.picTopic.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.White;
            this.btnChoose.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.Maroon;
            this.btnChoose.Location = new System.Drawing.Point(1042, 197);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(128, 98);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "בחר";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // rchInfo
            // 
            this.rchInfo.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchInfo.Location = new System.Drawing.Point(18, 262);
            this.rchInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rchInfo.Name = "rchInfo";
            this.rchInfo.ReadOnly = true;
            this.rchInfo.Size = new System.Drawing.Size(697, 190);
            this.rchInfo.TabIndex = 6;
            this.rchInfo.Text = "";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Matura MT Script Capitals", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(151, 878);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 71);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Matura MT Script Capitals", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(503, 878);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(199, 71);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "מסך ראשי";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 980);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rchInfo);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.picTopic);
            this.Controls.Add(this.lblheadTopic);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.cmbMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLearning";
            this.Text = "Watch And Learn ";
            ((System.ComponentModel.ISupportInitialize)(this.picTopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblheadTopic;
        private System.Windows.Forms.PictureBox picTopic;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.RichTextBox rchInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
    }
}