using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace redTaller.Vista.VistaUtil
{
    public static class VistaUtil
    {

        static public void MsgInfo(string msg, string caption)
        {
            MessageBox.Show(msg, caption);
        }

        static public Boolean ValidaNIF( string nif )
        {

            string dniPattern = @"^[0-9]{8}[A-Za-z]$"; // PERSONA FISICA
            string cifPattern = @"^[A-Za-z]{1}[0-9]{7}[A-Za-z0-9]{1}$"; // EMPRESAS
            string niePattern = @"^[XYZ][0-9]{7}[A-Z]$"; // EXTRANJEROS

            if ( !( Regex.IsMatch(nif, dniPattern) && ValidaLetraDNI(nif) ) && !( Regex.IsMatch(nif, cifPattern) ) && !( Regex.IsMatch(nif, niePattern) ) )
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static private Boolean ValidaLetraDNI( string dni )
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            int numero = int.Parse(dni.Substring(0, 8));
            char letraEsperada = letras[numero % 23];
            char letraActual = char.ToUpper(dni[8]);
            return letraEsperada == letraActual;
        }

    }
}
