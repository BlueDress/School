﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CarDealer.Web.Models.CustomersModel
{
    public class CreateCustomerModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsYoungDriver { get; set; }
    }
}
