using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiList
{
    //Character_1
    class Samurai
    {
        //readonly Sword sword;  -- tightly coupled

        readonly IWeapon weapon;
        public Samurai(IWeapon weapon)
        {
            this.weapon = weapon;        // Sword is tightly coupled inorder to change the weapon
        }

        //Attack_1
        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
    

    //Character_2
    class Sumo
    {
        readonly IWeapon weapon;

        public Sumo(IWeapon weapon)
        {
            this.weapon = weapon;
        }


        //Attack_1
        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
    }
}
