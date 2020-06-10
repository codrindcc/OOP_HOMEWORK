using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFORMA_2D
{
    class PATRAT: Interfata
    {
        public string Denumire => "PATRAT";

        public double l;
        public PATRAT(double l)
        {
            this.l = l;
        }

        public double Arie()
        {
            return Math.Pow(l, 2);
        }

        public double LungimeaFrontierei()
        {
            return 4 * l;
        }
    }
}
