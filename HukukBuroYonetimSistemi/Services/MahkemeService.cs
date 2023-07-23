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
    }
}
