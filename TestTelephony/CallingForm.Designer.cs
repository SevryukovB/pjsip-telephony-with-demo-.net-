namespace TestTelephony
{
    partial class CallingForm
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
            if (pjsipTelephony != null)
                pjsipTelephony.IncomingCallEnded -= PjsipTelephony_IncomingCallEnded;
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
            this.AnswerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DeclineBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnswerBtn
            // 
            this.AnswerBtn.Location = new System.Drawing.Point(24, 126);
            this.AnswerBtn.Name = "AnswerBtn";
            this.AnswerBtn.Size = new System.Drawing.Size(75, 23);
            this.AnswerBtn.TabIndex = 0;
            this.AnswerBtn.Text = "Answer";
            this.AnswerBtn.UseVisualStyleBackColor = true;
            this.AnswerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NumberLbl";
            // 
            // DeclineBtn
            // 
            this.DeclineBtn.Location = new System.Drawing.Point(138, 126);
            this.DeclineBtn.Name = "DeclineBtn";
            this.DeclineBtn.Size = new System.Drawing.Size(75, 23);
            this.DeclineBtn.TabIndex = 2;
            this.DeclineBtn.Text = "Decline";
            this.DeclineBtn.UseVisualStyleBackColor = true;
            this.DeclineBtn.Click += new System.EventHandler(this.DeclineBtn_Click);
            // 
            // CallingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeclineBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnswerBtn);
            this.Name = "CallingForm";
            this.Text = "CallingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnswerBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeclineBtn;
    }
}