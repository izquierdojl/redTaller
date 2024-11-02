using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redTaller.Database.Util
{
    public class PasswordGenera
    {

        public static string RandomPassword(int length)
        {
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();

            while (0 < length--)
            {
                res.Append(validChars[rnd.Next(validChars.Length)]);
            }

            return res.ToString();
        }
    }

}
