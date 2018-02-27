using System.Collections.Generic;
using CameraBazaar.Data.Models.Enums;
using CameraBazaar.Services.Contracts;
using CameraBazaar.Data;
using CameraBazaar.Data.Models;
using System.Linq;
using CameraBazaar.Services.Models;

namespace CameraBazaar.Services.Implementations
{
    public class CameraService : ICameraService
    {
        public readonly CameraBazaarDbContext db;

        public CameraService(CameraBazaarDbContext db)
        {
            this.db = db;
        }

        public CameraDetailsModel GetCameraDetails(int id)
        {
            return this.db.Cameras.Select(c => new CameraDetailsModel
            {
                Id = c.Id,
                Model = c.Model,
                Make = c.Make,
                Price = c.Price,
                ImageUrl = c.ImageUrl,
                IsInStock = c.Quantity > 0 ? true : false,
                MinIso = c.MinIso,
                MaxIso = c.MaxIso,
                MinShutterSpeed = c.MinShutterSpeed,
                MaxShutterSpeed = c.MaxShutterSpeed,
                IsFullFrame = c.IsFullFrame,
                VideoResolution = c.VideoResolution,
                LightMetering = c.LightMetering,
                Description = c.Description,
                Username = c.User.UserName
            }).First(c => c.Id == id);
        }

        public IEnumerable<ListAllCamerasModel> GetAllCameras()
        {
            return this.db.Cameras.Select(c => new ListAllCamerasModel
            {
                Id = c.Id,
                Model = c.Model,
                Make = c.Make,
                Price = c.Price,
                ImageUrl = c.ImageUrl,
                IsInStock = c.Quantity > 0 ? true : false
            });
        }

        public void Add(string model, CameraMakeType make, decimal price, int quantity, int minShutterSpeed, int maxShutterSpeed, MinIsoType minIso, int maxIso, bool isFullFrame, string videoResolution, IEnumerable<LightMeteringType> lightMeterings, string description, string imageUrl, string userId)
        {
            var camera = new Camera
            {
                Model = model,
                Make = make,
                Price = price,
                Quantity = quantity,
                MinShutterSpeed = minShutterSpeed,
                MaxShutterSpeed = maxShutterSpeed,
                MinIso = minIso,
                MaxIso = maxIso,
                IsFullFrame = isFullFrame,
                VideoResolution = videoResolution,
                LightMetering = (LightMeteringType)lightMeterings.Cast<int>().Sum(),
                Description = description,
                ImageUrl = imageUrl,
                UserID = userId
            };

            this.db.Cameras.Add(camera);
            this.db.SaveChanges();
        }
    }
}
