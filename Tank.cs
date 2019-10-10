using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanki
{
    public class Tank
    {
        public int loss; //урон
        public int health;//Уровень брони
        public int Mob;//маневренность
        public int camouflage; //Маскировка
        public int experience; // опыт
         public string Name { get; set; }
        
        public Tank(int loss, int health, int Mob, int camouflage, int experience, string Name)
        {
            this.loss = loss;
            this.health = health;
            this.Mob = Mob;
            this.camouflage = camouflage;
            this.experience = experience;
            this.Name = Name;
        }
        public Tank()
        {
            loss =  0;
            health = 0;
            Mob = 0;
            camouflage = 0;
            experience = 0;
            Name = null;
        }
        
        public Tank(string name)
        {
            Name = name;
        }
        private static Random rnd = new Random();
        public bool IsDead { get; set; } //поумолчанию false
        public void Print()
        {
            Console.WriteLine("Имя: " + Name);
            Console.WriteLine("Урон = " + loss + " Уровень брони = " + health + " Маневренность = " + Mob + " Маскировка " + camouflage + " Опыт " + experience +"\n");
        }
        public static Tank  Winner(Tank tank1, Tank tank2)
        {
            var sum_par_t1 = tank1.Mob + tank1.camouflage + tank1.experience;
            var sum_par_t2 = tank2.Mob + tank2.camouflage + tank2.experience;
            
            if (sum_par_t1 > sum_par_t2)
            {
                tank2.health -= tank1.loss;
                tank1.health -= tank2.loss / 2;
                tank1.experience++;
                tank2.experience++;
                tank2.camouflage++;
                tank1.Print();
                tank2.Print();
                return tank1;
           }
            else
            {
                tank1.health -= tank2.loss;
                tank2.health -= tank1.loss / 2;
                tank2.experience++;
                tank1.experience++;
                tank1.camouflage++;
                tank2.Print();
                tank1.Print();
                return tank2;
            } 
        }
        public static Tank operator *(Tank T34, Tank pantera)
        {
            if (T34.loss > pantera.loss && T34.health > pantera.health)
            {
                return T34;
            }
            if (T34.loss > pantera.loss && T34.Mob > pantera.Mob)
            {
                return T34;
            }
            if (T34.health > pantera.health && T34.Mob > pantera.Mob)
            {
                return T34;
            }
            else
            {
                return pantera;
            }
        }

    }
}
