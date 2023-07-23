using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class Mahkemeler
    {
        [Key]
        public int Id { get; set; }
        public string Mahkeme { get; set; }
        public string DosyaNo { get; set; }
        public string GelenEvrakTuru { get; set; }
        public string TebligTuru { get; set; }
        public DateTime TebligTarihi { get; set; }
        public string Diger { get; set; }
        public string IsTuru { get; set; }
        public string GelmeTarihi { get; set; }
        public DateTime HedefSureSonGun { get; set; }
        public DateTime Gorev { get; set; }

        // GorevAtamalar tablosuna foreign key ilişkisi
        [ForeignKey("GorevAtama")]
        public int? GorevAtamaId { get; set; }
        public GorevAtamalar GorevAtama { get; set; }
        public DateTime DurusmaTarihi { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
