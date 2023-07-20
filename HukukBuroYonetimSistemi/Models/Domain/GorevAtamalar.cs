using System.ComponentModel.DataAnnotations;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class GorevAtamalar
    {
        [Key]
        public int Id { get; set; }
        public Users UserName { get; set; }
    }
}
