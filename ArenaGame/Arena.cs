namespace ArenaGame
{
    public class Arena
    {
        public Hero HeroA { get; private set; }
        public Hero HeroB { get; private set; }
        public Hero HeroC { get; private set; }
        public Hero HeroD { get; private set; }

        public Arena(Hero a, Hero b, Hero c, Hero d)
        {
            HeroA = a;
            HeroB = b;
            HeroC = c;
            HeroD = d;
        }

        public Hero Battle()
        {
            Hero[] attackers = { HeroA, HeroB, HeroC, HeroD };
            Hero[] defenders = { HeroA, HeroB, HeroC, HeroD };

            var random = new Random();
            int attackerIndex1 = random.Next(4);
            int attackerIndex2;
            do
            {
                attackerIndex2 = random.Next(4);
            } while (attackerIndex2 == attackerIndex1);

            int defenderIndex1 = (attackerIndex1 + 1) % 4;
            int defenderIndex2 = (attackerIndex2 + 1) % 4;

            while (true)
            {
                int damage1 = attackers[attackerIndex1].Attack();
                defenders[defenderIndex1].TakeDamage(damage1);
                if (defenders[defenderIndex1].IsDead) return attackers[attackerIndex1];

                int damage2 = attackers[attackerIndex2].Attack();
                defenders[defenderIndex2].TakeDamage(damage2);
                if (defenders[defenderIndex2].IsDead) return attackers[attackerIndex2];
            }
        }
    }
}
