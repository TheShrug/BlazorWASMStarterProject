using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorWASMStarterProject.Shared.Auth
{
    public class LoginModel
    {
        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public Guid UserGuid { get; set; }
    }
}
