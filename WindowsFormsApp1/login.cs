using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void commit_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "admin")
            {
                if (textPassword.Text == "123")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
            }
            else {
                MessageBox.Show("你输入的用户名或密码不正确", "错误");
            }
        }
    }
}
