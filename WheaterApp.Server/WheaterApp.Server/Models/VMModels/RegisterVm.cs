﻿using System.ComponentModel.DataAnnotations;

namespace WheaterApp.Server.Models.VMModels
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords not matching")]
        public string ConfirmPassword { get; set; }
    }
}
