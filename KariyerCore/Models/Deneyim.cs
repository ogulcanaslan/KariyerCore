using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KariyerCore.Models
{
    public class Deneyim
    {
        public Deneyim()
        {

        }
        [Key]
        public int DeneyimId { get; set; }

        [ForeignKey("BasvuruSahibi")]
        public int BSId { get; set; }

        public virtual BasvuruSahibi BasvuruSahibi { get; private set; } //Önemli

        public string FirmaAdlari { get; set; }
        public string CalismaTanimi { get; set; }

        [Required]
        public int CalismaYili { get; set; }



    }
}
