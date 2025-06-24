using OpPOS.Helpers;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpPOS.Config
{
    internal class AccessDBManagment
    {
        Helper h= new Helper();
        string query;
        public static string path = @"C:\Program Files\SystemHidden\oppos.accdb";

        OleDbConnection connectionAccessDB = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Jet OLEDB:Database Password=opcode_7;");
        OleDbDataReader reader;
        OleDbCommand command;

        /// <summary>
        /// Lee los datos de configuración del archivo Access especificado y asigna los valores al entorno de conexión.
        /// </summary>
        public bool ReadFileData()
        {
            bool exist = h.CheckFileExist(path);
            bool containsData = false;

            if (!exist)
            {
                h.MsgError("ERROR FATAL: EL ARCHIVO DE CONFIGURACION NO EXISTE!");
                Application.Exit();
            }

            try
            {
                command = new OleDbCommand("SELECT * FROM SERVER_POS", connectionAccessDB);

                connectionAccessDB.Open();

                reader = command.ExecuteReader();

                if (!reader.Read())
                {
                    h.MsgWarning(Helpers.App.Msg0020);
                    containsData = false;
                }
                else
                {
                    containsData = true;
                    Env.SERVER = reader["SERVER"].ToString();
                    Env.DBNAME = reader["DBNAME"].ToString();
                    Env.USERDB = reader["USERNAME"].ToString();
                    Env.PWD = reader["PWD"].ToString();
                }

                reader.Close();
                command.Dispose();
                connectionAccessDB.Close();

            }
            catch (OleDbException error)
            {
                h.MsgError("ERROR INESPERADO: " + error.ToString().ToUpper());
            }

            return containsData;
        }



        /// <summary>
        /// Inserta un nuevo registro en la tabla especificada de la base de datos Access usando los campos y valores proporcionados.
        /// </summary>
        /// <param name="table">Nombre de la tabla en la que se insertarán los datos.</param>
        /// <param name="fields">Cadena con los nombres de los campos separados por comas.</param>
        /// <param name="values">Cadena con los valores correspondientes a insertar, en el mismo orden que los campos.</param>
        /// <returns>
        /// Devuelve el número de filas afectadas por la operación <c>INSERT</c>. 
        /// Si ocurre un error, se muestra un mensaje y se devuelve <c>0</c>.
        /// </returns>
        public int SaveConfigurationData(string table, string fields, string values)
        {

            int ra = 0;
            try
            {

                query = "INSERT INTO " + table + "(" + fields + ") VALUES(" + values + ")";
                command = new OleDbCommand(query, connectionAccessDB);
                connectionAccessDB.Open();
                ra = command.ExecuteNonQuery();

                command.Dispose();
                connectionAccessDB.Close();

            }
            catch (OleDbException error)
            {
                h.MsgError("ERROR INESPERADO: " + error.Message.ToUpper());
            }

            return ra;
        }

        /// <summary>
        /// Actualiza los datos de conexión en la tabla especificada de la base de datos Access.
        /// </summary>
        /// <param name="table">Nombre de la tabla a actualizar.</param>
        /// <param name="server">Nombre del servidor de base de datos.</param>
        /// <param name="dbname">Nombre de la base de datos.</param>
        /// <param name="user">Nombre de usuario para la conexión.</param>
        /// <param name="pwd">Contraseña del usuario para la conexión.</param>
        /// <returns>
        /// Número de filas afectadas por la operación <c>UPDATE</c>. Si ocurre un error, devuelve <c>0</c>.
        /// </returns>
        public int UpdateConfigurationData(string table, string server, string dbname, string user, string pwd)
        {

            int ra = 0;
            try
            {

                query = $"UPDATE {table} SET SERVER='{server}',DBNAME= '{dbname}',USERNAME='{user}',PWD='{pwd}'";
                command = new OleDbCommand(query, connectionAccessDB);
                connectionAccessDB.Open();
                ra = command.ExecuteNonQuery();

                command.Dispose();
                connectionAccessDB.Close();

            }
            catch (OleDbException error)
            {
                h.MsgError("ERROR INESPERADO: " + error.Message.ToUpper());
            }

            return ra;
        }

    }
}
