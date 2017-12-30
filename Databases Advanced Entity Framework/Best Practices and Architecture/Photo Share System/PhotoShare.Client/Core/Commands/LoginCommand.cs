using PhotoShare.Data;
using System;
using System.Linq;

namespace PhotoShare.Client.Core.Commands
{
    public class LoginCommand : ICommand
    {
        private PhotoShareContext context;

        public LoginCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var username = data[0];
            var password = data[1];

            var user = context.Users.FirstOrDefault(u => u.Username.Equals(username));

            if (user == null || !user.Password.Equals(password))
            {
                throw new ArgumentException("Invalid username or password!");
            }

            if (Session.User != null)
            {
                throw new ArgumentException("You should logout first!");
            }

            Session.User = user;

            return $"User {username} successfully logged in!";
        }
    }
}
