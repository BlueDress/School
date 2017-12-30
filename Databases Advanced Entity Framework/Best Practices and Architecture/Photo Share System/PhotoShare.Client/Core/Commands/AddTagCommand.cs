namespace PhotoShare.Client.Core.Commands
{
    using Models;
    using Data;
    using Utilities;
    using System.Linq;
    using System;

    public class AddTagCommand : ICommand
    {
        private PhotoShareContext context;

        public AddTagCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            if (Session.User != null)
            {
                string tag = data[0].ValidateOrTransform();

                if (context.Tags.Any(t => t.Name.Equals(tag)))
                {
                    throw new ArgumentException($"Tag {tag} exists!");
                }

                context.Tags.Add(new Tag
                {
                    Name = tag
                });

                context.SaveChanges();

                return $"Tag {tag} was added successfully to database!";
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
