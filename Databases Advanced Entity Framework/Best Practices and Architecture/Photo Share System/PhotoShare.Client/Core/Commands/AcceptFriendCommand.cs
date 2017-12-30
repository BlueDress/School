namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public class AcceptFriendCommand : ICommand
    {
        private PhotoShareContext context;

        public AcceptFriendCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var firstUsername = data[0];
            var secondUsername = data[1];

            if (Session.User.Username.Equals(firstUsername))
            {
                if (!context.Users.Any(u => u.Username.Equals(firstUsername)) || !context.Users.Any(u => u.Username.Equals(secondUsername)))
                {
                    throw new ArgumentException("User not found");
                }

                var firstUser = context.Users.Include(u => u.FriendsAdded).ThenInclude(fa => fa.Friend).First(u => u.Username.Equals(firstUsername));
                var secondUser = context.Users.Include(u => u.FriendsAdded).ThenInclude(fa => fa.Friend).First(u => u.Username.Equals(secondUsername));

                if (firstUser.FriendsAdded.Any(f => f.Friend.Username.Equals(secondUsername)))
                {
                    throw new InvalidOperationException($"{firstUsername} is already a friend to {secondUsername}");
                }

                if (!secondUser.FriendsAdded.Any(f => f.Friend.Username.Equals(firstUsername)))
                {
                    throw new InvalidOperationException($"{secondUsername} has not added {firstUsername} as a friend");
                }

                firstUser.FriendsAdded.Add(new Friendship { User = firstUser, Friend = secondUser });

                context.SaveChanges();

                return $"{firstUsername} accepted {secondUsername} as a friend";
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
