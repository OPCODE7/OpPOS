using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views.Auth
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbxHidden_Click(object sender, EventArgs e)
        {
            TxtPwd.UseSystemPasswordChar = true;
            PbxHidden.Visible = false;
            PbxVisible.Visible = true;
        }

        private void PbxVisible_Click(object sender, EventArgs e)
        {
            xtPwd.UseSystemPasswordChar = false;
            PbxVisible.Visible = false;
            PbxHidden.Visible = true;
        }
    }
}
