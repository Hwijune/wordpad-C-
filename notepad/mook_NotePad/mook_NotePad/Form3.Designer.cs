namespace mook_NotePad
{
    partial class Form3
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
            this.lblAbout04 = new System.Windows.Forms.Label();
            this.lblAbout03 = new System.Windows.Forms.Label();
            this.lblAbout02 = new System.Windows.Forms.Label();
            this.lblAbout01 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAbout04
            // 
            this.lblAbout04.AutoSize = true;
            this.lblAbout04.Location = new System.Drawing.Point(9, 89);
            this.lblAbout04.Name = "lblAbout04";
            this.lblAbout04.Size = new System.Drawing.Size(81, 12);
            this.lblAbout04.TabIndex = 14;
            this.lblAbout04.Text = "컴퓨터 이름 : ";
            // 
            // lblAbout03
            // 
            this.lblAbout03.AutoSize = true;
            this.lblAbout03.Location = new System.Drawing.Point(9, 63);
            this.lblAbout03.Name = "lblAbout03";
            this.lblAbout03.Size = new System.Drawing.Size(81, 12);
            this.lblAbout03.TabIndex = 13;
            this.lblAbout03.Text = "사용자 이름 : ";
            // 
            // lblAbout02
            // 
            this.lblAbout02.AutoSize = true;
            this.lblAbout02.Location = new System.Drawing.Point(9, 37);
            this.lblAbout02.Name = "lblAbout02";
            this.lblAbout02.Size = new System.Drawing.Size(189, 12);
            this.lblAbout02.TabIndex = 12;
            this.lblAbout02.Text = "이 제품은 다음 사용자에게 허가됨";
            // 
            // lblAbout01
            // 
            this.lblAbout01.AutoSize = true;
            this.lblAbout01.Location = new System.Drawing.Point(9, 12);
            this.lblAbout01.Name = "lblAbout01";
            this.lblAbout01.Size = new System.Drawing.Size(60, 12);
            this.lblAbout01.TabIndex = 11;
            this.lblAbout01.Text = "C# 메모장";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(123, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "확 인";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 173);
            this.Controls.Add(this.lblAbout04);
            this.Controls.Add(this.lblAbout03);
            this.Controls.Add(this.lblAbout02);
            this.Controls.Add(this.lblAbout01);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "메모장 정보";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout04;
        private System.Windows.Forms.Label lblAbout03;
        private System.Windows.Forms.Label lblAbout02;
        private System.Windows.Forms.Label lblAbout01;
        private System.Windows.Forms.Button btnClose;

    }
}