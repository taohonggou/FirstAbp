using FirstABP.Entities;
using System;
using System.Collections.Generic;
using Abp.EntityFramework;
using FirstABP.IRepositories;
using System.Linq;

namespace FirstABP.EntityFramework.Repositories
{
    public class PersonRepository : FirstABPRepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(IDbContextProvider<FirstABPDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }

        public List<Person> GetListByProvince(int proivnceCode)
        {
            return GetAll().Where(o => o.Province.Id == proivnceCode).ToList();
        }
    }
}
