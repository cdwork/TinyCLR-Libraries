////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace System
{
    using System.Globalization;
    using System;
    using System.Runtime.CompilerServices;

    /**
     * A place holder class for signed bytes.
     * @author Jay Roxe (jroxe)
     * @version
     */
    [Serializable]
    public struct Byte
    {
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value
        private byte m_value;
#pragma warning restore CS0649 // Field is never assigned to, and will always have its default value

        /**
         * The maximum value that a <code>Byte</code> may represent: 127.
         */
        public const byte MaxValue = (byte)0xFF;

        /**
         * The minimum value that a <code>Byte</code> may represent: -128.
         */
        public const byte MinValue = 0;

        public override String ToString()
        {
            return Number.Format(m_value, true, "G", NumberFormatInfo.CurrentInfo);
        }

        public String ToString(String format)
        {
            return Number.Format(m_value, true, format, NumberFormatInfo.CurrentInfo);
        }

        [CLSCompliant(false)]
        public static byte Parse(String s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }

            return Convert.ToByte(s);
        }

        public static bool TryParse(string s, out byte b) {
            b = default(byte);

            try {
                b = byte.Parse(s);

                return true;
            }
            catch {
                return false;
            }
        }
    }
}


