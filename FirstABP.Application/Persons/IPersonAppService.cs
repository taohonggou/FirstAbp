using FirstABP.Persons.Dto;

namespace FirstABP.Persons
{
    public interface IPersonAppService
    {
        GetCitiesOutput GetList(GetPersonsInput input);

        void CreatePerson(CreatePersonInput input);
    }
}
