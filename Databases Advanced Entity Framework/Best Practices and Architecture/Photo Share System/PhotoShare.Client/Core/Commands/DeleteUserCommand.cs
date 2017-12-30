namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Data;

    public class DeleteUserCommand : ICommand
    {
        private PhotoShareContext context;

        public DeleteUserCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            string username = data[0];

            if (Session.User.Username.Equals(username))
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);

                if (user == null)
                {
                    throw new ArgumentException($"User with {username} was not found!");
                }

                if (user.IsDeleted.Value)
                {
                    throw new InvalidOperationException($"User {username} is already deleted!");
                }

                user.IsDeleted = true;
                context.SaveChanges();

                return $"User {username} was deleted from the database!";
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
