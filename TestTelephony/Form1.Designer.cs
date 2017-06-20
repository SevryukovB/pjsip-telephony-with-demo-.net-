namespace TestTelephony
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.DomainTb = new System.Windows.Forms.TextBox();
            this.LoginTb = new System.Windows.Forms.TextBox();
            this.PasswdTb = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "Password:";
            // 
            // DomainTb
            // 
            this.DomainTb.Location = new System.Drawing.Point(74, 23);
            this.DomainTb.Name = "DomainTb";
            this.DomainTb.Size = new System.Drawing.Size(100, 20);
            this.DomainTb.TabIndex = 3;
            this.DomainTb.Text = "192.168.1.10";
            // 
            // LoginTb
            // 
            this.LoginTb.Location = new System.Drawing.Point(74, 56);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.Size = new System.Drawing.Size(100, 20);
            this.LoginTb.TabIndex = 4;
            this.LoginTb.Text = "201";
            // 
            // PasswdTb
            // 
            this.PasswdTb.Location = new System.Drawing.Point(74, 88);
            this.PasswdTb.Name = "PasswdTb";
            this.PasswdTb.Size = new System.Drawing.Size(100, 20);
            this.PasswdTb.TabIndex = 5;
            this.PasswdTb.Text = "jf83hfhef";
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(74, 128);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 6;
            this.EnterBtn.Text = "button1";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 186);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.PasswdTb);
            this.Controls.Add(this.LoginTb);
            this.Controls.Add(this.DomainTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DomainTb;
        private System.Windows.Forms.TextBox LoginTb;
        private System.Windows.Forms.TextBox PasswdTb;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label label4;
    }
}

