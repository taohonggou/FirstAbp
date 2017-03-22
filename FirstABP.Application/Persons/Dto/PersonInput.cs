using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Persons.Dto
{
    public class GetPersonsInput 
    {
        [Required]
        public string Name { get; set; }
    }


}
