using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Modelo
{

    public class Config
    {
        public string EmailCuenta { get; set; }
        public string EmailUser { get; set; }
        public string EmailPassword { get; set; }
        public string EmailSmtpServer { get; set; }
        public int EmailSmtpPort { get; set; }

        public string MasterPassword { get; set; }

        public Config() { }

    }

}
