﻿using System.ComponentModel.DataAnnotations;

namespace MarketApp_DTO
{
    public class RegisterDTO
    {
        public string? FirstName { get; init; }
        public string? LastName { get; init; }

        [Required(ErrorMessage = "Username is required")]
        public string? UserName { get; init; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; init; }
        public string? Email { get; init; }
    }
}
