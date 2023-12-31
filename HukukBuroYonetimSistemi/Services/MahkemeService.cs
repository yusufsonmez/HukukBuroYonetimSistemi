﻿using BaseProject.Repositories;
using HukukBuroYonetimSistemi.Models.Domain;
using HukukBuroYonetimSistemi.Models.View;

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
            var mahkemeler = _mahkemeRepository.GetMahkemelerByUserId(UserId);
            return mahkemeler;
        }
        public List<GorevAtamalar> GetMahkemeler()
        {
            var mahkemeler = _mahkemeRepository.GetMahkemeler();
            return mahkemeler;
        }
        public (List<MahkemelerWebViews>, List<ValuesForMahkemeWebViews>) GetMahkemeViews()
        {
            var mahkemeler = _mahkemeRepository.GetMahkemeViews();
            return mahkemeler;
        }
    }
}
