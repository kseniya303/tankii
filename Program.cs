using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            Tank[] p = new Tank[3];
            Tank[] t = new Tank[3];
            for(int i =0; i < p.Length; i++)
            {
                p[i] = new Tank();
            }
            for (int i = 0; i < p.Length; i++)
            {
                t[i] = new Tank(rnd.Next(5, 10), rnd.Next(80, 110), rnd.Next(1, 100), rnd.Next(1, 10), rnd.Next(1, 10), "T34");
            }
            Tank[] pantera = new Tank[3];
            for (int i = 0; i < p.Length; i++)
            {
                pantera[i] = new Tank(rnd.Next(5, 10), rnd.Next(80, 110), rnd.Next(1, 100), rnd.Next(1, 10), rnd.Next(1, 10), "pantera");
            }

           for (int i = 0; i < 3; i++)
            {
                //Console.WriteLine("До боя:");
                //t[i].Print();
                //pantera[i].Print();
                //Console.WriteLine("ПослЕ боя:");
                //t[i].Print();
                //pantera[i].Print();
                Tank.Winner(t[i], pantera[i]);
                p[i] = t[i] * pantera[i];
                Console.WriteLine("Победил:");
                p[i].Print();
                if (p[i] == p[2])
                {
                    if (p[0].Name == p[1].Name || p[0].Name == p[2].Name)
                    {
                        Console.WriteLine("Победила армия " + p[0].Name);
                    }
                    else
                        Console.WriteLine("Победила армия " + p[1].Name);
                }
                Console.WriteLine();
            }  

        }
    }
}
