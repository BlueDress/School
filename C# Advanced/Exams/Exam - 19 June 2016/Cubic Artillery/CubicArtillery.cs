using System;
using System.Collections.Generic;
using System.Linq;

namespace Cubic_Artillery
{
    public class CubicArtillery
    {
        public static void Main()
        {
            var bunkersMaxCapacity = int.Parse(Console.ReadLine());
            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("Bunker Revision"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var weaponCapacity = 0;
                    var freeCapacity = bunkersMaxCapacity;

                    for (int i = 0; i < tokens.Count(); i++)
                    {
                        if (!int.TryParse(tokens[i], out weaponCapacity))
                        {
                            bunkers.Enqueue(tokens[i]);
                        }
                        else
                        {

                            if (bunkers.Count == 1)
                            {
                                if (bunkersMaxCapacity >= weaponCapacity)
                                {
                                    if (freeCapacity < weaponCapacity)
                                    {
                                        while (freeCapacity < weaponCapacity)
                                        {
                                            freeCapacity += weapons.Dequeue();
                                        }
                                    }

                                    weapons.Enqueue(weaponCapacity);
                                    freeCapacity -= weaponCapacity;
                                }
                            }
                            else
                            {
                                while (bunkers.Count > 1)
                                {
                                    if (freeCapacity >= weaponCapacity)
                                    {
                                        weapons.Enqueue(weaponCapacity);
                                        freeCapacity -= weaponCapacity;
                                        break;
                                    }
                                    else
                                    {
                                        if (weapons.Count > 0)
                                        {
                                            Console.WriteLine($"{bunkers.Dequeue()} -> {string.Join(", ", weapons)}");
                                            weapons.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{bunkers.Dequeue()} -> Empty");
                                        }

                                        freeCapacity = bunkersMaxCapacity;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
