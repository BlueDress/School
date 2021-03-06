﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Range(0, double.MaxValue)]
        public double TraveledDistance { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

        public ICollection<PartCar> Parts { get; set; } = new List<PartCar>();
    }
}
