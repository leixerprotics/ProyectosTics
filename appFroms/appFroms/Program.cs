using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace appFroms
{


    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string nombre = "Leixer";
            int edad = 30;
            uint telefono = 1234567890;
            float altura = 1.75f;
            double peso = 70.5;
            decimal nota = 9.5m;

            bool acceso = true;
            DateTime fecha = DateTime.Now;


            //int numero = 12;
            //int numero1 = 12;
            //int numero3= 12;
            //int numero2 = 12;
            //int numero4 = 12;


            int num7, num9, num8, num10, num11;
            num7 = 12;num8 = 12; num9 = 12; num10 = 12; num11 = 12;

            const string dato = "Leixer";
            //dato  = "stteven";



            MessageBox.Show(fecha.Month.ToString());

            //MessageBox.Show($"{nombre}, edad : {edad}");
            //MessageBox.Show(peso.ToString());
            //MessageBox.Show(acceso.ToString());
             
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
