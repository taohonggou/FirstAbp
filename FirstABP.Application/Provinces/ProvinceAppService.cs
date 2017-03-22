using Abp.Domain.Repositories;
using FirstABP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstABP.Provinces.Dto;
using Abp.AutoMapper;

namespace FirstABP.Provinces
{
    public class ProvinceAppService : FirstABPAppServiceBase, IProvinceAppService
    {
        private IRepository<Province> _provinceRepository;

        public ProvinceAppService(IRepository<Province> provinceRepository)
        {
            _provinceRepository = provinceRepository;
        }

        public void CreateProvince(ProvinceInput input)
        {
            _provinceRepository.Insert(input.MapTo<Province>());
           
        }
    }
}
