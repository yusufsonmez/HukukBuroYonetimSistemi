using System.ComponentModel.DataAnnotations;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class MahkemelerWebViews
    {
        [Key]
        public int Id { get; set; }
        public string ForForView { get; set; }
        public string LabelForView { get; set; }
        public string IdForView { get; set; }
        public string NameForView { get; set; }
        public string? ValueForView { get; set; }
        //public string? Permission { get; set; }
        public string? Placeholder { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
