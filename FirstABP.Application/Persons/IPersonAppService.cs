using FirstABP.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Persons
{
    public interface IPersonAppService
    {
        GetCitiesOutput GetList(GetPersonsInput input);
    }
}
