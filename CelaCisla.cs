﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody_04_08_GitHub
{
    class CelaCisla
    {
        public static string Mocnina(int x, int y)
        {
            int vypocet = 1;
            string vysledek = vypocet.ToString();
            if (y != 0)
            {
                if (y < 0)
                {
                    y = -y;
                    for (int i = 1; i <= y; ++i)
                    {
                        vypocet *= x;
                    }
                    vysledek = "1/" + vypocet;
                }
                else
                {
                    for (int i = 1; i <= y; ++i)
                    {
                        vypocet *= x;
                    }
                    vysledek = vypocet.ToString();
                }
            }
            return vysledek;
        }

        public static int faktorial(int x)
        {
            int faktorial = 1;
            if (x < 0) throw new ArgumentException("Faktoriál nelze spočítat pokud je záporný.");
            else
            {
                for (int i = 1; i <= x; ++i)
                {
                    faktorial *= i;
                }
                return faktorial;
            }
        }

        public static int CifLichSoucet(int x)
        {
            int CifLichSoucet = 0;
            while (x > 0)
            {
                int cifra = x % 10;
                if (cifra % 2 != 0)
                {
                    CifLichSoucet += cifra;
                }

                x = x / 10;
            }

            return CifLichSoucet;
        }

        public static bool JePrvocislo(int x)
        {
            bool jePrvocislo = x != 1;
            for (int delitel = 2; delitel <= Math.Sqrt(x) && jePrvocislo; ++delitel)
            {
                if (x % delitel == 0) jePrvocislo = false;
            }

            return jePrvocislo;
        }
    }
}
