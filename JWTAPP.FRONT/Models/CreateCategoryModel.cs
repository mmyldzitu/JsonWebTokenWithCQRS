using System.ComponentModel.DataAnnotations;

namespace JWTAPP.FRONT.Models
{
    public class CreateCategoryModel
    {
        [Required(ErrorMessage ="Lütfen Kategori İsmini Giriniz")]
        public string? Definition { get; set; }
    }
}
