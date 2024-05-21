using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
             
        }

        public override int Attack()
        {
            int baseDamage = base.Attack();
            if (ThrowDice(25)) 
            {
                Console.WriteLine($"{Name} casts a powerful spell!");
                return baseDamage + 50; 
            }
            return baseDamage;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(15)) 
            {
                Console.WriteLine($"{Name} creates a magic shield and takes no damage!");
                return;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
