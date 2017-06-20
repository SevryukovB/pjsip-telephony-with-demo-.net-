using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Light.Hardware.TelephonyProviders;

namespace TestTelephony.TelephonyProviders
{
    static class TelephonyList
    {
        public static Dictionary<string, Type> implementations = new Dictionary<string, Type>()
            { {"PJSIP", typeof(PJSIPTelephony) } };

        public static Telephony Create(string Implementation)
        {
            return Activator.CreateInstance(implementations[Implementation]) as Telephony;
        }
    }
}
