using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Prj.Decoration_View
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox txtUsername = new TextBox();
            TextBox txtPassword = new TextBox();
            Button btnLogin = new Button();
            Button btnRegister = new Button();
            Panel panel1 = new Panel();
            this.Controls.Add(panel1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
        }
        

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
