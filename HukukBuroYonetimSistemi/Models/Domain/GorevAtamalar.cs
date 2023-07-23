using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class GorevAtamalar
    {
        [Key]
        public int Id { get; set; }

        // Mahkemeler tablosuna foreign key ilişkisi
        [ForeignKey("Mahkeme")]
        public int? GorevAtamaId { get; set; }
        public Mahkemeler GorevAtama { get; set; }

        // Users tablosuna foreign key ilişkisi
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public Users User { get; set; }
    }
}
