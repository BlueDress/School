using Inferno_Infinity.Entities.Weapons;
using System.Collections.Generic;
using System;
using Inferno_Infinity.Factories;
using Inferno_Infinity.Entities.Gems;

namespace Inferno_Infinity
{
    public class Engine
    {
        private List<Weapon> weapons;

        public Engine()
        {
            this.weapons = new List<Weapon>();
        }

        public void Run()
        {
            ReadWeaponData();
            ReadAttributeData();
        }

        private void ReadAttributeData()
        {
            var type = typeof(Weapon);
            var attributes = type.GetCustomAttributes(false);

            while (true)
            {
                var command = Console.ReadLine();

                if (command.Equals("END"))
                {
                    break;
                }

                foreach (CustomAttribute attribute in attributes)
                {
                    if (command.Equals("Author"))
                    {
                        Console.WriteLine($"Author: {attribute.Author}");
                    }
                    else if (command.Equals("Revision"))
                    {
                        Console.WriteLine($"Revision: {attribute.Revision}");
                    }
                    else if (command.Equals("Description"))
                    {
                        Console.WriteLine($"Class description: {attribute.Description}");
                    }
                    else
                    {
                        Console.WriteLine($"Reviewers: {attribute.Reviewers}");
                    }
                }
            }
        }

        private void ReadWeaponData()
        {
            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                var commandsArgs = input.Split(';');
                var command = commandsArgs[0];

                switch (command)
                {
                    case "Create":
                        var weaponInfo = commandsArgs[1].Split();

                        var weaponType = weaponInfo[1];
                        WeaponRarity weaponRarity;
                        Enum.TryParse<WeaponRarity>(weaponInfo[0], out weaponRarity);

                        var name = commandsArgs[2];

                        var weapon = WeaponFactory.GetWeapon(name, weaponType, weaponRarity);
                        this.weapons.Add(weapon);
                        break;
                    case "Add":
                        var weaponToSockedName = commandsArgs[1];
                        var indexToSocked = int.Parse(commandsArgs[2]);

                        var gemInfo = commandsArgs[3].Split();
                        var gemType = gemInfo[1];
                        GemClarity gemClarity;
                        Enum.TryParse<GemClarity>(gemInfo[0], out gemClarity);

                        var gem = GemFactory.GetGem(gemType, gemClarity);

                        var weaponToSocket = this.weapons.Find(w => w.Name.Equals(weaponToSockedName));

                        if (0 <= indexToSocked && indexToSocked < weaponToSocket.Sockets.Count)
                        {
                            weaponToSocket.Sockets[indexToSocked] = gem;
                        }
                        break;
                    case "Remove":
                        var weaponToUnsockedName = commandsArgs[1];
                        var indexToUnsocked = int.Parse(commandsArgs[2]);

                        var weaponToUnsocket = this.weapons.Find(w => w.Name.Equals(weaponToUnsockedName));

                        if (0 <= indexToUnsocked && indexToUnsocked < weaponToUnsocket.Sockets.Count && weaponToUnsocket.Sockets[indexToUnsocked] != null)
                        {
                            weaponToUnsocket.Sockets[indexToUnsocked] = null;
                        }
                        break;
                    case "Print":
                        var weaponToPrintName = commandsArgs[1];

                        var weaponToPrint = this.weapons.Find(w => w.Name.Equals(weaponToPrintName));

                        Console.WriteLine(weaponToPrint);
                        break;
                }
            }
        }
    }
}
