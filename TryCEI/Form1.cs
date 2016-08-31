using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TryCEI
{
    public partial class formLog : Form
    {
        public formLog()
        {
            InitializeComponent();
        }

        formMenu frmMenu= new formMenu();
        //formLog frmLog = new formLog();

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "test" && txtPass.Text == "123")
            {
                frmMenu.Show();
                this.Hide();
            }

            else
                lblWarning.Visible = true;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\r' && txtUser.Text == "test" && txtPass.Text == "123")
            {
                frmMenu.Show();
                this.Hide();

            }

            else if (e.KeyChar== '\r')
                lblWarning.Visible = true;
        }
    }
}
