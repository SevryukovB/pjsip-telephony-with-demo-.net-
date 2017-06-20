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

namespace TestTelephony
{
    public partial class AccountForm : Form
    {
        private Telephony pjsipTelephony;
        

        public AccountForm(Telephony _pjsipTelephony)
        {
            InitializeComponent();
            pjsipTelephony = _pjsipTelephony;
        }

        private void CallBtn_Click(object sender, EventArgs e)
        {
            pjsipTelephony.MakeCall(NumberTb.Text);
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            pjsipTelephony.Transfer(TransferTb.Text);
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            pjsipTelephony.IncomingCall += PjsipTelephony_IncomingCall;
            pjsipTelephony.StateChanged += PjsipTelephony_StateChanged;
        }


        private void PjsipTelephony_StateChanged(object sender, EventArgs e)
        {
            if(InvokeRequired)
            Invoke((Action)delegate
            {
                label2.Text = pjsipTelephony.State.ToString();

                if (pjsipTelephony.State == TelephonyState.Call)
                {
                    EndcallBtn.Visible = true;
                    MuteBtn.Visible = true;
                    UnmuteBtn.Visible = true;
                    TransferTb.Visible = true;
                    TransferBtn.Visible = true;
                }
                else
                {
                    EndcallBtn.Visible = false;
                    MuteBtn.Visible = false;
                    UnmuteBtn.Visible = false;
                    TransferTb.Visible = false;
                    TransferBtn.Visible = false;
                }
            });

            //if (InvokeRequired)
            //{
            //    Invoke(new StateChangeEventHandler(PjsipTelephony_StateChanged), sender, e);
            //}
            //else
            //{
            //    label2.Text = pjsipTelephony.State.ToString();
            //}
        }


        private void PjsipTelephony_IncomingCall(object sender, Light.Hardware.TelephonyProviders.IncomingCallEventArgs e)
        {
            if (InvokeRequired)
            { 
                Invoke(new IncomingCallEventHandler(PjsipTelephony_IncomingCall), sender, e);
            }
            else
            {
                CallingForm callingForm = new CallingForm(pjsipTelephony, e.PhoneNumber);
                callingForm.Show();
            }
        }



        private void MuteBtn_Click(object sender, EventArgs e)
        {
            pjsipTelephony.Mute();
        }

        private void UnmuteBtn_Click(object sender, EventArgs e)
        {
            pjsipTelephony.Unmute();
        }

        private void EndcallBtn_Click(object sender, EventArgs e)
        {
            pjsipTelephony.HangUp();
        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            pjsipTelephony.Dispose();
        }

         
    }
}
