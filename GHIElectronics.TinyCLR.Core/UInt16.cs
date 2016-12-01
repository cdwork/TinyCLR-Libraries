////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace System
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Globalization;

    /**
     * Wrapper for unsigned 16 bit integers.
     */
    [Serializable, CLSCompliant(false)]
    public struct UInt16
    {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
        private ushort m_value;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value

        public const ushort MaxValue = (ushort)0xFFFF;
        public const ushort MinValue = 0;

        public override String ToString()
        {
            return Number.Format(m_value, true, "G", NumberFormatInfo.CurrentInfo);
        }

        public String ToString(String format)
        {
            return Number.Format(m_value, true, format, NumberFormatInfo.CurrentInfo);
        }

        [CLSCompliant(false)]
        public static ushort Parse(String s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }

            return Convert.ToUInt16(s);
        }

        public static bool TryParse(string s, out ushort b) {
            b = default(ushort);

            try {
                b = ushort.Parse(s);

                return true;
            }
            catch {
                return false;
            }
        }

    }
}


