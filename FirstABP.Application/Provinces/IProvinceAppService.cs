using FirstABP.Provinces.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Provinces
{
    public interface IProvinceAppService
    {
        void CreateProvince(ProvinceInput input);
    }
}
