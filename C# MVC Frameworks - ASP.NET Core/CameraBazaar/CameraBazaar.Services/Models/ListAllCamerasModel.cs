using CameraBazaar.Data.Models.Enums;

namespace CameraBazaar.Services.Models
{
    public class ListAllCamerasModel
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public CameraMakeType Make { get; set; }

        public decimal Price { get; set; }

        public bool IsInStock { get; set; }

        public string ImageUrl { get; set; }
    }
}
