using System.ComponentModel.DataAnnotations;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class GorevAtama
    {
        [Key]
        public int Id { get; set; }
        public UserModel UserName { get; set; }
    }
}
