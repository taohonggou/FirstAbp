﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstABP.IRepositories;
using Abp.AutoMapper;

namespace FirstABP.Persons.Dto
{
    public class PersonAppService : FirstABPAppServiceBase, IPersonAppService
    {
        private IPersonRepository _personRepository;

        public PersonAppService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public GetCitiesOutput GetList(GetPersonsInput input)
        {
            
            if (input.Name != null)
            {
                var lsit = _personRepository.GetAllList(o => o.Name == input.Name);
                return new GetCitiesOutput
                {
                    Persons = lsit.MapTo<List<PersonDto>>()
                };
            }
            else
            {
                return new GetCitiesOutput();
            }
        }
    }
}
