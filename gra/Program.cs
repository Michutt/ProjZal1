using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string[] kolory = { "RED", "BLUE", "GREEN", "YELLOW", "BLACK", "PURPLE", "PINK", "BROWN" };
            string[] alfabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "W", "Z" };
            string kolor = "xd";
            int flaga = 0;
            int punkty = 0;
            int[] vels = new int[10];
            int[] dirs = new int[10];
            Application.Run(new Form1(kolory, alfabet, kolor, flaga, vels, dirs, punkty));
        }
    }
}
