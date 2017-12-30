namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class CreateAlbumCommand : ICommand
    {
        private PhotoShareContext context;

        public CreateAlbumCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var username = data[0];
            var albumTitle = data[1];
            var color = data[2];
            var tags = data.Skip(3).ToArray();

            if (Session.User != null)
            {
                var role = context.AlbumRoles.FirstOrDefault(r => r.User == Session.User && r.Album.Name.Equals(albumTitle)).Role.ToString();

                if (role.Equals("Owner"))
                {
                    if (!context.Users.Any(u => u.Username.Equals(username)))
                    {
                        throw new ArgumentException($"User {username} not found!");
                    }

                    if (context.Users.First(u => u.Username.Equals(username)).AlbumRoles.Any(a => a.Album.Name.Equals(albumTitle)))
                    {
                        throw new ArgumentException($"Album {albumTitle} exists!");
                    }

                    if (!Enum.IsDefined(typeof(Color), color))
                    {
                        throw new ArgumentException($"Color {color} not found!");
                    }

                    if (!tags.All(n => context.Tags.Any(t => t.Name.Equals(n))))
                    {
                        throw new ArgumentException("Invalid tags!");
                    }

                    var album = new Album()
                    {
                        Name = albumTitle,
                        BackgroundColor = (Color)Enum.Parse(typeof(Color), color),
                    };

                    album.AlbumRoles.Add(new AlbumRole() { User = context.Users.First(u => u.Username.Equals(username)), Album = album, Role = Role.Owner });

                    tags.ToList().ForEach(tag => album.AlbumTags.Add(new AlbumTag { Album = album, Tag = new Tag { Name = tag } }));

                    context.Albums.Add(album);
                    context.SaveChanges();

                    return $"Album {album.Name} successfully created!";
                }
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
