using PhotoShare.Data;
using System;

namespace PhotoShare.Client.Core.Commands
{
    public class LogoutCommand : ICommand
    {
        private PhotoShareContext context;

        public LogoutCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            if (Session.User == null)
            {
                throw new InvalidOperationException("You should log in first in order to logout.");
            }

            var loggedUsername = Session.User.Username;

            Session.User = null;

            return $"User {loggedUsername} successfully logged out!";
        }
    }
}
