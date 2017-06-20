using System;

namespace Light.Hardware.TelephonyProviders
{
    public abstract class Telephony : IDisposable
    {
        public Telephony()
        {
        }

        #region Errors

        private string lastErrorText = string.Empty;

        /// <summary>
        /// Error on last command called.
        /// </summary>
        public string LastErrorText
        {
            get
            {
                return lastErrorText;
            }
            protected set
            {
                lastErrorText = value;
                ShowError();
            }
        }

       private void ShowError()
        {
            if (!string.IsNullOrEmpty(LastErrorText))
                System.Windows.Forms.MessageBox.Show(LastErrorText);
        }

        #endregion Errors

        #region Dispose
        
        public virtual void Dispose()
        {
        }

        #endregion

        public abstract TelephonyState State
        {
            get;
        }

        public event EventHandler StateChanged;

        protected void CallStateChanged()
        {
            StateChanged?.Invoke(this, EventArgs.Empty);
        }

        public abstract void Register(string Login, string Password, string Domain, int Port);

        #region Call operations

        public abstract void MakeCall(string PhoneNumber);

        public abstract void Mute();

        public abstract void Unmute();

        public abstract void Transfer(string Login);

        public abstract void HangUp();

        #endregion Call operations

        #region Incoming call

        public event IncomingCallEventHandler IncomingCall;

        protected void CallIncomingCall(string PhoneNumber)
        {
            IncomingCall?.Invoke(this, new IncomingCallEventArgs(PhoneNumber));
        }

        public event IncomingCallEventHandler IncomingCallEnded;

        protected void CallIncomingCallEnded(string PhoneNumber)
        {
            IncomingCallEnded?.Invoke(this, new IncomingCallEventArgs(PhoneNumber));
        }

        public abstract void AcceptIncomingCall();

        public abstract void DeclineIncomingCall();

        #endregion Incoming call
    }
}
