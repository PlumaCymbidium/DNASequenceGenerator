namespace Pluma.DNASequenceGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtx_OriginSequences = new System.Windows.Forms.RichTextBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.rtx_OutputSequences = new System.Windows.Forms.RichTextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cmb_Counterpart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtx_OriginSequences
            // 
            this.rtx_OriginSequences.Location = new System.Drawing.Point(77, 123);
            this.rtx_OriginSequences.Name = "rtx_OriginSequences";
            this.rtx_OriginSequences.Size = new System.Drawing.Size(729, 167);
            this.rtx_OriginSequences.TabIndex = 0;
            this.rtx_OriginSequences.Text = "";
            this.rtx_OriginSequences.TextChanged += new System.EventHandler(this.rtx_OriginSequences_TextChanged);
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(77, 103);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(142, 20);
            this.lbl_Input.TabIndex = 1;
            this.lbl_Input.Text = "Input sequence(s):";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(77, 293);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(156, 20);
            this.lbl_Output.TabIndex = 2;
            this.lbl_Output.Text = "Output sequence(s):";
            // 
            // rtx_OutputSequences
            // 
            this.rtx_OutputSequences.Location = new System.Drawing.Point(77, 313);
            this.rtx_OutputSequences.Name = "rtx_OutputSequences";
            this.rtx_OutputSequences.Size = new System.Drawing.Size(729, 193);
            this.rtx_OutputSequences.TabIndex = 3;
            this.rtx_OutputSequences.Text = "";
            this.rtx_OutputSequences.TextChanged += new System.EventHandler(this.rtx_OutputSequences_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(731, 527);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 26);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(601, 527);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 26);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cmb_Counterpart
            // 
            this.cmb_Counterpart.FormattingEnabled = true;
            this.cmb_Counterpart.Items.AddRange(new object[] {
            "Reverse-complement",
            "Reverse",
            "Complement"});
            this.cmb_Counterpart.Location = new System.Drawing.Point(77, 65);
            this.cmb_Counterpart.Name = "cmb_Counterpart";
            this.cmb_Counterpart.Size = new System.Drawing.Size(257, 28);
            this.cmb_Counterpart.TabIndex = 6;
            this.cmb_Counterpart.SelectedIndexChanged += new System.EventHandler(this.cmb_Counterpart_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Counterpart: ";
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(77, 527);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 26);
            this.btn_Import.TabIndex = 8;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(199, 527);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 26);
            this.btn_Export.TabIndex = 9;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(879, 584);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Counterpart);
            this.Controls.Add(this.rtx_OriginSequences);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rtx_OutputSequences);
            this.Name = "MainForm";
            this.Text = "DNA Sequence Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx_OriginSequences;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.RichTextBox rtx_OutputSequences;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cmb_Counterpart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
    }
}

