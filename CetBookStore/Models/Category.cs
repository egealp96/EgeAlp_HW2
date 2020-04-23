using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Category
    {
        [Display(Name="Kategori ID")]
        public int Id { get; set; }
        [StringLength(100,MinimumLength =3, ErrorMessage = "Başlık Alanı 2 ile 10 karakter arasında olmalıdır")]
        [Required(ErrorMessage ="Bu alan zorunludur.")]
        [Display(Name="İsim")]
        public string Name { get; set; } // nvarchar(100) 2GB
        [Display(Name="Kategorideki Kitap Listesi")]
        public virtual List<Book> Books { get; set; }
    }
}
