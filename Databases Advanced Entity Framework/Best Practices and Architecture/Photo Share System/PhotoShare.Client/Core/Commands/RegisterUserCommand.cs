namespace PhotoShare.Client.Core.Commands
{
    using System;

    using Models;
    using Data;
    using System.Linq;

    public class RegisterUserCommand : ICommand
    {
        private PhotoShareContext context;

        public RegisterUserCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            if (Session.User == null)
            {
                string username = data[0];
                string password = data[1];
                string repeatPassword = data[2];
                string email = data[3];

                if (!password.Equals(repeatPassword))
                {
                    throw new ArgumentException("Passwords do not match!");
                }

                if (context.Users.Any(u => u.Username.Equals(username)))
                {
                    throw new InvalidOperationException($"Username {username} is already taken!");
                }

                User user = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    IsDeleted = false,
                    RegisteredOn = DateTime.Now,
                    LastTimeLoggedIn = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();

                return "User " + user.Username + " was registered successfully!";
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
