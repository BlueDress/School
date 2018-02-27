using System.Collections.Generic;
using CameraBazaar.Data.Models.Enums;
using CameraBazaar.Services.Models;

namespace CameraBazaar.Services.Contracts
{
    public interface ICameraService
    {
        void Add(string model, CameraMakeType make, decimal price, int quantity, int minShutterSpeed, int maxShutterSpeed, MinIsoType minIso, int maxIso, bool isFullFrame, string videoResolution, IEnumerable<LightMeteringType> lightMeterings, string description, string imageUrl, string userId);

        IEnumerable<ListAllCamerasModel> GetAllCameras();

        CameraDetailsModel GetCameraDetails(int id);
    }
}
