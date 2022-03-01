using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KariyerCore.Models
{
    public class BasvuruSahibi
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(50)]
        public string AdSoyad { get; set; }

        [Required, StringLength(10)]
        public string Cinsiyet { get; set; }

        [Required]
        [Range(25,55,ErrorMessage ="Bu Pozisyona Yaş Uygun Değildir.")]
        [DisplayName("Yas")]
        public int Yas { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Geçersiz")]
        [DisplayName("Toplam Çalışma Yılı")]
        public int ToplamTecrube { get; set; }


    }
}
