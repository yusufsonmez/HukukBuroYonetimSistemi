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
        GorevAtamalar gorevAtamaModel = new GorevAtamalar();
        public void Kaydet(Mahkemeler model)
        {
            model.IsActive = true;
            model.IsDeleted = false;
            model.InsertDate = DateTime.Now;
            model.UpdateDate = DateTime.Now;
            _mahkemeDbContext.Add(model);
            _mahkemeDbContext.SaveChanges();

            // Görev atamalarını ilişkili olarak ekleyin
            if (model.GorevAtamalar != null)
            {
                gorevAtamaModel.MahkemeId = model.Id;
                gorevAtamaModel.UserId = model.GorevAtamalar;
                gorevAtamaModel.IsActive = true;
                gorevAtamaModel.IsDeleted = false;
                gorevAtamaModel.InsertDate = DateTime.Now;
                gorevAtamaModel.UpdateDate = DateTime.Now;
                _mahkemeDbContext.GorevAtamalar.Add(gorevAtamaModel);
            }

            _mahkemeDbContext.SaveChanges();
        }
        public List<Mahkemeler> GetMahkemelerByUserId(int userId)
        {
            // UserId ile görevAtamalar tablosundan ilgili görev atamalarını seçin
            var gorevAtamalar = _mahkemeDbContext.GorevAtamalar
                .Where(g => g.UserId == userId)
                .ToList();

            // Görev atamalarının MahkemeId'lerini alarak ilgili mahkemeleri çekin
            var mahkemeler = _mahkemeDbContext.Mahkemeler
                .Where(m => gorevAtamalar.Select(g => g.MahkemeId).Contains(m.Id))
                .ToList();

            return mahkemeler;
        }
    }
}
    