using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HukukBuroYonetimSistemi.Models.Domain
{
    public class ValuesForMahkemeWebViews
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("MahkemeWebViewId")]
        public int MahkemeWebViewId { get; set; }
        public int RelationId { get; set; }
        public string Value { get; set; }
        public string? Permission { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        // MahkemelerWebViews tablosuna foreign key ilişkisi
        public ICollection<MahkemelerWebViews> MahkemelerWebViews { get; set; }
    }
}
