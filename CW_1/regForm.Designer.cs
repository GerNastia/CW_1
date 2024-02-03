namespace CW_1
{
    partial class regForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            regEnter = new Button();
            label2 = new Label();
            label1 = new Label();
            regPwd2 = new TextBox();
            regLog = new TextBox();
            label3 = new Label();
            regPwd1 = new TextBox();
            SuspendLayout();
            // 
            // regEnter
            // 
            regEnter.Location = new Point(49, 257);
            regEnter.Name = "regEnter";
            regEnter.Size = new Size(183, 29);
            regEnter.TabIndex = 10;
            regEnter.Text = "Зарегистрироваться";
            regEnter.UseVisualStyleBackColor = true;
            regEnter.Click += regEnter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 109);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 9;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 29);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 8;
            label1.Text = "Логин";
            // 
            // regPwd2
            // 
            regPwd2.Location = new Point(49, 210);
            regPwd2.Name = "regPwd2";
            regPwd2.Size = new Size(677, 27);
            regPwd2.TabIndex = 7;
            // 
            // regLog
            // 
            regLog.Location = new Point(49, 60);
            regLog.Name = "regLog";
            regLog.Size = new Size(677, 27);
            regLog.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 179);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 12;
            label3.Text = "Повторить пароль";
            // 
            // regPwd1
            // 
            regPwd1.Location = new Point(49, 142);
            regPwd1.Name = "regPwd1";
            regPwd1.Size = new Size(677, 27);
            regPwd1.TabIndex = 11;
            // 
            // regForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 320);
            Controls.Add(label3);
            Controls.Add(regPwd1);
            Controls.Add(regEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(regPwd2);
            Controls.Add(regLog);
            Name = "regForm";
            Text = "Регистрация";
            Load += regForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regEnter;
        private Label label2;
        private Label label1;
        private TextBox regPwd2;
        private TextBox regLog;
        private Label label3;
        private TextBox regPwd1;
    }
}