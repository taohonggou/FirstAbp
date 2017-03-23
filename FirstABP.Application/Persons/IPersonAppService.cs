using FirstABP.Persons.Dto;
using System.Web.Http;

namespace FirstABP.Persons
{
    public interface IPersonAppService
    {
        GetCitiesOutput GetList(GetPersonsInput input);

        [HttpPost]
        void CreatePerson(CreatePersonInput input);
    }
}
