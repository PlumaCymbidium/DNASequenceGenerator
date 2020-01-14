using Pluma.DNASerialGenerator.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pluma.DNASerialGenerator
{
    public partial class MainForm : Form
    {
        public string InputSerials;
        public string OutputSerials;
        public CountpartType Countpart;

        public MainForm()
        {
            InitializeComponent();
        }

        private void rtx_OriginSerials_TextChanged(object sender, EventArgs e)
        {
            this.InputSerials = this.rtx_OriginSerials.Text;

        }

        private void rtx_OutputSerials_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            this.OutputSerials = "";
            if (string.IsNullOrEmpty(this.InputSerials))
            {
                MessageBox.Show("Please do not submit empty content. ");
                return;
            }
            FastaParser parser = new FastaParser(this.InputSerials);
            List<FastaEntry> fastaEntries = parser.ParseFasta();
            if (fastaEntries == null)
            {
                switch (this.Countpart)
                {
                    case CountpartType.ReverseComplement:
                        this.OutputSerials = SerialGenerator.ReverseComplementSerial(this.InputSerials);
                        break;
                    case CountpartType.Reverse:
                        this.OutputSerials = SerialGenerator.ReverseSerial(this.InputSerials);
                        break;
                    case CountpartType.Complement:
                        this.OutputSerials = SerialGenerator.ComplementSerial(this.InputSerials);
                        break;
                    default:
                        MessageBox.Show("Please choose a counterpart. ");
                        break;
                }
                this.rtx_OutputSerials.Text = this.OutputSerials;
                return;
            }
            foreach (FastaEntry f in fastaEntries)
            {
                switch (this.Countpart)
                {
                    case CountpartType.ReverseComplement:
                        f.Sequence = new StringBuilder(SerialGenerator.ReverseComplementSerial(f.Sequence.ToString()));
                        break;
                    case CountpartType.Reverse:
                        f.Sequence = new StringBuilder(SerialGenerator.ReverseSerial(f.Sequence.ToString()));
                        break;
                    case CountpartType.Complement:
                        f.Sequence = new StringBuilder(SerialGenerator.ComplementSerial(f.Sequence.ToString()));
                        break;
                    default:
                        MessageBox.Show("Please choose a counterpart. ");
                        break;
                }
            }
            foreach (FastaEntry entry in fastaEntries)
            {
                this.OutputSerials += entry.ToString();
            }
            this.rtx_OutputSerials.Text = this.OutputSerials;

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.InputSerials = "";
            this.rtx_OriginSerials.Text = "";
            this.rtx_OutputSerials.Text = "";
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String FileString = dialog.FileName;
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
    }
}
