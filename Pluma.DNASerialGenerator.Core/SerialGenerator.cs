using System;
using System.Collections.Generic;
using System.Text;

namespace Pluma.DNASerialGenerator.Core
{
    public static class SerialGenerator
    {
        public static string ReverseSerial(string serial)
        {
            char[] basePairs = serial.ToCharArray();
            Array.Reverse(basePairs);
            return String.Concat(basePairs);
        }

        public static string ComplementSerial(string serial)
        {
            char[] basePairs = serial.ToCharArray();
            string complementarySerial = "";
            foreach (char basePair in basePairs)
            {
                switch (basePair)
                {
                    case 'A':
                        complementarySerial += "T";
                        break;
                    case 'T':
                        complementarySerial += "A";
                        break;
                    case 'C':
                        complementarySerial += "G";
                        break;
                    case 'G':
                        complementarySerial += "C";
                        break;
                    case 'a':
                        complementarySerial += "t";
                        break;
                    case 't':
                        complementarySerial += "a";
                        break;
                    case 'c':
                        complementarySerial += "g";
                        break;
                    case 'g':
                        complementarySerial += "c";
                        break;
                    default:
                        complementarySerial += "*";
                        break;
                }
            }
            return complementarySerial;
        }

        public static string ReverseComplementSerial(string serial)
        {
            string complementarySerial = ComplementSerial(serial);
            return ReverseSerial(complementarySerial);
        }
    }
}

public enum CountpartType
{
    ReverseComplement = 1,
    Reverse = 2,
    Complement = 3
}
