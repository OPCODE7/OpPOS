using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using OpPOS.Models;
using OpPOS.Helpers;

namespace OpPOS.Config
{
    internal class Boot
    {
        private Helpers.Helper h;
        private Controllers.SystemLicenseController slc;
        private AccessDBManagment adm;
        private SystemLicense sl;
        private Hasher hasher;

        public Boot()
        {
            h = new Helpers.Helper();
            slc = new Controllers.SystemLicenseController();
            adm = new AccessDBManagment();
            sl = new SystemLicense();
            hasher = new Hasher();

        }
        /// <summary>
        /// Configura dinámicamente las cadenas de conexión para Entity Framework y ADO.NET 
        /// en el archivo de configuración de la aplicación, utilizando los valores actuales del entorno (<see cref="Env"/>).
        /// </summary>
        public void setEfConnection()
        {
            string efConnectionString = $@"metadata=res://*/Models.DataBase.csdl|res://*/Models.DataBase.ssdl|res://*/Models.DataBase.msl;provider=System.Data.SqlClient;provider connection string='data source={Env.SERVER};initial catalog={Env.DBNAME};user id={Env.USERDB};password={Env.PWD};trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework'";

            string sqlConnectionString = $@"Data Source={Env.SERVER};Initial Catalog={Env.DBNAME};Persist Security Info=True;User ID={Env.USERDB};Password={Env.PWD};Encrypt=True;TrustServerCertificate=True";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connStrings = config.ConnectionStrings.ConnectionStrings;

            // OpPOSEntities (Entity Framework)
            if (connStrings["OpPOSEntities"] != null)
            {
                connStrings["OpPOSEntities"].ConnectionString = efConnectionString;
            }
            else
            {
                connStrings.Add(new ConnectionStringSettings("OpPOSEntities", efConnectionString, "System.Data.EntityClient"));
            }

            // PARKINGConnectionString (por si se necesita)
            if (connStrings["parking.Properties.Settings.OpPOSConnectionString"] != null)
            {
                connStrings["parking.Properties.Settings.OpPOSConnectionString"].ConnectionString = sqlConnectionString;
            }
            else
            {
                connStrings.Add(new ConnectionStringSettings("parking.Properties.Settings.OpPOSConnectionString", sqlConnectionString, "System.Data.SqlClient"));
            }

            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        /// <summary>
        /// Inicializa la aplicación validando la licencia del sistema, leyendo la configuración del archivo de base de datos 
        /// y verificando la conexión al servidor SQL. En función del resultado, abre la pantalla de inicio de sesión o la configuración del servidor.
        /// </summary>
        public void initApp()
        {
            if (adm.ReadFileData())
            {
                string connectionString = $"Server={Env.SERVER};Database={Env.DBNAME};User Id={Env.USERDB};Password={Env.PWD};";

                if (!(h.TestConnection(connectionString)))
                {
                    h.MsgError(Helpers.App.Msg0022);
                    Application.Run(new Views.Administration.Configuration.FrmServerConfig());
                }
                else
                {
                    SYSTEM_LICENSE systemL = slc.GetSystemLicense();
                    string serialNumber = sl.GetMotherboardSerial();

                    if (serialNumber == null)
                    {
                        h.MsgError("ERROR INESPERADO NO SE PUDO INICIAR LA APLICACIÓN");
                        Application.Exit();
                        return;
                    }


                    if (systemL != null && !hasher.VerifyHash(serialNumber, systemL.MACHINE_SIGNATURE))
                    {
                        h.MsgError("ERROR INESPERADO NO SE PUDO INICIAR LA APLICACIÓN");
                        Application.Exit();
                        return;
                    }


                    if (systemL == null)
                    {
                        SYSTEM_LICENSE newSL = new SYSTEM_LICENSE
                        {
                            MACHINE_SIGNATURE = hasher.MakeHash(serialNumber),
                            INSERTED_AT = DateTime.Now
                        };

                        if (slc.SaveSystemLicense(newSL) == 0)
                        {
                            Application.Exit();
                            return;
                        }

                    }

                    Application.Run(new Views.Auth.Login());
                }
            }
            else
            {
                Application.Run(new Views.Administration.Configuration.FrmServerConfig());
            }
        }
    }
}
