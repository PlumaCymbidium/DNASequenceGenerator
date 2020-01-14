using System;
using System.Collections.Generic;
using System.Text;

namespace Pluma.DNASerialGenerator.Core
{
    public class FastaParser
    {
        public string[] OriginStrLines;
        public FastaParser(string originStr)
        {
            this.OriginStrLines = originStr.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries); ;
        }
        public IEnumerable<FastaEntry> ParseFasta()
        {
            FastaEntry f = null;
            foreach (string line in this.OriginStrLines)
            {
                while (line != null)
                {
                    if (line.StartsWith(";"))
                        continue;
                    if (line.StartsWith("\n"))
                        continue;
                    if (line.StartsWith(">"))
                    {
                        if (f != null)
                            yield return f;
                        f = new FastaEntry { Name = line.Substring(1), Sequence = new StringBuilder() };
                    }
                    else if (f != null)
                        f.Sequence.Append(line);
                }
            }
            yield return f;
        }

    }

}
