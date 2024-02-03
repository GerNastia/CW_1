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
    public partial class regForm : Form
    {
        private DBworker dbworker;
        public regForm(DBworker dbworker)
        {
            InitializeComponent();
            this.dbworker = dbworker;
        }

        private void regForm_Load(object sender, EventArgs e)
        {

        }

        private void regEnter_Click(object sender, EventArgs e)
        {
            //DBworker dBworker = new DBworker("C:\\Users\\User\\source\\repos\\CW_1\\users.db");
            
            string login = regLog.Text;
            string pwd1 = regPwd1.Text;
            string pwd2 = regPwd2.Text;

            if (pwd1 != pwd2)
            {
                MessageBox.Show("Пароль не совпадают");
            }
            else
            {
                if (dbworker.AddNewUser(login, pwd1) == true)
                {
                    MessageBox.Show("Зарегестрирован");
                }
                else
                {
                    MessageBox.Show("Уже есть пользватель с таким логином");
                }
            }
        }
    }
}
