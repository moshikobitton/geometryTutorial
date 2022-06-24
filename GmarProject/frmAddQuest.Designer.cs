namespace GmarProject
{
    partial class frmAddQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddQuest));
            this.label1 = new System.Windows.Forms.Label();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.lblYesOrNo = new System.Windows.Forms.Label();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.lblQuest = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(278, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "שאלות כן או לא(ללא תמונה)";
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYes.ForeColor = System.Drawing.Color.Maroon;
            this.rdbYes.Location = new System.Drawing.Point(225, 206);
            this.rdbYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbYes.Size = new System.Drawing.Size(64, 46);
            this.rdbYes.TabIndex = 1;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "כן";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.ForeColor = System.Drawing.Color.Maroon;
            this.rdbNo.Location = new System.Drawing.Point(333, 206);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbNo.Size = new System.Drawing.Size(74, 46);
            this.rdbNo.TabIndex = 2;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "לא";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // lblYesOrNo
            // 
            this.lblYesOrNo.AutoSize = true;
            this.lblYesOrNo.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYesOrNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblYesOrNo.Location = new System.Drawing.Point(459, 206);
            this.lblYesOrNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYesOrNo.Name = "lblYesOrNo";
            this.lblYesOrNo.Size = new System.Drawing.Size(291, 42);
            this.lblYesOrNo.TabIndex = 3;
            this.lblYesOrNo.Text = ":סמן את התשובה הנכונה";
            // 
            // txtQuest
            // 
            this.txtQuest.Location = new System.Drawing.Point(27, 314);
            this.txtQuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuest.Multiline = true;
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.Size = new System.Drawing.Size(380, 147);
            this.txtQuest.TabIndex = 4;
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.ForeColor = System.Drawing.Color.Maroon;
            this.lblQuest.Location = new System.Drawing.Point(459, 314);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(110, 42);
            this.lblQuest.TabIndex = 5;
            this.lblQuest.Text = ":השאלה";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Maroon;
            this.btnAdd.Location = new System.Drawing.Point(141, 510);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(266, 94);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "הוסף שאלה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(719, 492);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(161, 112);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "חזור לדף הקודם";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuest);
            this.Controls.Add(this.txtQuest);
            this.Controls.Add(this.lblYesOrNo);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbYes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddQuest";
            this.Text = "frmAddQuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.Label lblYesOrNo;
        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}