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
        public int MahkemeId { get; set; }
        public Mahkemeler Mahkeme { get; set; }

        // Users tablosuna foreign key ilişkisi
        [ForeignKey("User")]
        public int UserId { get; set; }
        public Users User { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
