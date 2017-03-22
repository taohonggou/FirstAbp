using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using FirstABP.Entities;

namespace FirstABP.Provinces.Dto
{
    [AutoMapTo(typeof(Province))]
    public class ProvinceInput
    {
        public string ProvinceName { get; set; }
    }
}
