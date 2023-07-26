using BaseProject.Repositories;
using HukukBuroYonetimSistemi.Models.Domain;

namespace BaseProject.Services
{
    public class MahkemeService
    {
        private readonly MahkemeRepository _mahkemeRepository;

        public MahkemeService(MahkemeRepository mahkemeRepository)
        {
            _mahkemeRepository = mahkemeRepository;
        }
        public void Kaydet(Mahkemeler model)
        {
            _mahkemeRepository.Kaydet(model);
        }
        public List<Mahkemeler> GetMahkemelerByUserId(int UserId)
        {
            var mahkeme = _mahkemeRepository.GetMahkemelerByUserId(UserId);
            return mahkeme;
        }
    }
}
