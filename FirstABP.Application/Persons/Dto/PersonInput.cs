using Abp.Runtime.Validation;
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

    /// <summary>
    /// 创建用户
    /// </summary>
    public class CreatePersonInput : IShouldNormalize, ICustomValidate
    {
        [Required]
        public string Name { get; set; }

        public DateTime? CreateDate { get; set; }

        public void AddValidationErrors(CustomValidationContext context)
        {
            if (Name.Length < 2)
            {
                context.Results.Add(new ValidationResult("名字太短了"));
            }

        }

        public void Normalize()
        {
            if (!CreateDate.HasValue)
            {
                CreateDate = DateTime.Now;
            }
        }
    }
}
