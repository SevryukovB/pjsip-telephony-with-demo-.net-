using System;

namespace Light.Hardware.TelephonyProviders
{
    public class IncomingCallEventArgs : EventArgs
    {
        public IncomingCallEventArgs(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }

        public string PhoneNumber { get; private set; }
    }
}
