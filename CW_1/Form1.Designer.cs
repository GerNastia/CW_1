namespace CW_1
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
            MakEncrypt = new Button();
            Output = new Label();
            Input = new TextBox();
            MakeDeciph = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Key = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // MakEncrypt
            // 
            MakEncrypt.Location = new Point(436, 192);
            MakEncrypt.Name = "MakEncrypt";
            MakEncrypt.Size = new Size(135, 29);
            MakEncrypt.TabIndex = 0;
            MakEncrypt.Text = "Зашифровать\r\n";
            MakEncrypt.UseVisualStyleBackColor = true;
            MakEncrypt.Click += MakEncrypt_Click;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(59, 227);
            Output.Name = "Output";
            Output.Size = new Size(75, 20);
            Output.TabIndex = 1;
            Output.Text = "Результат";
            // 
            // Input
            // 
            Input.Location = new Point(59, 101);
            Input.Name = "Input";
            Input.Size = new Size(339, 27);
            Input.TabIndex = 2;
            // 
            // MakeDeciph
            // 
            MakeDeciph.Location = new Point(436, 227);
            MakeDeciph.Name = "MakeDeciph";
            MakeDeciph.Size = new Size(135, 29);
            MakeDeciph.TabIndex = 3;
            MakeDeciph.Text = "Расшифровать";
            MakeDeciph.UseVisualStyleBackColor = true;
            MakeDeciph.Click += MakeDeciph_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(182, 21);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 4;
            label1.Text = "Шифр Гронсфельда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 68);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 145);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Ключ";
            // 
            // Key
            // 
            Key.Location = new Point(59, 180);
            Key.Name = "Key";
            Key.Size = new Size(157, 27);
            Key.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "English", "Русский" });
            comboBox1.Location = new Point(436, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(441, 21);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 9;
            label4.Text = "Язык";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 291);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(Key);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MakeDeciph);
            Controls.Add(Input);
            Controls.Add(Output);
            Controls.Add(MakEncrypt);
            Name = "Form1";
            Text = "Шифр Гронсфельда";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MakEncrypt;
        private Label Output;
        private TextBox Input;
        private Button MakeDeciph;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Key;
        private ComboBox comboBox1;
        private Label label4;
    }
}