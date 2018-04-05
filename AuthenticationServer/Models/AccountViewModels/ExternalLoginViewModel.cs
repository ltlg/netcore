using System.ComponentModel.DataAnnotations;

namespace AuthenticationServer.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
