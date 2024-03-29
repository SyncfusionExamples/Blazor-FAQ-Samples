﻿using System.ComponentModel.DataAnnotations;
namespace EditContext
{
    public class Customer
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "The organization code must be less than 5   characters in length.")]
        public string? OrganizationCode { get; set; }
    }
}
