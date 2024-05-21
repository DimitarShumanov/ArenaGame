using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public double Durability { get; set; }
        public string Rarity { get; set; }
        public string Enchantment { get; set; }

        public Weapon() { }

        public Weapon(string name, int damage, double durability, string rarity, string enchantment)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Rarity = rarity;
            Enchantment = enchantment;
        }

        public virtual void Equip(Hero hero)
        {
            hero.Strength += Damage;
            Console.WriteLine($"{hero.Name} equipped {Name}, increasing strenght to {hero.Strength}");
        }

        public void Attack()
        {
            Console.WriteLine($"Attacking with {Name}!");
        }

        public void Repair(double amount)
        {
            Durability += amount;
            Console.WriteLine($"Repaired {Name}. Durability: {Durability}");
        }

        public void DecreaseDurability(double amount)
        {
            Durability -= amount;
            if (Durability <= 0)
            {
                Console.WriteLine($"{Name} broke!");
            }
            else
            {
                Console.WriteLine($"{Name} durability decreased to {Durability}");
            }
        }
    }

}
