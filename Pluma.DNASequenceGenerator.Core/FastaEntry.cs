using System;
using System.Text;

namespace Pluma.DNASequenceGenerator.Core
{
    public class FastaEntry
    {
        public string Name { get; set; }

        public StringBuilder Sequence { get; set; }

        public override string ToString()
        {
            return $">{ Name }\n{ Sequence.ToString() }\n";
        }
    }
}
