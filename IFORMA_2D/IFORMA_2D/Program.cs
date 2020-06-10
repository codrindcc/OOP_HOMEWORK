using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFORMA_2D
{
    class Program
    {
        static void Main(string[] args)
        {
            PATRAT P = new PATRAT(7);
            Print(P);
            CERC C = new CERC(12);
            Print(C);
        }
        public static void Print (Interfata a)
        {
            Console.WriteLine($"Aria {a.Denumire} este: {a.Arie()}");
            Console.WriteLine($"Lungime frontiera {a.Denumire} este: {a.LungimeaFrontierei()}");
        }
    }
}
