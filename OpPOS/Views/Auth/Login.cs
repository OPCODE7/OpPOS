﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views.Auth
{
    public partial class Login : Form
    {

        Helpers.Helper help = new Helpers.Helper();
        string userName, password;
        Controllers.UserController userController = new Controllers.UserController();
        Dashboard dashboard = new Dashboard();


        public Login()
        {
            InitializeComponent();
        }

        //Comandos de libreria para poder mover el formulario en tiempo de ejecucion 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


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
            TxtPwd.UseSystemPasswordChar = false;
            PbxVisible.Visible = false;
            PbxHidden.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TxtUserName.Focus();

        }

        public void SetValues()
        {
            userName = TxtUserName.Text.Trim();
            password = TxtPwd.Text.Trim();
        }

        private void TxtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SetValues();
            bool result = userController.Login(userName, password);
            if (result)
            {
                Login login = new Login();
                login.Close();
                dashboard.ShowDialog();
            }
            else
            {
                TxtUserName.Focus();
                help.MsgWarning("Usuario y/o contraseña incorrectos.");
            }

        }
    }
}
