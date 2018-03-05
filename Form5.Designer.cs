namespace wordpad
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtWord1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOk2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "찾을 내용(&N):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "바꿀 내용(&P):";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(114, 16);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(189, 21);
            this.txtWord.TabIndex = 2;
            // 
            // txtWord1
            // 
            this.txtWord1.Location = new System.Drawing.Point(114, 53);
            this.txtWord1.Name = "txtWord1";
            this.txtWord1.Size = new System.Drawing.Size(189, 21);
            this.txtWord1.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(322, 16);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "다음 찾기(&F)";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnOk2
            // 
            this.btnOk2.Location = new System.Drawing.Point(322, 45);
            this.btnOk2.Name = "btnOk2";
            this.btnOk2.Size = new System.Drawing.Size(98, 23);
            this.btnOk2.TabIndex = 5;
            this.btnOk2.Text = "바꾸기(&R)";
            this.btnOk2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "모두 바꾸기(&A)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(322, 103);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(98, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "취소";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Location = new System.Drawing.Point(14, 90);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(108, 16);
            this.chb2.TabIndex = 8;
            this.chb2.Text = "단어 단위로(&W)";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // chb
            // 
            this.chb.AutoSize = true;
            this.chb.Location = new System.Drawing.Point(14, 112);
            this.chb.Name = "chb";
            this.chb.Size = new System.Drawing.Size(125, 16);
            this.chb.TabIndex = 9;
            this.chb.Text = "대/소문자 구분(&C)";
            this.chb.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 146);
            this.Controls.Add(this.chb);
            this.Controls.Add(this.chb2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOk2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtWord1);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.TextBox txtWord;
        internal System.Windows.Forms.TextBox txtWord1;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.Button btnOk2;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.CheckBox chb2;
        internal System.Windows.Forms.CheckBox chb;
    }
}