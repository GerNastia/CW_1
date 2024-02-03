using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_1
{
    public partial class authForm : Form
    {
        private bool is_authed = false;
        private Form1 parent_form;
        private DBworker dbworker;

        public authForm(Form1 parent_form, DBworker dbworker)
        {
            InitializeComponent();
            this.parent_form = parent_form;
            this.dbworker = dbworker;
        }

        private void authForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!is_authed)
            {
                Application.Exit();
            }
        }

        private void authEnter_Click(object sender, EventArgs e)
        {
            //DBworker dBworker = new DBworker("C:\\Users\\User\\source\\repos\\CW_1\\users.db");

            if (dbworker.AuthUser(authLog.Text, authPwd.Text))
            {
                is_authed = true;
                parent_form.UserAuthed();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void authGoReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regForm reg = new regForm(dbworker);
            reg.ShowDialog();
        }
    }
}
