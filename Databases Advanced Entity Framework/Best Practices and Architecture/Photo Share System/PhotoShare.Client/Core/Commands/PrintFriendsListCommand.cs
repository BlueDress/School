namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using System;
    using System.Linq;
    using System.Text;
    using Microsoft.EntityFrameworkCore;

    public class PrintFriendsListCommand : ICommand
    {
        private PhotoShareContext context;

        public PrintFriendsListCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var username = data[0];

            if (!context.Users.Any(u => u.Username.Equals(username)))
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var user = context.Users.Include(u => u.AddedAsFriendBy).First(u => u.Username.Equals(username));

            if (user.AddedAsFriendBy.Count == 0)
            {
                return "No friends for this user. :(";
            }

            var sb = new StringBuilder();
            sb.AppendLine("Friends:");

            foreach (var friend in user.AddedAsFriendBy.OrderBy(f => f.User.Username))
            {
                sb.AppendLine($"-{friend.User.Username}");
            }

            return sb.ToString().Trim();
        }
    }
}
