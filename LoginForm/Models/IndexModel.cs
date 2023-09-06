using System.ComponentModel.DataAnnotations;

namespace LoginForm.Models
{
    public class IndexModel
    {
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }

        public string ErrorMessage { get; set; } = string.Empty;    
    }
}