using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class COMP: IComparer<ANGAJAT>
    {
        public int Compare(ANGAJAT a, ANGAJAT b)
        {
            return a.nume.CompareTo(b.nume);
        }
    }
}
