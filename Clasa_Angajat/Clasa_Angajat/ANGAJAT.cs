﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class ANGAJAT
    {
        public string nume;
        public int ani;
        public int luni;

        public ANGAJAT(string data)
        {
            string[] local = data.Split(' ');
            nume = local[0] + " " + local[1];
            ani = int.Parse(local[2]);
            luni = int.Parse(local[3]);
        }
        public ANGAJAT(string nume, int ani, int luni)
        {
            this.nume = nume;
            this.ani = ani;
            this.luni = luni;
        }
        public override string ToString()
        {
            return nume + " " + ani + "ani " + luni + "luni ";
        }
    }
}
