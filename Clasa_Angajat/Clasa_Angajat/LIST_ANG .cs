using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Angajat
{
    class LIST_ANG
    {
        ANGAJAT[] a;

        public LIST_ANG ()
        {
            a = new ANGAJAT[0];
        }
        public void Add(ANGAJAT add)
        {
            ANGAJAT[] t = new ANGAJAT[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                t[i] = a[i];
            }
            t[a.Length] = add;
            a = t;
        }

        public void Remove(string remove)
        {
            int idx = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].nume == remove)
                {
                    idx = i;
                    break;
                }
            }
            if (idx != -1)
            {
                ANGAJAT[] t = new ANGAJAT[a.Length - 1];
                for (int i = 0; i < idx; i++)
                {
                    t[i] = a[i];
                }
                for (int i = idx + 1; i < a.Length; i++)
                {
                    t[i - 1] = a[i];
                }
                a = t;
            }
        }

        public List<string> View()
        {
            List<string> toR = new List<string>();
            foreach (ANGAJAT angajat in a)
            {
                toR.Add(angajat.ToString());
            }
            return toR;
        }
        public void Load()
        {
            TextReader dL = new StreamReader(@"..\..\data.in");
            string buffer;
            while ((buffer = dL.ReadLine()) != null)
            {
                Add(new ANGAJAT(buffer));
            }
        }
        public void Save()
        {
            TextWriter dS = new StreamWriter(@"..\..\data.out");
            foreach (ANGAJAT ang in a)
            {
                dS.WriteLine(ang.ToString());
            }
            dS.Close();
        }
        public void Sort()
        {
            IComparer<ANGAJAT> T = new COMP();
            Array.Sort(a, T);
        }
    }
}
