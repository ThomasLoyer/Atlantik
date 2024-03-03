using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formAjouterSecteur());
            //Application.Run(new formAjoutLiaison());
            //Application.Run(new formAjouterPort());
            //Application.Run(new formAjouterTarif());  //<---- Possiblement beaucoup de conneries 
            Application.Run(new formAjouterBateau());
        }
    }
}
