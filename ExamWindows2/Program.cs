using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExamWindows2
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Regex Reg = new Regex("[a-zA-Z]\\S{4,25}@[a-zA-Z]{1,10}.ca");
            Console.WriteLine(Reg.IsMatch("w.111.11@aaaaaa.ca"));
            Console.WriteLine(Reg.IsMatch("w11111@aaaaaa.ca"));
            Console.WriteLine(Reg.IsMatch("Aaaaaaa"));

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
