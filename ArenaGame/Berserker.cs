using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Berserker : Hero
    {
        public Berserker(string name) : base(name)
        {

        }

        public override int Attack()
        {
            int baseDamage = base.Attack();
            if (ThrowDice(20))  
            {
                Console.WriteLine($"{Name} enters a berserk rage and deals massive damage!");
                return baseDamage * 3;  
            }
            return baseDamage;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (Health < StartingHealth / 2) 
            {
                Console.WriteLine($"{Name} is enraged and takes reduced damage!");
                incomingDamage /= 2;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
