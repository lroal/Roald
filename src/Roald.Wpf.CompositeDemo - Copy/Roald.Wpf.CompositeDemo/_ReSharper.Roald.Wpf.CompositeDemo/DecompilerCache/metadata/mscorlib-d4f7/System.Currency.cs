// Type: System.Currency
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime;
using System.Runtime.CompilerServices;
using System.Security;

namespace System
{
    [ForceTokenStabilization]
    [Serializable]
    internal struct Currency
    {
        internal long m_value;

        [ForceTokenStabilization]
        public Currency(decimal value);

        internal Currency(long value, int ignored);
        public static Currency FromOACurrency(long cy);
        public long ToOACurrency();

        [SecuritySafeCritical]
        public static decimal ToDecimal(Currency c);

        [SecurityCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        private static void FCallToDecimal(ref decimal result, Currency c);
    }
}
