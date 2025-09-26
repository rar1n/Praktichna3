namespace praktichna3_3_
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
            btnOpl = new Button();
            groupBox2 = new GroupBox();
            tbCN = new TextBox();
            lCN = new Label();
            tbBNa = new TextBox();
            lBNa = new Label();
            tbBNo = new TextBox();
            lBNo = new Label();
            tbCardC = new TextBox();
            tbCardN = new TextBox();
            lCardC = new Label();
            lCardN = new Label();
            cbOpl = new ComboBox();
            tbAm = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOpl);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbOpl);
            groupBox1.Controls.Add(tbAm);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(387, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnOpl
            // 
            btnOpl.Location = new Point(96, 268);
            btnOpl.Name = "btnOpl";
            btnOpl.Size = new Size(183, 40);
            btnOpl.TabIndex = 5;
            btnOpl.Text = "Оплатити";
            btnOpl.UseVisualStyleBackColor = true;
            btnOpl.Click += btnOpl_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbCN);
            groupBox2.Controls.Add(lCN);
            groupBox2.Controls.Add(tbBNa);
            groupBox2.Controls.Add(lBNa);
            groupBox2.Controls.Add(tbBNo);
            groupBox2.Controls.Add(lBNo);
            groupBox2.Controls.Add(tbCardC);
            groupBox2.Controls.Add(tbCardN);
            groupBox2.Controls.Add(lCardC);
            groupBox2.Controls.Add(lCardN);
            groupBox2.Location = new Point(7, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 142);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // tbCN
            // 
            tbCN.Location = new Point(6, 67);
            tbCN.Name = "tbCN";
            tbCN.Size = new Size(361, 29);
            tbCN.TabIndex = 9;
            tbCN.Visible = false;
            // 
            // lCN
            // 
            lCN.AutoSize = true;
            lCN.Location = new Point(6, 43);
            lCN.Name = "lCN";
            lCN.Size = new Size(257, 21);
            lCN.TabIndex = 8;
            lCN.Text = "Номер криптовалютного гаманця:";
            lCN.Visible = false;
            // 
            // tbBNa
            // 
            tbBNa.Location = new Point(141, 83);
            tbBNa.Name = "tbBNa";
            tbBNa.Size = new Size(226, 29);
            tbBNa.TabIndex = 7;
            tbBNa.Visible = false;
            // 
            // lBNa
            // 
            lBNa.AutoSize = true;
            lBNa.Location = new Point(34, 86);
            lBNa.Name = "lBNa";
            lBNa.Size = new Size(101, 21);
            lBNa.TabIndex = 6;
            lBNa.Text = "Назва банку:";
            lBNa.Visible = false;
            // 
            // tbBNo
            // 
            tbBNo.Location = new Point(141, 40);
            tbBNo.Name = "tbBNo";
            tbBNo.Size = new Size(226, 29);
            tbBNo.TabIndex = 5;
            tbBNo.Visible = false;
            // 
            // lBNo
            // 
            lBNo.AutoSize = true;
            lBNo.Location = new Point(6, 43);
            lBNo.Name = "lBNo";
            lBNo.Size = new Size(129, 21);
            lBNo.TabIndex = 4;
            lBNo.Text = "Номер аккаунта:";
            lBNo.Visible = false;
            // 
            // tbCardC
            // 
            tbCardC.Location = new Point(118, 83);
            tbCardC.Name = "tbCardC";
            tbCardC.Size = new Size(108, 29);
            tbCardC.TabIndex = 3;
            tbCardC.Visible = false;
            // 
            // tbCardN
            // 
            tbCardN.Location = new Point(118, 40);
            tbCardN.Name = "tbCardN";
            tbCardN.Size = new Size(249, 29);
            tbCardN.TabIndex = 2;
            tbCardN.Visible = false;
            // 
            // lCardC
            // 
            lCardC.AutoSize = true;
            lCardC.Location = new Point(27, 86);
            lCardC.Name = "lCardC";
            lCardC.Size = new Size(85, 21);
            lCardC.TabIndex = 1;
            lCardC.Text = "Код карти:";
            lCardC.Visible = false;
            // 
            // lCardN
            // 
            lCardN.AutoSize = true;
            lCardN.Location = new Point(6, 43);
            lCardN.Name = "lCardN";
            lCardN.Size = new Size(106, 21);
            lCardN.TabIndex = 0;
            lCardN.Text = "Номер карти:";
            lCardN.Visible = false;
            // 
            // cbOpl
            // 
            cbOpl.FormattingEnabled = true;
            cbOpl.Location = new Point(157, 73);
            cbOpl.Name = "cbOpl";
            cbOpl.Size = new Size(223, 29);
            cbOpl.TabIndex = 3;
            cbOpl.SelectedIndexChanged += cbOpl_SelectedIndexChanged;
            // 
            // tbAm
            // 
            tbAm.Location = new Point(157, 26);
            tbAm.Name = "tbAm";
            tbAm.Size = new Size(137, 29);
            tbAm.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 76);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 1;
            label2.Text = "Спосіб оплати:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 29);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 0;
            label1.Text = "Сума:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 354);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Патерн Strategy / Оплата ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbCardC;
        private TextBox tbCardN;
        private Label lCardC;
        private Label lCardN;
        private ComboBox cbOpl;
        private TextBox tbAm;
        private Label label2;
        private Label label1;
        private TextBox tbBNa;
        private Label lBNa;
        private TextBox tbBNo;
        private Label lBNo;
        private TextBox tbCN;
        private Label lCN;
        private Button btnOpl;
    }
}
