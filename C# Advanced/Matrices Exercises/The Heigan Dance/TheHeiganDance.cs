using System;

namespace The_Heigan_Dance
{
    public class TheHeiganDance
    {
        public static void Main(string[] args)
        {
            var chamber = new string[15][];

            for (int row = 0; row < chamber.Length; row++)
            {
                chamber[row] = new string[15];

                for (int col = 0; col < chamber[row].Length; col++)
                {
                    chamber[row][col] = "safe";
                }
            }

            var playerDamage = double.Parse(Console.ReadLine());
            var playerHitPoints = 18500;
            var playerRow = 7;
            var playerCol = 7;
            var heiganHitPoints = 3000000d;

            var spell = string.Empty;
            var plagueCloudActive = false;

            while (playerHitPoints > 0 && heiganHitPoints > 0)
            {
                var input = Console.ReadLine().Split();
                var targetRow = int.Parse(input[1]);
                var targetCol = int.Parse(input[2]);

                heiganHitPoints -= playerDamage;

                if (plagueCloudActive)
                {
                    playerHitPoints -= 3500;
                    plagueCloudActive = false;

                    if (playerHitPoints <= 0)
                    {
                        break;
                    }
                }

                if (heiganHitPoints > 0)
                {
                    for (int row = Math.Max(0, targetRow - 1); row <= Math.Min(targetRow + 1, 14); row++)
                    {
                        for (int col = Math.Max(0, targetCol - 1); col <= Math.Min(targetCol + 1, 14); col++)
                        {
                            chamber[row][col] = "danger";
                        }
                    }

                    if (chamber[playerRow][playerCol].Equals("danger"))
                    {
                        if (playerRow - 1 >= 0 && chamber[playerRow - 1][playerCol].Equals("safe"))
                        {
                            playerRow -= 1;
                        }
                        else if (playerCol + 1 <= 14 && chamber[playerRow][playerCol + 1].Equals("safe"))
                        {
                            playerCol += 1;
                        }
                        else if (playerRow + 1 <= 14 && chamber[playerRow + 1][playerCol].Equals("safe"))
                        {
                            playerRow += 1;
                        }
                        else if (playerCol - 1 >= 0 && chamber[playerRow][playerCol - 1].Equals("safe"))
                        {
                            playerCol -= 1;
                        }
                        else
                        {
                            spell = input[0];

                            if (spell.Equals("Cloud"))
                            {
                                playerHitPoints -= 3500;
                                plagueCloudActive = true;
                            }
                            else
                            {
                                playerHitPoints -= 6000;
                            }
                        }
                    }

                    for (int row = Math.Max(0, targetRow - 1); row <= Math.Min(targetRow + 1, 14); row++)
                    {
                        for (int col = Math.Max(0, targetCol - 1); col <= Math.Min(targetCol + 1, 14); col++)
                        {
                            chamber[row][col] = "safe";
                        }
                    }
                }
            }

            if (heiganHitPoints > 0)
            {
                Console.WriteLine($"Heigan: {heiganHitPoints:f2}");
            }
            else
            {
                Console.WriteLine("Heigan: Defeated!");
            }

            if (playerHitPoints > 0)
            {
                Console.WriteLine($"Player: {playerHitPoints}");
            }
            else
            {
                if (spell.Equals("Cloud"))
                {
                    Console.WriteLine($"Player: Killed by Plague {spell}");
                }
                else
                {
                    Console.WriteLine($"Player: Killed by {spell}");
                }
            }

            Console.WriteLine($"Final position: {playerRow},{playerCol}");
        }
    }
}
