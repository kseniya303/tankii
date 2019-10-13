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
    
        public static Tank operator *(Tank tank1, Tank tank2)
        {
            if (tank1.loss > tank2.loss && tank1.health > tank2.health)
            {
                tank2.health -= tank1.loss;
                tank1.health -= tank2.loss / 2;
                tank1.experience++;
                tank2.experience++;
                tank2.camouflage++;
                return tank1;
            }
            if (tank1.loss > tank2.loss && tank1.Mob > tank2.Mob)
            {
                tank2.health -= tank1.loss;
                tank1.health -= tank2.loss / 2;
                tank1.experience++;
                tank2.experience++;
                tank2.camouflage++;
                return tank1;
            }
            if (tank1.health > tank2.health && tank1.Mob > tank2.Mob)
            {
                tank2.health -= tank1.loss;
                tank1.health -= tank2.loss / 2;
                tank1.experience++;
                tank2.experience++;
                tank2.camouflage++;
                return tank1;
            }
            else
            {
                tank1.health -= tank2.loss;
                tank2.health -= tank1.loss / 2;
                tank2.experience++;
                tank1.experience++;
                tank1.camouflage++;
                return tank2;
            }
        }

    }
}
