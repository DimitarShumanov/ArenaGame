using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Sword : Weapon
    {
        public Sword(string name, int damage, double durability, string rarity, string enchantment) : base(name, damage, durability, rarity, enchantment) { }

        public override void Equip(Hero hero)
        {
            base.Equip(hero);
            Console.WriteLine("The sword's enchantment grants additional attack power!");
            hero.Strength += 12;
            Console.WriteLine($"{hero.Name} increased strenght to {hero.Strength}");
        }
    }
}
