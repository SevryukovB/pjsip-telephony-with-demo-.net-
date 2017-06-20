using pjsipDotNetSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Light.Hardware.TelephonyProviders;
using TestTelephony.TelephonyProviders;

namespace TestTelephony
{
    public partial class Form1 : Form
    {
        private Telephony pjsipTelephony;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pjsipTelephony = TelephonyList.Create("PJSIP");
            label4.Text = pjsipTelephony.State.ToString();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {

            pjsipTelephony.Register(LoginTb.Text, PasswdTb.Text, DomainTb.Text, 5060);

            AccountForm accountForm = new AccountForm(pjsipTelephony);
            accountForm.ShowDialog();
        }
    }
}
