using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    //Weapon_1
    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Chopped {target} clean in half.");
        }
    }

    //Weapon_2
    class Hammer : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"{target}'s Armor Destroyed");
        }
    }

    //Weapon_3
    class Jump : IWeapon
    {
        public void Hit(String target)
        {
            Console.WriteLine($"Jumped onto the {target}");
        }

    }
}
