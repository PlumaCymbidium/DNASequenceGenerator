# DNA Sequence Generator :space_invader:

## Requirements analysis

### Original requirement

1. 生成一段序列(800bp±)的反向互补序列
1. 支持批量导入导出

### BA

of no damn use, just for fun :joy: :joy: :joy:

### References

> <http://wikihow.com/Find-the-Reverse-Complement-of-a-DNA-Sequence>  
> [FASTA format :link:](https://en.wikipedia.org/wiki/FASTA_format)  
> <https://rosettacode.org/wiki/FASTA_format#C.23>  
> <https://vlab.amrita.edu/?sub=3&brch=273&sim=1432&cnt=1>  

## Solutions

### Solution A

We have our own tool ! ! !  :v: :smile:  
It is windows form app, which can convert a DNA sequence into its reverse, complement, or reverse-complement counterpart, based on [.Net Core](https://docs.microsoft.com/en-us/dotnet/core/) in [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) with [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/?view=vs-2019)

#### Usage

* 项目root下的publish.zip解压缩以后点击Pluma.DNASequenceGenerator.exe即可使用，可能需要安装.Net Core以及.Net Framework
* 在Input的文本框中输入FASTA格式的序列或直接输入序列，
选择好要生成的是哪种序列（反向、互补、反向互补），
点击提交按钮，会在Output文本框生成目标序列。
* 点击导入按钮选择要导入的文件，支持文本文档和FASTA文件，支持多选文件。
（所有）文件内容会全部显示在Input文本框中，
同上选择目标序列形式，点击提交即可。
* 点击导出按钮，选择路径，命名文件，选择导出格式，支持文本文档和FASTA文件。
会将生成的序列导出到指定文件，内容参考Output文本框。

#### Development log

* winform based on .Net Core does not yet support desinger :unamused: :unamused: :unamused:  
[Updates to .NET Core Windows Forms designer in Visual Studio 16.5 Preview 1](https://devblogs.microsoft.com/dotnet/updates-to-net-core-windows-forms-designer-in-visual-studio-16-5-preview-1/)  
Update Visual Studio Enterprise 2019 16.4.2(current latest version) -> Preview 16.5.0 Preview 1.0(current latest preview version) :smirk:

* ToolStrip和MenuStrip在基于.Net Core的Winform中暂时不支持，考虑后续想办法更新 :unamused: :unamused: :unamused:

* 为了性能FASTA的序列部分用了StringBuilder，但是不是线程安全的，后续更新如果涉及多线程需要更改为StringBuffer :sun_with_face:

* ORF(open reading frame)的概念已经搞清楚了，好像对于版本迭代并无帮助 :sweat_smile: 

### Solution B

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

### Solution C

Use Python's existing algorithm library :smiley:

* * *

> *Always code sober what you said you'd code drunk* :beer: :cocktail: :sake: :wine_glass: :tropical_drink: :beers:
