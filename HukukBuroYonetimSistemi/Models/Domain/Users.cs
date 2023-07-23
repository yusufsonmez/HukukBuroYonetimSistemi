using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Statu { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        // GorevAtamalar tablosuna foreign key ilişkisi
        [ForeignKey("GorevAtama")]
        public int? GorevAtamaId { get; set; }
        public GorevAtamalar GorevAtama { get; set; }
    }
}
