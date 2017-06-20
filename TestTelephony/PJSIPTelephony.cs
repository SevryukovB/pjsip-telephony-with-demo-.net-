using Light.Hardware.TelephonyProviders;
using PJSIP;
using pjsipDotNetSDK;
using System.Linq;
using System.Threading;
using Call = pjsipDotNetSDK.Call;

namespace TestTelephony
{
    public class PJSIPTelephony : Telephony
    {
        private SipManager sm;
        public PJSIPTelephony()
        {
            sm = new SipManager(Thread.CurrentThread);
            
            sm.AccountStateChange += Sm_AccountStateChange;
            sm.CallStateChange += Sm_CallStateChange;
            sm.IncomingCall += Sm_IncomingCall;
        }

        #region Dispose

        public override void Dispose()
        {
            base.Dispose();
            if (sm != null)
            {
                sm.Dispose();
                sm = null;
            }
        }

        #endregion

        #region State

        private void Sm_CallStateChange(object sender, CallStateEventArgs e)
        {
            if (e.Call.State == pjsip_inv_state.PJSIP_INV_STATE_DISCONNECTED)
                CallIncomingCallEnded(e.Call.CallingNumber);
            CallStateChanged();
        }

        private void Sm_IncomingCall(object sender, pjsipDotNetSDK.IncomingCallEventArgs e)
        {
            CallIncomingCall(e.Call.CallingNumber);
        }

        private void Sm_AccountStateChange(object sender, AccountStateEventArgs e)
        {
            registrationOK = e.State == pjsip_status_code.PJSIP_SC_OK;
            registrationFinished?.Set();
        }

        public override TelephonyState State
        {
            get
            {
                if (sm?.Accounts.Count == 0)
                    return TelephonyState.NotRegistered;
                Call activeCall = GetActiveCall();
                if (activeCall == null)
                    return TelephonyState.Free;
                if (!activeCall.HasAudioOut)
                    return TelephonyState.OnHold;
                return TelephonyState.Call;
            }
        }

        #endregion State

        private AutoResetEvent registrationFinished = null;
        private bool registrationOK = false;

        public override void Register(string Login, string Password, string Domain, int Port = 5060)
        {
            using (registrationFinished = new AutoResetEvent(false))
            {
                sm.addAccount(Login, Password, Domain);
                if (!registrationFinished.WaitOne(15000))
                    LastErrorText = Properties.ResourceFile.LastErrorTextTimeOut;
                else if (registrationOK)
                    LastErrorText = string.Empty;
                else
                    LastErrorText = Properties.ResourceFile.LastErrorTextBadRequisites;
                CallStateChanged();
            }
        }

        public override void MakeCall(string PhoneNumber)
        {
           sm.DefaultAccount?.makeCall(PhoneNumber);
        }

        public override void Mute()
        {
            GetActiveCall()?.stopTransmit();
        }

        public override void Unmute()
        {
            GetActiveCall()?.startTransmit();
        }

        public override void Transfer(string Login)
        {
            GetActiveCall()?.transfer(Login);
        }

        public override void HangUp()
        {
            GetActiveCall()?.hangup();
        }

        public override void AcceptIncomingCall()
        {
            GetIncomingCall()?.answer();
        }

        public override void DeclineIncomingCall()
        {
            GetActiveCall()?.hangup();
        }

        private Call GetActiveCall()
        {
            return sm.DefaultAccount?.Calls.FirstOrDefault(x => x.Value.State == pjsip_inv_state.PJSIP_INV_STATE_CONFIRMED
                                                               //for hang up in waiting to answer
                                                               || x.Value.State == pjsip_inv_state.PJSIP_INV_STATE_EARLY).Value;
        }

        private Call GetIncomingCall()
        {
            return sm.DefaultAccount.Calls.
                FirstOrDefault(x => x.Value.State == pjsip_inv_state.PJSIP_INV_STATE_INCOMING).Value;
        }
    }
}
