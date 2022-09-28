namespace exerc2
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
            this.resultadotxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sairbtn = new System.Windows.Forms.Button();
            this.novoCalculobtn = new System.Windows.Forms.Button();
            this.calcularbtn = new System.Windows.Forms.Button();
            this.value2txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value1txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.somarcb = new System.Windows.Forms.CheckBox();
            this.subtraircb = new System.Windows.Forms.CheckBox();
            this.multiplicarcb = new System.Windows.Forms.CheckBox();
            this.dividircb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // resultadotxt
            // 
            this.resultadotxt.Location = new System.Drawing.Point(12, 309);
            this.resultadotxt.Name = "resultadotxt";
            this.resultadotxt.Size = new System.Drawing.Size(193, 27);
            this.resultadotxt.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Resultado";
            // 
            // sairbtn
            // 
            this.sairbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sairbtn.Location = new System.Drawing.Point(284, 199);
            this.sairbtn.Name = "sairbtn";
            this.sairbtn.Size = new System.Drawing.Size(127, 36);
            this.sairbtn.TabIndex = 25;
            this.sairbtn.Text = "Sair";
            this.sairbtn.UseVisualStyleBackColor = true;
            this.sairbtn.Click += new System.EventHandler(this.sairbtn_Click);
            // 
            // novoCalculobtn
            // 
            this.novoCalculobtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.novoCalculobtn.Location = new System.Drawing.Point(128, 199);
            this.novoCalculobtn.Name = "novoCalculobtn";
            this.novoCalculobtn.Size = new System.Drawing.Size(140, 36);
            this.novoCalculobtn.TabIndex = 24;
            this.novoCalculobtn.Text = "Novo Cálculo";
            this.novoCalculobtn.UseVisualStyleBackColor = true;
            this.novoCalculobtn.Click += new System.EventHandler(this.novoCalculobtn_Click);
            // 
            // calcularbtn
            // 
            this.calcularbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcularbtn.Location = new System.Drawing.Point(12, 199);
            this.calcularbtn.Name = "calcularbtn";
            this.calcularbtn.Size = new System.Drawing.Size(110, 36);
            this.calcularbtn.TabIndex = 23;
            this.calcularbtn.Text = "Calcular";
            this.calcularbtn.UseVisualStyleBackColor = true;
            this.calcularbtn.Click += new System.EventHandler(this.calcularbtn_Click);
            // 
            // value2txt
            // 
            this.value2txt.Location = new System.Drawing.Point(12, 133);
            this.value2txt.Name = "value2txt";
            this.value2txt.Size = new System.Drawing.Size(193, 27);
            this.value2txt.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Inserir o Primeiro Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Menu De Opções";
            // 
            // value1txt
            // 
            this.value1txt.Location = new System.Drawing.Point(12, 43);
            this.value1txt.Name = "value1txt";
            this.value1txt.Size = new System.Drawing.Size(193, 27);
            this.value1txt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Inserir o Primeiro Número";
            // 
            // somarcb
            // 
            this.somarcb.AutoSize = true;
            this.somarcb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.somarcb.Location = new System.Drawing.Point(284, 45);
            this.somarcb.Name = "somarcb";
            this.somarcb.Size = new System.Drawing.Size(76, 24);
            this.somarcb.TabIndex = 28;
            this.somarcb.Text = "Somar";
            this.somarcb.UseVisualStyleBackColor = true;
            // 
            // subtraircb
            // 
            this.subtraircb.AutoSize = true;
            this.subtraircb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subtraircb.Location = new System.Drawing.Point(284, 75);
            this.subtraircb.Name = "subtraircb";
            this.subtraircb.Size = new System.Drawing.Size(87, 24);
            this.subtraircb.TabIndex = 29;
            this.subtraircb.Text = "Subtrair";
            this.subtraircb.UseVisualStyleBackColor = true;
            // 
            // multiplicarcb
            // 
            this.multiplicarcb.AutoSize = true;
            this.multiplicarcb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiplicarcb.Location = new System.Drawing.Point(284, 105);
            this.multiplicarcb.Name = "multiplicarcb";
            this.multiplicarcb.Size = new System.Drawing.Size(106, 24);
            this.multiplicarcb.TabIndex = 30;
            this.multiplicarcb.Text = "Multiplicar";
            this.multiplicarcb.UseVisualStyleBackColor = true;
            // 
            // dividircb
            // 
            this.dividircb.AutoSize = true;
            this.dividircb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dividircb.Location = new System.Drawing.Point(284, 136);
            this.dividircb.Name = "dividircb";
            this.dividircb.Size = new System.Drawing.Size(77, 24);
            this.dividircb.TabIndex = 31;
            this.dividircb.Text = "Dividir";
            this.dividircb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 380);
            this.Controls.Add(this.dividircb);
            this.Controls.Add(this.multiplicarcb);
            this.Controls.Add(this.subtraircb);
            this.Controls.Add(this.somarcb);
            this.Controls.Add(this.resultadotxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sairbtn);
            this.Controls.Add(this.novoCalculobtn);
            this.Controls.Add(this.calcularbtn);
            this.Controls.Add(this.value2txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value1txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox resultadotxt;
        private Label label4;
        private Button sairbtn;
        private Button novoCalculobtn;
        private Button calcularbtn;
        private TextBox value2txt;
        private Label label3;
        private Label label2;
        private TextBox value1txt;
        private Label label1;
        private CheckBox somarcb;
        private CheckBox subtraircb;
        private CheckBox multiplicarcb;
        private CheckBox dividircb;
    }
}