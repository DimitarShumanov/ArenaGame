using ArenaGame;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of battles:");
            int rounds = Int32.Parse(Console.ReadLine());
            int[] wins = new int[4];

            for (int i = 0; i < rounds; i++)
            {
                Knight knight = new Knight("Sir Lancelot");
                Sword sword = new Sword("Excalibur", 30, 100, "Legendary", "Sharpness");
                sword.Equip(knight);

                Rogue rogue = new Rogue("Robin Hood");
                Dagger dagger = new Dagger("Shadow Blade", 15, 60, "Rare", "Bleed");
                dagger.Equip(rogue);

                Mage mage = new Mage("Merlin");
                Staff staff = new Staff("Elder Staff", 25, 80, "Epic", "Fireball");
                staff.Equip(mage);

                Berserker berserker = new Berserker("Conan");
                Sword berserkerSword = new Sword("Barbarian Blade", 25, 90, "Epic", "Rage");
                berserkerSword.Equip(berserker);

                // Battle
                Console.WriteLine($"Arena fight between: {knight.Name}, {rogue.Name}, {mage.Name}, and {berserker.Name}");
                Arena arena = new Arena(knight, rogue, mage, berserker);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");

                if (winner == knight)
                    wins[0]++;
                else if (winner == rogue)
                    wins[1]++;
                else if (winner == mage)
                    wins[2]++;
                else if (winner == berserker)
                    wins[3]++;
            }

            Console.WriteLine();
            Console.WriteLine($"Sir Lancelot has {wins[0]} wins.");
            Console.WriteLine($"Robin Hood has {wins[1]} wins.");
            Console.WriteLine($"Merlin has {wins[2]} wins.");
            Console.WriteLine($"Conan has {wins[3]} wins.");

            Console.ReadLine();
        }
    }
}
