namespace PhotoShare.Client.Core.Commands
{
    using Models;
    using Data;
    using System.Linq;
    using System;

    public class AddTownCommand : ICommand
    {
        private PhotoShareContext context;

        public AddTownCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            string townName = data[0];
            string countryName = data[1];

            if (Session.User != null)
            {
                if (context.Towns.Any(t => t.Name.Equals(townName)) && context.Towns.First(t => t.Name.Equals(townName)).Country.Equals(countryName))
                {
                    throw new ArgumentException($"Town {townName} was already added!");
                }

                Town town = new Town
                {
                    Name = townName,
                    Country = countryName
                };

                context.Towns.Add(town);
                context.SaveChanges();

                return $"Town {town.Name} was added successfully!";
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
