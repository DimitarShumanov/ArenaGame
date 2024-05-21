using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Staff : Weapon
    {
        public Staff(string name, int damage, double durability, string rarity, string enchantment) : base(name, damage, durability, rarity, enchantment) { }

        public override void Equip(Hero hero)
        {
            base.Equip(hero);
            Console.WriteLine("The staff's enchantment grants additional spell power!");
            hero.Strength += 10;
            Console.WriteLine($"{hero.Name} increased spell power to {hero.Strength}");
        }
    }
}
