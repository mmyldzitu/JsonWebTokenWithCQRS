using System.ComponentModel.DataAnnotations;

namespace JWTAPP.FRONT.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Gereklidir")]
        public string UserName { get; set; } = null!;


        [Required(ErrorMessage = "Şifre Gereklidir")]

        public string Password { get; set; } = null!;
    }
}
