namespace Pluma.DNASerialGenerator
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
            this.rtx_OriginSerials = new System.Windows.Forms.RichTextBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.rtx_OutputSerials = new System.Windows.Forms.RichTextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtx_OriginSerials
            // 
            this.rtx_OriginSerials.Location = new System.Drawing.Point(77, 81);
            this.rtx_OriginSerials.Name = "rtx_OriginSerials";
            this.rtx_OriginSerials.Size = new System.Drawing.Size(729, 167);
            this.rtx_OriginSerials.TabIndex = 0;
            this.rtx_OriginSerials.Text = "";
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(77, 47);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(90, 17);
            this.lbl_Input.TabIndex = 1;
            this.lbl_Input.Text = "Input serial(s):";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(77, 269);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(100, 17);
            this.lbl_Output.TabIndex = 2;
            this.lbl_Output.Text = "Output serial(s):";
            // 
            // rtx_OutputSerials
            // 
            this.rtx_OutputSerials.Location = new System.Drawing.Point(77, 313);
            this.rtx_OutputSerials.Name = "rtx_OutputSerials";
            this.rtx_OutputSerials.Size = new System.Drawing.Size(729, 193);
            this.rtx_OutputSerials.TabIndex = 3;
            this.rtx_OutputSerials.Text = "";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(731, 527);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 26);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(601, 527);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 26);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(962, 597);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.rtx_OutputSerials);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.rtx_OriginSerials);
            this.Name = "MainForm";
            this.Text = "DNA Serial Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtx_OriginSerials;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.RichTextBox rtx_OutputSerials;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_Clear;
    }
}

