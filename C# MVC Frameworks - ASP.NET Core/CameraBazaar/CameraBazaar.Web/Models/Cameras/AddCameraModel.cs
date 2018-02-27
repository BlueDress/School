using CameraBazaar.Data.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CameraBazaar.Web.Models.Cameras
{
    public class AddCameraModel
    { 
        public CameraMakeType Make { get; set; }

        [Required]
        public string Model { get; set; }

        public decimal Price { get; set; }

        [Range(0, 100)]
        public int Quantity { get; set; }

        [Display(Name = "Min Shutter Speed")]
        [Range(1, 30)]
        public int MinShutterSpeed { get; set; }

        [Display(Name = "Max Shutter Speed")]
        [Range(2000, 8000)]
        public int MaxShutterSpeed { get; set; }

        [Display(Name = "MinISO")]
        public MinIsoType MinIso { get; set; }

        [Display(Name = "MaxISO")]
        [Range(200, 409600)]
        public int MaxIso { get; set; }

        [Display(Name = "Full Frame")]
        public bool IsFullFrame { get; set; }

        [Display(Name = "Video Resolution")]
        [Required]
        [MaxLength(15)]
        public string VideoResolution { get; set; }

        [Display(Name = "Light Metering")]
        public IEnumerable<LightMeteringType> LightMeterings { get; set; }

        [Required]
        [MaxLength(6000)]
        public string Description { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [MinLength(10)]
        [MaxLength(2000)]
        public string ImageUrl { get; set; }
    }
}
