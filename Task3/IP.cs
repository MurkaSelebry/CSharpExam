using System;
using System.Collections.Generic;

namespace Task3
{
    public class IP 
    {
        public byte IPLevel1 { get; }
        public byte IPLevel2 { get; }
        public byte IPLevel3 { get; }
        public byte IPLevel4 { get; }

        public IP(byte ipLevel1, byte ipLevel2, byte ipLevel3, byte ipLevel4)
        {
            IPLevel1 = ipLevel1;
            IPLevel2 = ipLevel2;
            IPLevel3 = ipLevel3;
            IPLevel4 = ipLevel4;
        }

        public static int operator -(IP left, IP right)
        {
            if (left > right)
            {
                return ((left.IPLevel1 + 1) * 255 * 255 * 255 + (left.IPLevel2 + 1) * 255 * 255 +
                        (left.IPLevel3 + 1) * 255 + left.IPLevel4 + 1) - ((right.IPLevel1 + 1) * 255 * 255 * 255 +
                                                                          (right.IPLevel2 + 1) * 255 * 255 +
                                                                          (right.IPLevel3 + 1) * 255 + right.IPLevel4 +
                                                                          1);
            }

            return -1;
        }
        public static bool operator <(IP left, IP right)
        {
            if (left.IPLevel1 < right.IPLevel1) return true;
            if (left.IPLevel2 < right.IPLevel2) return true;
            if (left.IPLevel3 < right.IPLevel3) return true;
            if (left.IPLevel4 < right.IPLevel4) return true;
            return false;
        }
        public static bool operator >(IP left, IP right)
        {
            if (left.IPLevel1 > right.IPLevel1) return true;
            if (left.IPLevel2 > right.IPLevel2) return true;
            if (left.IPLevel3 > right.IPLevel3) return true;
            if (left.IPLevel4 > right.IPLevel4) return true;
            return false;  
        }
    }
}