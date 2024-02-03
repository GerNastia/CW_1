namespace CW_1
{
    partial class authForm
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
            authLog = new TextBox();
            authPwd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            authEnter = new Button();
            authGoReg = new LinkLabel();
            SuspendLayout();
            // 
            // authLog
            // 
            authLog.Location = new Point(76, 73);
            authLog.Name = "authLog";
            authLog.Size = new Size(677, 27);
            authLog.TabIndex = 0;
            // 
            // authPwd
            // 
            authPwd.Location = new Point(76, 153);
            authPwd.Name = "authPwd";
            authPwd.PasswordChar = '*';
            authPwd.Size = new Size(677, 27);
            authPwd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 122);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // authEnter
            // 
            authEnter.Location = new Point(76, 204);
            authEnter.Name = "authEnter";
            authEnter.Size = new Size(94, 29);
            authEnter.TabIndex = 4;
            authEnter.Text = "Войти";
            authEnter.UseVisualStyleBackColor = true;
            authEnter.Click += authEnter_Click;
            // 
            // authGoReg
            // 
            authGoReg.AutoSize = true;
            authGoReg.Location = new Point(201, 210);
            authGoReg.Name = "authGoReg";
            authGoReg.Size = new Size(151, 20);
            authGoReg.TabIndex = 5;
            authGoReg.TabStop = true;
            authGoReg.Text = "Зарегистрироваться";
            authGoReg.LinkClicked += authGoReg_LinkClicked;
            // 
            // authForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 278);
            Controls.Add(authGoReg);
            Controls.Add(authEnter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(authPwd);
            Controls.Add(authLog);
            Name = "authForm";
            Text = "Вход";
            FormClosed += authForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox authLog;
        private TextBox authPwd;
        private Label label1;
        private Label label2;
        private Button authEnter;
        private LinkLabel authGoReg;
    }
}