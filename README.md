# DNA Serial Genrator :space_invader:

## Requirements analysis

### Original requirement

1. 生成一段序列(800bp±)的反向互补序列
1. 支持批量导入导出

### BA

of no damn use, just for fun :joy: :joy: :joy:

### References

> <http://wikihow.com/Find-the-Reverse-Complement-of-a-DNA-Sequence>  
> [FASTA format :link:](https://en.wikipedia.org/wiki/FASTA_format)  

## Solutions

### Solution A

**use online script** :relaxed: (click the following links)
> [BioInformatics :link: ](http://www.bioinformatics.org/sms/rev_comp.html)  
> [GenScript :link: ](https://www.genscript.com/sms2/rev_comp.html)  

* 可以支持长度为800bp+的FASTA格式的序列，但不支持自动批量导入导出。
* 手动拼接可以实现批量导入导出。
具体方法是将多个DNA序列序列化为FASTA格式的序列直接拼接。

> FASTA format is a **text-based** format for representing either nucleotide sequences or peptide sequences, in which base pairs or amino acids are represented using single-letter codes. 
> A sequence in FASTA format begins with **a single-line description**, followed by lines of sequence data. 
> The description line is distinguished from the sequence data by a **greater-than (">") symbol** in the first column. It is recommended that all lines of text be shorter than 80 characters in length.(800bp要不要分割一下呢 :sweat_smile: )

> An example sequence in FASTA format is:

``` FASTA
>gi|186681228|ref|YP_001864424.1| phycoerythrobilin:ferredoxin oxidoreductase
MNSERSDVTLYQPFLDYAIAYMRSRLDLEPYPIPTGFESNSAVVGKGKNQEEVVTTSYAFQTAKLRQIRA
AHVQGGNSLQVLNFVIFPHLNYDLPFFGADLVTLPGGHLIALDMQPLFRDDSAYQAKYTEPILPIFHAHQ
QHLSWGGDFPEEAQPFFSPAFLWTRPQETAVVETQVFAAFKDYLKAYLDFVEQAEAVTDSQNLVAIKQAQ
LRYLRYRAEKDPARGMFKRFYGAEWTEEYIHGFLFDLERKLTVVK
```

> Sequences are expected to be represented in the standard IUB/IUPAC amino acid and nucleic acid codes, with these exceptions:
> * lower-case letters are accepted and are mapped into upper-case;
> * a single hyphen or dash can be used to represent a gap of indeterminate length;
> * in amino acid sequences, U and * are acceptable letters (see below).
> * any numerical digits in the query sequence should either be removed or replaced by appropriate letter codes (e.g., N for unknown nucleic acid residue or X for unknown amino acid residue).  
> Reference[:link:](https://zhanglab.ccmb.med.umich.edu/FASTA/)  

### Solution B

#### Development log

* winform based on .Net Core does not yet support desinger :unamused: :unamused: :unamused:  
[Updates to .NET Core Windows Forms designer in Visual Studio 16.5 Preview 1](https://devblogs.microsoft.com/dotnet/updates-to-net-core-windows-forms-designer-in-visual-studio-16-5-preview-1/)  
Update Visual Studio Enterprise 2019 16.4.2(current latest version) -> Preview 16.5.0 Preview 1.0(current latest preview version) :smirk:

* ToolStrip和MenuStrip在基于.Net Core的Winform中暂时不支持，考虑后续想办法更新 :unamused: :unamused: :unamused:

* 为了性能FASTA的序列部分用了StringBuilder，但是不是线程安全的，后续更新如果涉及多线程需要更改为StringBuffer :sun_with_face:

### Solution C

Use Python's existing algorithm library :smiley:

> 'always do sober what you'd do drunk'
> 