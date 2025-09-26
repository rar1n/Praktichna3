namespace praktichna3_2_
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
            groupBox1 = new GroupBox();
            cbT = new ComboBox();
            cbF = new ComboBox();
            tbR = new TextBox();
            label4 = new Label();
            btnC = new Button();
            label3 = new Label();
            label2 = new Label();
            tbS = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbT);
            groupBox1.Controls.Add(cbF);
            groupBox1.Controls.Add(tbR);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbS);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 272);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cbT
            // 
            cbT.FormattingEnabled = true;
            cbT.Items.AddRange(new object[] { "UAH", "USD", "EUR" });
            cbT.Location = new Point(190, 114);
            cbT.Name = "cbT";
            cbT.Size = new Size(121, 29);
            cbT.TabIndex = 8;
            // 
            // cbF
            // 
            cbF.FormattingEnabled = true;
            cbF.Items.AddRange(new object[] { "UAH", "USD", "EUR" });
            cbF.Location = new Point(190, 69);
            cbF.Name = "cbF";
            cbF.Size = new Size(121, 29);
            cbF.TabIndex = 7;
            // 
            // tbR
            // 
            tbR.Location = new Point(109, 223);
            tbR.Name = "tbR";
            tbR.Size = new Size(221, 29);
            tbR.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 226);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 5;
            label4.Text = "Результат:";
            // 
            // btnC
            // 
            btnC.Location = new Point(19, 160);
            btnC.Name = "btnC";
            btnC.Size = new Size(311, 33);
            btnC.TabIndex = 4;
            btnC.Text = "Конвертувати";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 117);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 3;
            label3.Text = "Конвертувати в:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 72);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 2;
            label2.Text = "Конвертувати з:";
            // 
            // tbS
            // 
            tbS.Location = new Point(190, 22);
            tbS.Name = "tbS";
            tbS.Size = new Size(121, 29);
            tbS.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 0;
            label1.Text = "Сума:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 304);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Патерн Adapter / Конвертер валют";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnC;
        private Label label3;
        private Label label2;
        private TextBox tbS;
        private Label label1;
        private ComboBox cbT;
        private ComboBox cbF;
        private TextBox tbR;
        private Label label4;
    }
}
