using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class Program
    {
        static void Main(string[] args)
        {
            LIST_ANG Angajati = new LIST_ANG();
            Angajati.Load();

            foreach (string s in Angajati.View())
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
            Angajati.Sort();
            foreach (string s in Angajati.View())
            {
                Console.WriteLine(s.ToString());
            }

            Angajati.Save();
        }
    }
}
