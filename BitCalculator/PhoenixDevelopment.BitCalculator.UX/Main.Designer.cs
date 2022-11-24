namespace PhoenixDevelopment.BitCalculator.UX
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelBits = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelHex = new System.Windows.Forms.Label();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.AcceptsReturn = true;
            this.textBoxInput.AcceptsTab = true;
            this.textBoxInput.Location = new System.Drawing.Point(12, 25);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(510, 57);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(127, 13);
            this.labelInput.TabIndex = 1;
            this.labelInput.Text = "String to encode (UTF-8):";
            // 
            // labelBits
            // 
            this.labelBits.AutoSize = true;
            this.labelBits.Location = new System.Drawing.Point(12, 91);
            this.labelBits.Name = "labelBits";
            this.labelBits.Size = new System.Drawing.Size(55, 13);
            this.labelBits.TabIndex = 4;
            this.labelBits.Text = "Size (bits):";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(73, 88);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.ReadOnly = true;
            this.textBoxSize.Size = new System.Drawing.Size(449, 20);
            this.textBoxSize.TabIndex = 5;
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Location = new System.Drawing.Point(12, 117);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(55, 13);
            this.labelHex.TabIndex = 6;
            this.labelHex.Text = "Hex Data:";
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(73, 114);
            this.textBoxHex.Multiline = true;
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.ReadOnly = true;
            this.textBoxHex.Size = new System.Drawing.Size(449, 138);
            this.textBoxHex.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 264);
            this.Controls.Add(this.textBoxHex);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelBits);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "String Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelBits;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.TextBox textBoxHex;
    }
}

