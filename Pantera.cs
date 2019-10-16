using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Tanki
{
    public class Pantera : Tank
    { 

        public Pantera(int loss, int health, int Mob, int camouflage, int experience, string Name)
            :base(loss, health, Mob, camouflage, experience, Name)
        { } 
    }
}
