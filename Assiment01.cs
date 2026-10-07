namespace assiment01
{
    internal class Program
    {
        class ProgramAssiment01
        {
            static void Main()
            {
                const int MaxHP = 100;
                var player = "Zombie Hunter";

                string weapon = "Gun";
                int hp = MaxHP;
                int ammo = 5;
                double damage = 25.0;
                float score = 0f;
                char level = '1';
                bool playing = true;

                // Implicit conversion
                int bullet = 1;
                double bulletDouble = bullet;

                // Explicit conversion
                int damageInt = (int)damage;

                Console.WriteLine("=== ZOMBIE HUNTER ===");
                Console.WriteLine($"Player: {player}");
                Console.WriteLine($"Weapon: {weapon}");
                Console.WriteLine($"Level: {level}");
                Console.WriteLine();

                int zombieHP = Convert.ToInt32(
                    Console.ReadLine() ?? "100"
                );

                while (playing && hp > 0 && zombieHP > 0)
                {
                    Console.WriteLine($"\nHP: {hp} | Ammo: {ammo} | Zombie HP: {zombieHP}");
                    Console.Write("กด 1 เพื่อยิง / 2 เพื่อออก: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1 && ammo > 0)
                    {
                        ammo--;
                        zombieHP -= damageInt;
                        score += 100;

                        Console.WriteLine($"💥 ยิงโดน! Damage = {damageInt}");
                    }
                    else if (choice == 2)
                    {
                        playing = false;
                    }
                    else
                    {
                        Console.WriteLine("กระสุนหมดหรือเลือกไม่ถูกต้อง");
                    }
                }

                if (zombieHP <= 0)
                    Console.WriteLine($"\n🧟 Zombie ตาย! Score = {score}");
                else
                    Console.WriteLine($"\nจบเกม! Score = {score}");

                Console.WriteLine($"Implicit: {bullet} -> {bulletDouble}");
                Console.WriteLine($"Explicit: {damage} -> {damageInt}");
            }
        }
    }
    }

