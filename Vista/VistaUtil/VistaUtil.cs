using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
