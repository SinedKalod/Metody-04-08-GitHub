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
    }
}
