using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace JWTAPP.FRONT.Models
{
    public class UpdateProductModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün Adı Kısmını Doldurunuz")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Stok Bilgisi Giriniz")]

        public int Stock { get; set; }
        [Required(ErrorMessage = "Fiyat Bilgisi Giriniz")]

        public decimal Price { get; set; }
        [Required(ErrorMessage = "Kategori Seçimi Yapınız")]

        public int CategoryId { get; set; }
        public SelectList? Categories { get; set; }
    }
}
