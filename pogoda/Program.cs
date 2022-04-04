using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pogoda
{
    internal static class Program
    {
        const string API_KEY = "9152c2ba1c9b3c8546f73355913d6a47";
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Api api = new Api();

            Root weather = api.LoadData("Miami", API_KEY);

        }


    }
}
