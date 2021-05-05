using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectodeAula2021.Clases;

namespace ProyectodeAula2021
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            Lista lista = new Lista();
            //lista.Numero_Random();
            //lista.Inverso();
            lista.ImprimelistaInversa();
        }


    }
}
