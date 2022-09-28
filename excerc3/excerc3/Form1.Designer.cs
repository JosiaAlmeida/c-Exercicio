namespace excerc3
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
            this.gerarbtn = new System.Windows.Forms.Button();
            this.value1Txt = new System.Windows.Forms.TextBox();
            this.resultlb = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.value31Txt = new System.Windows.Forms.TextBox();
            this.value32Txt = new System.Windows.Forms.TextBox();
            this.value33Txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gerarbtn
            // 
            this.gerarbtn.Location = new System.Drawing.Point(12, 120);
            this.gerarbtn.Name = "gerarbtn";
            this.gerarbtn.Size = new System.Drawing.Size(303, 29);
            this.gerarbtn.TabIndex = 0;
            this.gerarbtn.Text = "Gerar";
            this.gerarbtn.UseVisualStyleBackColor = true;
            this.gerarbtn.Click += new System.EventHandler(this.gerarbtn_Click);
            // 
            // value1Txt
            // 
            this.value1Txt.Location = new System.Drawing.Point(216, 12);
            this.value1Txt.Name = "value1Txt";
            this.value1Txt.Size = new System.Drawing.Size(99, 27);
            this.value1Txt.TabIndex = 1;
            // 
            // resultlb
            // 
            this.resultlb.FormattingEnabled = true;
            this.resultlb.ItemHeight = 20;
            this.resultlb.Location = new System.Drawing.Point(12, 202);
            this.resultlb.Name = "resultlb";
            this.resultlb.Size = new System.Drawing.Size(303, 224);
            this.resultlb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite 1 numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Digite 3 numero";
            // 
            // value31Txt
            // 
            this.value31Txt.Location = new System.Drawing.Point(135, 60);
            this.value31Txt.Name = "value31Txt";
            this.value31Txt.Size = new System.Drawing.Size(53, 27);
            this.value31Txt.TabIndex = 4;
            // 
            // value32Txt
            // 
            this.value32Txt.Location = new System.Drawing.Point(203, 60);
            this.value32Txt.Name = "value32Txt";
            this.value32Txt.Size = new System.Drawing.Size(53, 27);
            this.value32Txt.TabIndex = 6;
            // 
            // value33Txt
            // 
            this.value33Txt.Location = new System.Drawing.Point(262, 60);
            this.value33Txt.Name = "value33Txt";
            this.value33Txt.Size = new System.Drawing.Size(53, 27);
            this.value33Txt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.value33Txt);
            this.Controls.Add(this.value32Txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value31Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultlb);
            this.Controls.Add(this.value1Txt);
            this.Controls.Add(this.gerarbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button gerarbtn;
        private TextBox value1Txt;
        private ListBox resultlb;
        private Label label1;
        private Label label2;
        private TextBox value31Txt;
        private TextBox value32Txt;
        private TextBox value33Txt;
    }
}