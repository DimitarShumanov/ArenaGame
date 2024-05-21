using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Dagger : Weapon
    {
        public Dagger(string name, int damage, double durability, string rarity, string enchantment) : base(name, damage, durability, rarity, enchantment) { }

        public override void Equip(Hero hero)
        {
            base.Equip(hero);
            hero.Strength += 5;
            Console.WriteLine("The dagger's enchantment grants bleed damage!");

        }
    }
}
