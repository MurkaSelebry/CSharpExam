using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Task3
{
    public class IP
    {
        private byte[] IPLevels { get; }
        private long IPInNumber { get; }
        public IP(string ipS)
        {
            var ip = ipS.Split('.').Select(word => Convert.ToByte(word)).ToArray();
            IPLevels = ip;
            IPInNumber = ConvertFromIpToNumber(IPLevels);
        }
        public static long ConvertFromIpToNumber(byte[] ipLevels)
        {
            return Convert.ToInt64(ipLevels[0]*Math.Pow(256, 3))+ipLevels[1]*256*256+ipLevels[2]*256+ipLevels[3];
        }
        public static long operator -(IP left, IP right)
        {
            return (left > right) ? left.IPInNumber - right.IPInNumber : right.IPInNumber - left.IPInNumber;
        }
        public static bool operator <(IP left, IP right)
        {
            return (left.IPInNumber < right.IPInNumber)? true : false;
        }
        public static bool operator >(IP left, IP right)
        {
            return (left.IPInNumber > right.IPInNumber)? true : false;
        }

        public override string ToString()
        {
            return $"IP: {IPLevels[0]}.{IPLevels[1]}.{IPLevels[2]}.{IPLevels[3]}, also Ip in nubmer variant: {IPInNumber}";
        }
    }
}