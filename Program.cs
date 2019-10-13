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

                Console.WriteLine("До боя:");
                t[i].Print();
                pantera[i].Print();
                Tank.Winner(t[i], pantera[i]);
                Console.WriteLine("Послк боя:");
                t[i].Print();
                pantera[i].Print();
                p[i] = t[i] * pantera[i];
                Console.WriteLine("Победил:");
                p[i].Print();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }

            //var t34List = new List<Tank>();
            //var panteraList = new List<Tank>();

                //for(int i = 0; i<3; i++)
                //{
                //    t34List.Add(new Tank("t34: "+i));
                //    panteraList.Add(new Tank("pantera: " + i)); 
                //}


                //var armiT34 = new Armia(t34List, new TankEnumerator(t34List) );
                //var armiPantera = new Armia(panteraList, new TankEnumerator2(panteraList));
                //Console.WriteLine("Бой:");
                //foreach (var tankT34 in armiT34)
                //{
                //    foreach(var tankPantera in armiPantera)
                //    {  
                //        Tank.Winner(tankT34, tankPantera);
                //    }
                //}
        }
    }
}
