namespace PhotoShare.Client.Core.Commands
{
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class UploadPictureCommand : ICommand
    {
        private PhotoShareContext context;

        public UploadPictureCommand(PhotoShareContext context)
        {
            this.context = context;
        }

        public string Execute(string[] data)
        {
            var albumName = data[0];
            var pictureTitle = data[1];
            var pictureFilePath = data[2];

            if (Session.User != null)
            {
                var role = context.AlbumRoles.FirstOrDefault(r => r.User == Session.User && r.Album.Name.Equals(albumName)).Role.ToString();

                if (role.Equals("Owner"))
                {
                    if (!context.Albums.Any(a => a.Name.Equals(albumName)))
                    {
                        throw new ArgumentException($"Album {albumName} not found!");
                    }

                    context.Pictures.Add(new Picture { Title = pictureTitle, Path = pictureFilePath, Album = context.Albums.First(a => a.Name.Equals(albumName)) });
                    context.SaveChanges();

                    return $"Picture {pictureTitle} added to {albumName}!";
                }
            }

            throw new InvalidOperationException("Invalid credentials!");
        }
    }
}
