namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class AddTagToCommand : ICommand
    {
        private PhotoShareContext context;

        public AddTagToCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var albumName = data[0];
            var tag = data[1];

            if (Session.User != null)
            {
                var role = context.AlbumRoles.FirstOrDefault(r => r.User == Session.User && r.Album.Name.Equals(albumName)).Role.ToString();

                if (role.Equals("Owner"))
                {
                    if (!context.Tags.Any(t => t.Name.Equals(tag)) || !context.Albums.Any(a => a.Name.Equals(albumName)))
                    {
                        throw new ArgumentException("Either tag or album do not exist!");
                    }

                    context.AlbumTags.Add(new AlbumTag { Album = context.Albums.First(a => a.Name.Equals(albumName)), Tag = context.Tags.First(t => t.Name.Equals(tag)) });
                    context.SaveChanges();

                    return $"Tag {tag} added to {albumName}!";
                }
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
