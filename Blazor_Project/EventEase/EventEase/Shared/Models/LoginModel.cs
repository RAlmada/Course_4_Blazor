using System.ComponentModel.DataAnnotations;

namespace EventEase.Shared.Models;

public class LoginModel
{
    [Required(ErrorMessage = "Username is required")]
    public string Username { get; set; } = string.Empty;
}