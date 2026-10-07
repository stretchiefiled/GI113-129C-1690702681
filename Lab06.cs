using System;

namespace week0006
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int heroHP = 100;
                int monsterHP = 100;

                Console.WriteLine("Adventure of Brian");
                Console.WriteLine("---- Monster Encounter 1 ----");
                Console.WriteLine("ACTION A: ATTACK");
                Console.WriteLine("ACTION B: FLEE");
                Console.WriteLine("ACTION C: HEAL");
                Console.WriteLine();

                Console.Write("Choose your action: ");

                char action;

                // รับค่า action ต้องเป็นตัวอักษร 1 ตัว
                if (!char.TryParse(Console.ReadLine(), out action))
                {
                    Console.WriteLine("Invalid action. Please choose A, B, or C.");
                }
                else if (action == 'A' || action == 'a')

                {
                    // Attack
                    monsterHP -= 30;

                    Console.WriteLine(
                        "You hit the monster for 30. Monster HP is now "
                        + monsterHP + "."
                    );
                }
                else if (action == 'B' || action == 'b')
                {
                    // Flee
                    heroHP -= 30;

                    Console.WriteLine(
                        "You run away but the monster hits you for 30. Hero HP is now "
                        + heroHP + "."
                    );
                }
                else if (action == 'C' || action == 'c')
                {
                    // Heal
                    heroHP += 20;

                    Console.WriteLine(
                        "You drink a potion and heal 20. Hero HP is now "
                        + heroHP + "."
                    );
                }
                else
                {
                    // Invalid action
                    Console.WriteLine(
                        "Invalid action. Please choose A, B, or C."
                    );
                }
            }
        }

    }
