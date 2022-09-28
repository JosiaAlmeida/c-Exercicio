namespace exerc5
{
    partial class Form1
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
            this.Gerarbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gerarbtn
            // 
            this.Gerarbtn.Location = new System.Drawing.Point(33, 125);
            this.Gerarbtn.Name = "Gerarbtn";
            this.Gerarbtn.Size = new System.Drawing.Size(94, 29);
            this.Gerarbtn.TabIndex = 0;
            this.Gerarbtn.Text = "Gerar";
            this.Gerarbtn.UseVisualStyleBackColor = true;
            this.Gerarbtn.Click += new System.EventHandler(this.Gerarbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o Limite";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(263, 29);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(125, 27);
            this.textbox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(33, 222);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 264);
            this.listBox1.TabIndex = 3;
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(294, 125);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(94, 29);
            this.limpar.TabIndex = 4;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 504);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gerarbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Gerarbtn;
        private Label label1;
        private TextBox textbox1;
        private ListBox listBox1;
        private Button limpar;
    }
}