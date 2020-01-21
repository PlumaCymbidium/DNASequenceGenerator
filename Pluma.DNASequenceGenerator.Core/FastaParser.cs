using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluma.DNASequenceGenerator.Core
{
    public class FastaParser
    {
        public string[] SingleSequences;
        public FastaParser(string originStr)
        {
            if (originStr != null)
            {
                this.SingleSequences = originStr.Split(new string[] { ">" }, StringSplitOptions.RemoveEmptyEntries);
                this.SingleSequences = this.SingleSequences.Where(s => !s.StartsWith(@"//")).ToArray();
            }
        }
        public List<FastaEntry> ParseFasta()
        {
            List<FastaEntry> entries = new List<FastaEntry>();
            if (SingleSequences == null || SingleSequences.Length < 1) { return null; }
            foreach (string sequence in SingleSequences)
            {
                string[] segments = sequence.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                segments = segments.Where(s => !s.StartsWith("//")).ToArray();
                if (segments.Length <= 1) { return null; }
                entries.Add(new FastaEntry
                {
                    Name = segments[0],
                    Sequence = new StringBuilder(string.Join(" ", segments.Skip(1)))
                });
            }
            return entries;
        }

    }

}
