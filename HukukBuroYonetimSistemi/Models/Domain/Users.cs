using System.ComponentModel.DataAnnotations;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Statu { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        // Kullanıcının birçok görevi olabilir
        public ICollection<GorevAtamalar> GorevAtamalar { get; set; }
    }
}
