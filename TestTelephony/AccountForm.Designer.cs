namespace TestTelephony
{
    partial class AccountForm
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
            this.NumberTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CallBtn = new System.Windows.Forms.Button();
            this.TransferBtn = new System.Windows.Forms.Button();
            this.TransferTb = new System.Windows.Forms.TextBox();
            this.MuteBtn = new System.Windows.Forms.Button();
            this.UnmuteBtn = new System.Windows.Forms.Button();
            this.EndcallBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumberTb
            // 
            this.NumberTb.Location = new System.Drawing.Point(83, 17);
            this.NumberTb.Margin = new System.Windows.Forms.Padding(4);
            this.NumberTb.Name = "NumberTb";
            this.NumberTb.Size = new System.Drawing.Size(132, 22);
            this.NumberTb.TabIndex = 0;
            this.NumberTb.Text = "+380661337290";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number:";
            // 
            // CallBtn
            // 
            this.CallBtn.Location = new System.Drawing.Point(83, 63);
            this.CallBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CallBtn.Name = "CallBtn";
            this.CallBtn.Size = new System.Drawing.Size(100, 28);
            this.CallBtn.TabIndex = 2;
            this.CallBtn.Text = "Call";
            this.CallBtn.UseVisualStyleBackColor = true;
            this.CallBtn.Click += new System.EventHandler(this.CallBtn_Click);
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(16, 272);
            this.TransferBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(100, 28);
            this.TransferBtn.TabIndex = 5;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Visible = false;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // TransferTb
            // 
            this.TransferTb.Location = new System.Drawing.Point(16, 240);
            this.TransferTb.Margin = new System.Windows.Forms.Padding(4);
            this.TransferTb.Name = "TransferTb";
            this.TransferTb.Size = new System.Drawing.Size(132, 22);
            this.TransferTb.TabIndex = 6;
            this.TransferTb.Visible = false;
            // 
            // MuteBtn
            // 
            this.MuteBtn.Location = new System.Drawing.Point(17, 167);
            this.MuteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MuteBtn.Name = "MuteBtn";
            this.MuteBtn.Size = new System.Drawing.Size(100, 28);
            this.MuteBtn.TabIndex = 7;
            this.MuteBtn.Text = "Mute";
            this.MuteBtn.UseVisualStyleBackColor = true;
            this.MuteBtn.Visible = false;
            this.MuteBtn.Click += new System.EventHandler(this.MuteBtn_Click);
            // 
            // UnmuteBtn
            // 
            this.UnmuteBtn.Location = new System.Drawing.Point(153, 166);
            this.UnmuteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UnmuteBtn.Name = "UnmuteBtn";
            this.UnmuteBtn.Size = new System.Drawing.Size(100, 28);
            this.UnmuteBtn.TabIndex = 9;
            this.UnmuteBtn.Text = "Unmute";
            this.UnmuteBtn.UseVisualStyleBackColor = true;
            this.UnmuteBtn.Visible = false;
            this.UnmuteBtn.Click += new System.EventHandler(this.UnmuteBtn_Click);
            // 
            // EndcallBtn
            // 
            this.EndcallBtn.Location = new System.Drawing.Point(216, 63);
            this.EndcallBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EndcallBtn.Name = "EndcallBtn";
            this.EndcallBtn.Size = new System.Drawing.Size(100, 28);
            this.EndcallBtn.TabIndex = 10;
            this.EndcallBtn.Text = "End call";
            this.EndcallBtn.UseVisualStyleBackColor = true;
            this.EndcallBtn.Visible = false;
            this.EndcallBtn.Click += new System.EventHandler(this.EndcallBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndcallBtn);
            this.Controls.Add(this.UnmuteBtn);
            this.Controls.Add(this.MuteBtn);
            this.Controls.Add(this.TransferTb);
            this.Controls.Add(this.TransferBtn);
            this.Controls.Add(this.CallBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberTb);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountForm_FormClosed);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CallBtn;
        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.TextBox TransferTb;
        private System.Windows.Forms.Button MuteBtn;
        private System.Windows.Forms.Button UnmuteBtn;
        private System.Windows.Forms.Button EndcallBtn;
        private System.Windows.Forms.Label label2;
    }
}