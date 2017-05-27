using Abp.WebApi.OData.Controllers;
using FirstABP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace FirstABP.Api.Controllers
{
    public class PersonsController : AbpODataEntityController<Person>
    {
        public PersonsController(IRepository<Person> repository) : base(repository)
        {
        }
    }
}
