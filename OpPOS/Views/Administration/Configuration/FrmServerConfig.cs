using OpPOS.Config;
using OpPOS.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Views.Administration.Configuration
{
    public partial class FrmServerConfig : Form
    {
        Boot boot = new Boot();
        string server, dbname, user, pwd, moduleId = "CFG";
        Helpers.Helper h = new Helpers.Helper();
        bool flagContainsData = false;
        AccessDBManagment adm= new AccessDBManagment();
        LogBookAppController lac = new LogBookAppController();

        public FrmServerConfig()
        {
            InitializeComponent();
        }

        private void setValues()
        {
            server = TxtServerName.Text.Trim();
            dbname = TxtDbName.Text.Trim();
            user = TxtUserDb.Text.Trim();
            pwd = TxtPwd.Text.Trim();

        }

        private void FrmServerConfig_Load(object sender, EventArgs e)
        {
            if (Env.containsData())
            {
                flagContainsData = true;
                TxtServerName.Text = Env.SERVER;
                TxtDbName.Text = Env.DBNAME;
                TxtUserDb.Text = Env.USERDB;
                TxtPwd.Text = Env.PWD;

            }
            else
            {
                flagContainsData = false;
            }
        }

        public int validateData()
        {
            int errors = 0;
            if (string.IsNullOrEmpty(TxtServerName.Text.Trim()))
            {
                h.MsgWarning("EL CAMPO NOMBRE DEL SERVIDOR NO PUEDE ESTAR VACIO!");
                errors++;
                TxtServerName.Focus();
                return errors;
            }

            if (string.IsNullOrEmpty(TxtDbName.Text.Trim()))
            {
                h.MsgWarning("EL CAMPO BASE DE DATOS NO PUEDE ESTAR VACIO!");
                errors++;
                TxtDbName.Focus();
                return errors;
            }

            if (string.IsNullOrEmpty(TxtUserDb.Text.Trim()))
            {
                h.MsgWarning("EL CAMPO NOMBRE DE USUARIO NO PUEDE ESTAR VACIO!");
                errors++;
                TxtUserDb.Focus();
                return errors;
            }

            if (string.IsNullOrEmpty(TxtPwd.Text.Trim()))
            {
                h.MsgWarning("EL CAMPO CONTRASEÑA NO PUEDE ESTAR VACIO!");
                errors++;
                TxtPwd.Focus();
                return errors;
            }

            Boot boot = new Boot();
            string connectionString = $"Server={TxtServerName.Text.Trim()};Database={TxtDbName.Text.Trim()};User Id={TxtUserDb.Text.Trim()};Password={TxtPwd.Text.Trim()};";
            if (h.TestConnection(connectionString) == false)
            {
                h.MsgError("NO SE PUEDE CONECTAR A LA BASE DE DATOS, VERIFIQUE LOS DATOS INGRESADOS!");
                errors++;
                TxtServerName.Focus();
                return errors;
            }


            return errors;



        }

        private void PbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                PbxLoading.Visible = true;
                BtnSave.Text = "";
                if (validateData() == 0)
                {
                    setValues();
                    string fields = "SERVER,DBNAME,USERNAME,PWD";
                    string values = $"'{server}','{dbname}','{user}','{pwd}'";
                    if (!flagContainsData)
                    {

                        if (adm.SaveConfigurationData("SERVER_POS", fields, values) > 0)
                        {
                            h.MsgSuccess("EXITO EL SEVIDOR ESTA CONFIGURADO!");
                            Application.Restart();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        string changes = "";
                        string separator = ", ";

                        if (Env.SERVER != server)
                            changes += $"SERVER: '{Env.SERVER}' → '{server}'{separator}";

                        if (Env.DBNAME != dbname)
                            changes += $"DBNAME: '{Env.DBNAME}' → '{dbname}'{separator}";
                        if (Env.USERDB != user)
                            changes += $"USERNAME: '[oculto]' → '[nuevo]'{separator}";
                        if (Env.PWD != pwd)
                            changes += $"PWD: '[oculto]' → '[nuevo]'{separator}";


                        // Limpiar coma final
                        if (!string.IsNullOrEmpty(changes))
                            changes = changes.TrimEnd(',', ' ');

                        if (adm.UpdateConfigurationData("SERVER_POS", server, dbname, user, pwd) > 0)
                        {
                            h.MsgSuccess("EXITO SE HAN ACTUALIZADO LOS DATOS DE CONFIGURACIÓN!");
                            if (!string.IsNullOrEmpty(changes) && User.userName != null)
                            {
                                string logDesc = $"El usuario {User.userName} modificó datos del servidor. Cambios: {changes}.";


                                await lac.saveLog(Config.User.userId, "Modificar", logDesc, moduleId, DateTime.Now);
                            }
                           

                            Application.Restart();

                        }
                    }
                }

                PbxLoading.Visible = false;
                BtnSave.Text = "Guardar";   
            }
            catch(Exception ex)
            {
                h.MsgError("ERROR INESPERADO: " + ex.ToString().ToUpper());
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
