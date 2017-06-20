using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Light.Hardware.TelephonyProviders;
using pjsipDotNetSDK;

namespace TestTelephony
{
    public partial class CallingForm : Form
    {
        private Telephony pjsipTelephony;
        private string phoneNumber;

        public CallingForm(Telephony _pjsipTelephony, string PhoneNumber)
        {
            InitializeComponent();
            pjsipTelephony = _pjsipTelephony;
            pjsipTelephony.IncomingCallEnded += PjsipTelephony_IncomingCallEnded;
            phoneNumber = PhoneNumber;
            label1.Text = PhoneNumber;
        }

        private void PjsipTelephony_IncomingCallEnded(object sender, Light.Hardware.TelephonyProviders.IncomingCallEventArgs e)
        {
            if (e.PhoneNumber == phoneNumber)
            {
                Invoke((Action) Close);
            }
        }

        private void AnswerBtn_Click(object sender, EventArgs e)
        {
           pjsipTelephony.AcceptIncomingCall();
        }

        private void DeclineBtn_Click(object sender, EventArgs e)
        {
            pjsipTelephony.DeclineIncomingCall();
        }
    }
}
