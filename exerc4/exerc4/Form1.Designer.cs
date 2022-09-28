namespace exerc4
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
            this.calcbtn = new System.Windows.Forms.Button();
            this.novoCalcbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.atxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btxt = new System.Windows.Forms.TextBox();
            this.ctxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.deltatxt = new System.Windows.Forms.TextBox();
            this.x1txt = new System.Windows.Forms.TextBox();
            this.x2txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcbtn
            // 
            this.calcbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcbtn.Location = new System.Drawing.Point(490, 186);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(137, 38);
            this.calcbtn.TabIndex = 0;
            this.calcbtn.Text = "Calcular";
            this.calcbtn.UseVisualStyleBackColor = true;
            this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
            // 
            // novoCalcbtn
            // 
            this.novoCalcbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.novoCalcbtn.Location = new System.Drawing.Point(490, 230);
            this.novoCalcbtn.Name = "novoCalcbtn";
            this.novoCalcbtn.Size = new System.Drawing.Size(137, 38);
            this.novoCalcbtn.TabIndex = 1;
            this.novoCalcbtn.Text = "Novo Cálculo";
            this.novoCalcbtn.UseVisualStyleBackColor = true;
            this.novoCalcbtn.Click += new System.EventHandler(this.novoCalcbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitbtn.Location = new System.Drawing.Point(490, 274);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(137, 38);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Sair";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // atxt
            // 
            this.atxt.Location = new System.Drawing.Point(29, 50);
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(36, 27);
            this.atxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(71, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(175, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btxt
            // 
            this.btxt.Location = new System.Drawing.Point(133, 51);
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(36, 27);
            this.btxt.TabIndex = 6;
            this.btxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ctxt
            // 
            this.ctxt.Location = new System.Drawing.Point(232, 51);
            this.ctxt.Name = "ctxt";
            this.ctxt.Size = new System.Drawing.Size(36, 27);
            this.ctxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(107, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(206, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(286, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(312, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Delta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(35, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "X1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(35, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "X2";
            // 
            // deltatxt
            // 
            this.deltatxt.Location = new System.Drawing.Point(115, 149);
            this.deltatxt.Name = "deltatxt";
            this.deltatxt.Size = new System.Drawing.Size(111, 27);
            this.deltatxt.TabIndex = 16;
            // 
            // x1txt
            // 
            this.x1txt.Location = new System.Drawing.Point(115, 198);
            this.x1txt.Name = "x1txt";
            this.x1txt.Size = new System.Drawing.Size(111, 27);
            this.x1txt.TabIndex = 17;
            // 
            // x2txt
            // 
            this.x2txt.Location = new System.Drawing.Point(115, 236);
            this.x2txt.Name = "x2txt";
            this.x2txt.Size = new System.Drawing.Size(111, 27);
            this.x2txt.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 324);
            this.Controls.Add(this.x2txt);
            this.Controls.Add(this.x1txt);
            this.Controls.Add(this.deltatxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atxt);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.novoCalcbtn);
            this.Controls.Add(this.calcbtn);
            this.Name = "Form1";
            this.Text = "q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calcbtn;
        private Button novoCalcbtn;
        private Button exitbtn;
        private TextBox atxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox btxt;
        private TextBox ctxt;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox deltatxt;
        private TextBox x1txt;
        private TextBox x2txt;
    }
}