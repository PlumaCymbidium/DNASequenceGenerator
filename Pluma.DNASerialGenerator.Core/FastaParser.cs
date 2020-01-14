using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluma.DNASerialGenerator.Core
{
    public class FastaParser
    {
        public string[] SingleSerials;
        public FastaParser(string originStr)
        {
            this.SingleSerials = originStr.Split(new string[] { ">" }, StringSplitOptions.RemoveEmptyEntries);
        }
        public List<FastaEntry> ParseFasta()
        {
            List<FastaEntry> entries = new List<FastaEntry>();
            if (SingleSerials.Length < 1) { return null; }
            foreach (string serial in SingleSerials)
            {
                string[] segments = serial.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                
                if (segments.Length <= 1) { return null; }
                entries.Add(new FastaEntry
                {
                    Name = segments[0],
                    Sequence = new StringBuilder(string.Join(" ",segments.Skip(1)))
                });
            }
            return entries;
        }

    }

}
