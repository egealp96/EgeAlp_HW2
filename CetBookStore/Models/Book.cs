using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        [Display(Name = "Kitap ID")]
        public int Id { get; set; }

        [StringLength(25, MinimumLength =3, ErrorMessage = "Isim 3-25 karakter arasinda olmalidir.")]
        [Required(ErrorMessage = "Kitap adi girmek zorundasiniz.")]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable

        [Display(Name = "Sayfa Sayisi")]
        public int? PageCount { get; set; }
        [Display(Name = "Yazarlar")]
        public string Authors { get; set; }

        [Display(Name = "Kitap Aciklamasi")]
        [StringLength(400, MinimumLength =10, ErrorMessage ="Aciklama yazisi 10 ile 400 karakter arasinda olmalidir.")]
        public string Description  { get; set; }

        [Display(Name = "Fiyat")]
        [Required (ErrorMessage = "Fiyat alanini bos birakamazsiniz, ucretsiz ise '0' (sifir) yazmalisiniz.")]
      
        public Decimal Price { get; set; }
        [Display(Name = "Basim Yili")]
        public int PressYear { get; set; }
        [Display(Name = "Stok Sayisi")]
        public int StockCount { get; set; }

        [Display(Name = "Kategorisi")]
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        [Display(Name = "Kategorisi")]
        public  Category Category { get; set; }

        [Display(Name = "Eklendigi Tarih")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Yorumlar")]
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
          //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }

    }
}
