namespace exerc8
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
            this.nota1txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nota2txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nota3txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nota4txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.resultadotxt = new System.Windows.Forms.TextBox();
            this.limparbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nota1txt
            // 
            this.nota1txt.Location = new System.Drawing.Point(230, 31);
            this.nota1txt.Name = "nota1txt";
            this.nota1txt.Size = new System.Drawing.Size(125, 27);
            this.nota1txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nota 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota 2";
            // 
            // nota2txt
            // 
            this.nota2txt.Location = new System.Drawing.Point(230, 82);
            this.nota2txt.Name = "nota2txt";
            this.nota2txt.Size = new System.Drawing.Size(125, 27);
            this.nota2txt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota 3";
            // 
            // nota3txt
            // 
            this.nota3txt.Location = new System.Drawing.Point(230, 124);
            this.nota3txt.Name = "nota3txt";
            this.nota3txt.Size = new System.Drawing.Size(125, 27);
            this.nota3txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota 4";
            // 
            // nota4txt
            // 
            this.nota4txt.Location = new System.Drawing.Point(230, 168);
            this.nota4txt.Name = "nota4txt";
            this.nota4txt.Size = new System.Drawing.Size(125, 27);
            this.nota4txt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultado";
            // 
            // resultadotxt
            // 
            this.resultadotxt.Location = new System.Drawing.Point(230, 414);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.Size = new System.Drawing.Size(125, 27);
            this.resultadotxt.TabIndex = 9;
            // 
            // limparbtn
            // 
            this.limparbtn.Location = new System.Drawing.Point(191, 286);
            this.limparbtn.Name = "limparbtn";
            this.limparbtn.Size = new System.Drawing.Size(94, 29);
            this.limparbtn.TabIndex = 11;
            this.limparbtn.Text = "Limpar";
            this.limparbtn.UseVisualStyleBackColor = true;
            this.limparbtn.Click += new System.EventHandler(this.limparbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 494);
            this.Controls.Add(this.limparbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nota4txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nota3txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nota2txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nota1txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nota1txt;
        private Label label1;
        private Label label2;
        private TextBox nota2txt;
        private Label label3;
        private TextBox nota3txt;
        private Label label4;
        private TextBox nota4txt;
        private Button button1;
        private Label label5;
        private TextBox resultadotxt;
        private Button limparbtn;
    }
}