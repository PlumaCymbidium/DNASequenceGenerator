using System;

namespace Pluma.DNASequenceGenerator.Core
{
    public static class SequenceGenerator
    {
        public static string ReverseSequence(string sequence)
        {
            char[] basePairs = sequence.ToCharArray();
            Array.Reverse(basePairs);
            return String.Concat(basePairs);
        }

        public static string ComplementSequence(string sequence)
        {
            char[] basePairs = sequence.ToCharArray();
            string complementarySequence = "";
            foreach (char basePair in basePairs)
            {
                switch (basePair)
                {
                    case 'A':
                        complementarySequence += "T";
                        break;
                    case 'T':
                        complementarySequence += "A";
                        break;
                    case 'C':
                        complementarySequence += "G";
                        break;
                    case 'G':
                        complementarySequence += "C";
                        break;
                    case 'a':
                        complementarySequence += "t";
                        break;
                    case 't':
                        complementarySequence += "a";
                        break;
                    case 'c':
                        complementarySequence += "g";
                        break;
                    case 'g':
                        complementarySequence += "c";
                        break;
                    default:
                        complementarySequence += "*";
                        break;
                }
            }
            return complementarySequence;
        }

        public static string ReverseComplementSequence(string sequence)
        {
            string complementarySequence = ComplementSequence(sequence);
            return ReverseSequence(complementarySequence);
        }
    }
}

public enum CountpartType
{
    ReverseComplement = 1,
    Reverse = 2,
    Complement = 3
}
