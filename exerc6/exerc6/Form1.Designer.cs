namespace exerc6
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
            this.limpar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gerarbtn = new System.Windows.Forms.Button();
            this.parcb = new System.Windows.Forms.CheckBox();
            this.imparcb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(303, 122);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(94, 29);
            this.limpar.TabIndex = 9;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(42, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 264);
            this.listBox1.TabIndex = 8;
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(272, 26);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(125, 27);
            this.textbox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite o Limite";
            // 
            // Gerarbtn
            // 
            this.Gerarbtn.Location = new System.Drawing.Point(42, 122);
            this.Gerarbtn.Name = "Gerarbtn";
            this.Gerarbtn.Size = new System.Drawing.Size(94, 29);
            this.Gerarbtn.TabIndex = 5;
            this.Gerarbtn.Text = "Gerar";
            this.Gerarbtn.UseVisualStyleBackColor = true;
            this.Gerarbtn.Click += new System.EventHandler(this.Gerarbtn_Click);
            // 
            // parcb
            // 
            this.parcb.AutoSize = true;
            this.parcb.Location = new System.Drawing.Point(42, 81);
            this.parcb.Name = "parcb";
            this.parcb.Size = new System.Drawing.Size(170, 24);
            this.parcb.TabIndex = 10;
            this.parcb.Text = "Exibir Numeros Pares";
            this.parcb.UseVisualStyleBackColor = true;
            this.parcb.CheckedChanged += new System.EventHandler(this.parcb_CheckedChanged);
            // 
            // imparcb
            // 
            this.imparcb.AutoSize = true;
            this.imparcb.Location = new System.Drawing.Point(227, 81);
            this.imparcb.Name = "imparcb";
            this.imparcb.Size = new System.Drawing.Size(189, 24);
            this.imparcb.TabIndex = 11;
            this.imparcb.Text = "Exibir Numeros Impares";
            this.imparcb.UseVisualStyleBackColor = true;
            this.imparcb.CheckedChanged += new System.EventHandler(this.imparcb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 508);
            this.Controls.Add(this.imparcb);
            this.Controls.Add(this.parcb);
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

        private Button limpar;
        private ListBox listBox1;
        private TextBox textbox1;
        private Label label1;
        private Button Gerarbtn;
        private CheckBox parcb;
        private CheckBox imparcb;
    }
}