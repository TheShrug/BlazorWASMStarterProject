﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWASMStarterProject.Shared.Auth
{
    public class RegisterModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "{0} must be less than {0} characters long.")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public Guid UserGuid { get; set; }
    }
}
