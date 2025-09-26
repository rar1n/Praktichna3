namespace praktichna3_1_
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
            tbR = new TextBox();
            label2 = new Label();
            btnB = new Button();
            label1 = new Label();
            cbC = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbR);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnB);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbC);
            groupBox1.Location = new Point(15, 17);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(334, 342);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // tbR
            // 
            tbR.Location = new Point(8, 158);
            tbR.Margin = new Padding(4);
            tbR.Multiline = true;
            tbR.Name = "tbR";
            tbR.Size = new Size(318, 166);
            tbR.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "Результат:";
            // 
            // btnB
            // 
            btnB.Location = new Point(8, 76);
            btnB.Margin = new Padding(4);
            btnB.Name = "btnB";
            btnB.Size = new Size(318, 32);
            btnB.TabIndex = 2;
            btnB.Text = "Зібрати";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 1;
            label1.Text = "Тип комп'ютера:";
            // 
            // cbC
            // 
            cbC.FormattingEnabled = true;
            cbC.Items.AddRange(new object[] { "Ігровий комп'ютер", "Офісний комп'ютер" });
            cbC.Location = new Point(143, 22);
            cbC.Margin = new Padding(4);
            cbC.Name = "cbC";
            cbC.Size = new Size(183, 29);
            cbC.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 372);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Патерн Builder / Конфігуратор комп'ютера";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cbC;
        private TextBox tbR;
        private Label label2;
        private Button btnB;
    }
}
