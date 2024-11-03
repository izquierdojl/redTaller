using redTaller.Modelo;
using redTaller.Util;

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

            if( username == "master" ) // usuario master
            {
                ConfigDB configDB = new ConfigDB();
                Config config = configDB.Carga();
                if (password.Equals( config.MasterPassword ) )
                {
                    accesso = true;
                    Session.Instance.Profile = "master";
                }

            }
            else // verificamos si el usuario está en un taller
            {
                TallerDB tallerDB = new TallerDB();
                if( tallerDB.checkLogin( username , password ) )
                {
                    accesso = true;
                    Session.Instance.Profile = "taller";
                }

            }

            return accesso;

        }

    }

}