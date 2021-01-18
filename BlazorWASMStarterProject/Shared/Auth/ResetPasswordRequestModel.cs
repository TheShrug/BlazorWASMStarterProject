using System.ComponentModel.DataAnnotations;

namespace BlazorWASMStarterProject.Shared.Auth
{
    public class ResetPasswordRequestModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}