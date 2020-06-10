using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFORMA_2D
{
    class CERC: Interfata
    {
        public string Denumire => "CERC";

        public double raza;
       
        public CERC(double raza)
        {
            this.raza = raza;
        }
        public double Arie()
        {
            return Math.PI * Math.Pow(raza, 2);
        }

        public double LungimeaFrontierei()
        {
            return (2 * Math.PI) * raza;
        }
    }
}
