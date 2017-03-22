using Abp.AutoMapper;
using FirstABP.Entities;

namespace FirstABP.Persons.Dto
{
    [AutoMapFrom(typeof(Person))]
    public class PersonDto
    {
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
    }
}
