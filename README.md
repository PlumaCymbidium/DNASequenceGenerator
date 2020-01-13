# 生成反向互补序列
## Requirements analysis

### Requirement

* 生成一段序列(800bp±)的反向互补序列
* 支持批量导入导出

### BA

no big deal, just for fun :joy: :joy: :joy:

### References

<http://wikihow.com/Find-the-Reverse-Complement-of-a-DNA-Sequence>
FASTA

## Solution

### Solution A

**use online script** (click the following links)
> [BioInformatics :link: ](http://www.bioinformatics.org/sms/rev_comp.html)
> [GenScript :link: ](https://www.genscript.com/sms2/rev_comp.html)

* 可以支持长度为800bp+的序列，但不支持自动批量导入导出。
* 手动拼接可以实现批量导入导出。
具体方法是在每段序列前添加单独一行
```
>Sequence-name/no
```
名字或者编号自拟。
序列结束换行即可，只要下一段序列有`>Sequence-name/no`开头，是否空行无所谓

### Solution B


### Solution C

