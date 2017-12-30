namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class ShareAlbumCommand : ICommand
    {
        private PhotoShareContext context;

        public ShareAlbumCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var albumId = int.Parse(data[0]);
            var username = data[1];
            var permission = data[2];

            if (Session.User != null)
            {
                var role = context.AlbumRoles.FirstOrDefault(r => r.User == Session.User && r.Album.Id == albumId).Role.ToString();

                if (role.Equals("Owner"))
                {
                    if (!Enum.IsDefined(typeof(Role), permission))
                    {
                        throw new ArgumentException("Permission must be either “Owner” or “Viewer”!");
                    }

                    if (!context.Albums.Any(a => a.Id == albumId))
                    {
                        throw new ArgumentException($"Album {albumId} not found!");
                    }

                    if (!context.Users.Any(u => u.Username.Equals(username)))
                    {
                        throw new ArgumentException($"User {username} not found!");
                    }

                    context.AlbumRoles.Add(new AlbumRole { AlbumId = albumId, User = context.Users.First(u => u.Username.Equals(username)), Role = (Role)Enum.Parse(typeof(Role), permission) });
                    context.SaveChanges();

                    return $"Username {username} added to album {context.Albums.First(a => a.Id == albumId).Name} ({permission})";
                }
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
