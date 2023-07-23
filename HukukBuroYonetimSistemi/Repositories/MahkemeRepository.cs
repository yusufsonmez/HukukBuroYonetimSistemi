using HukukBuroYonetimSistemi.Data;
using HukukBuroYonetimSistemi.Models.Domain;

namespace BaseProject.Repositories
{
    public class MahkemeRepository
    {
        public MahkemeDbContext _mahkemeDbContext { get; set; }
        public MahkemeRepository(MahkemeDbContext mahkemeDbContext) 
        {
            _mahkemeDbContext = mahkemeDbContext;
        }

        public void Kaydet(Mahkemeler model)
        {
            model.IsActive = true;
            model.IsDeleted = false;
            model.InsertDate = DateTime.Now;
            model.UpdateDate = DateTime.Now;
            _mahkemeDbContext.Add(model);
            _mahkemeDbContext.SaveChanges();
        }
    }
}
    