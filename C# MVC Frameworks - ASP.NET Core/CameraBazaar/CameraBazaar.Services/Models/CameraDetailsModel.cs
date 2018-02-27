using CameraBazaar.Data.Models.Enums;

namespace CameraBazaar.Services.Models
{
    public class CameraDetailsModel
    {
        public int Id { get; set; }

        public CameraMakeType Make { get; set; }
        
        public string Model { get; set; }

        public decimal Price { get; set; }
        
        public bool IsInStock { get; set; }
        
        public int MinShutterSpeed { get; set; }
        
        public int MaxShutterSpeed { get; set; }

        public MinIsoType MinIso { get; set; }
        
        public int MaxIso { get; set; }

        public bool IsFullFrame { get; set; }
        
        public string VideoResolution { get; set; }

        public LightMeteringType LightMetering { get; set; }
        
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public string Username { get; set; }
    }
}
