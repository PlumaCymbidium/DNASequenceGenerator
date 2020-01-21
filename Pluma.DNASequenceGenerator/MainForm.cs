using Pluma.DNASequenceGenerator.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Pluma.DNASequenceGenerator
{
    public partial class MainForm : Form
    {
        public string InputSequences;
        public string OutputSequences;
        public CountpartType Countpart;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ClearSequences()
        {
            this.InputSequences = "";
            this.rtx_OriginSequences.Text = "";
            this.OutputSequences = "";
            this.rtx_OutputSequences.Text = "";
        }

        private void rtx_OriginSequences_TextChanged(object sender, EventArgs e)
        {
            this.InputSequences = this.rtx_OriginSequences.Text;

        }

        private void rtx_OutputSequences_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.OutputSequences = "";
            if (string.IsNullOrEmpty(this.InputSequences))
            {
                MessageBox.Show("Please do not submit empty content. ");
                return;
            }
            FastaParser parser = new FastaParser(this.InputSequences);
            List<FastaEntry> fastaEntries = parser.ParseFasta();
            if (fastaEntries == null)
            {
                switch (this.Countpart)
                {
                    case CountpartType.ReverseComplement:
                        this.OutputSequences = SequenceGenerator.ReverseComplementSequence(this.InputSequences);
                        break;
                    case CountpartType.Reverse:
                        this.OutputSequences = SequenceGenerator.ReverseSequence(this.InputSequences);
                        break;
                    case CountpartType.Complement:
                        this.OutputSequences = SequenceGenerator.ComplementSequence(this.InputSequences);
                        break;
                    default:
                        MessageBox.Show("Please choose a counterpart. ");
                        break;
                }
                this.rtx_OutputSequences.Text = this.OutputSequences;
                return;
            }
            foreach (FastaEntry f in fastaEntries)
            {
                switch (this.Countpart)
                {
                    case CountpartType.ReverseComplement:
                        f.Sequence = new StringBuilder(SequenceGenerator.ReverseComplementSequence(f.Sequence.ToString()));
                        break;
                    case CountpartType.Reverse:
                        f.Sequence = new StringBuilder(SequenceGenerator.ReverseSequence(f.Sequence.ToString()));
                        break;
                    case CountpartType.Complement:
                        f.Sequence = new StringBuilder(SequenceGenerator.ComplementSequence(f.Sequence.ToString()));
                        break;
                    default:
                        MessageBox.Show("Please choose a counterpart. ");
                        break;
                }
            }
            foreach (FastaEntry entry in fastaEntries)
            {
                this.OutputSequences += entry.ToString();
            }
            this.rtx_OutputSequences.Text = this.OutputSequences;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearSequences();
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|FASTA files (*.fasta)|*.fasta|All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ClearSequences();
                foreach (string file in openFileDialog.FileNames)
                {
                    string pathName = Path.GetDirectoryName(file);
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    StreamReader sr = new StreamReader(file);
                    this.InputSequences += $"// { pathName } { fileName }\n";
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        this.InputSequences += $"{ line }\n";
                    }
                    sr.Close();
                }
                this.rtx_OriginSequences.Text = this.InputSequences;
            }
            else MessageBox.Show("Please select at least one file. ");
        }

        private void cmb_Counterpart_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmb_Counterpart.SelectedItem.ToString())
            {
                case "Reverse":
                    this.Countpart = CountpartType.Reverse;
                    break;
                case "Complement":
                    this.Countpart = CountpartType.Complement;
                    break;
                case "Reverse-complement":
                    this.Countpart = CountpartType.ReverseComplement;
                    break;
                default:
                    this.Countpart = 0;
                    break;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // using (SaveFileDialog saveFileDialog = new SaveFileDialog()) // in case of the application hanging
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|FASTA files (*.fasta)|*.fasta";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            //saveFileDialog.FileName = $@"{cmb_Counterpart.Text}_{DateTime.Now.ToString("yyyyMMddhhmmss")}";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //string localFilePath = saveFileDialog.FileName.ToString(); 
                //string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                File.WriteAllText(saveFileDialog.FileName, this.OutputSequences);
            }
        }
    }
}
