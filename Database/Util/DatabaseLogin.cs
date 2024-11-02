using redTaller.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Database.Util
{
    internal class DatabaseLogin : GeneralDB
    {

        public string username { get; set; }
        public string password { get; set; }

        public DatabaseLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public bool checkLogin()
        {

            bool accesso = false;

            if( username == "master" )
            {
                ConfigDB configDB = new ConfigDB();
                Config config = configDB.Carga();
                if (password.Equals( config.MasterPassword ) )
                {
                    accesso = true;
                }

            }

            /// falta la verificación de usuario

            return accesso;

        }

    }

}