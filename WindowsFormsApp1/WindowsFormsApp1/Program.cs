using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       
        public int Ravnst(int a, int b, int c, int Rvnst)
        {

            if ((a == b) && (a == c) && (b == c))
            {
                Rvnst = 1;
            }
            else 
            { 
                Rvnst = 0;
            }
            return (Rvnst);
        }
        public int Ravnobed(int a, int b, int c, int Ravnob)
        {

            if((a == b) || (a == c) || (b == c))
            {
                Ravnob = 1;
            }
            else
            {
                Ravnob = 0;
            }
            return (Ravnob);
        }
        public int Raznost(int a, int b, int c, int Raznst)
        {

            if ((a != b) && (b != c) && (a != c))
            {
                Raznst = 1;
            }
            else
            {
                Raznst = 0;
            }
            return (Raznst);
        }

    }
}
