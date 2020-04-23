using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Comment
    {
        [Display(Name = "Yorum ID")]
        public int Id{ get; set; }
        [Display(Name = "Baslik")]
        public string Title { get; set; }
        [Display(Name = "Detay")]
        [StringLength(100, MinimumLength = 5, ErrorMessage ="Detayiniz 5-100 karakter arasinda olmalidir.")]
        public string Detail { get; set; }
        [Display(Name = "Puan")]
        public int? Rating { get; set; }
        [Display(Name = "Yorum Tarihi")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Kitap IDsi")]
        public int BookId { get; set; }
        [Display(Name = "Kitap")]
        public Book Book { get; set; }

    }
}
