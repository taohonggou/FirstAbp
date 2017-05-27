using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace FirstABP.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class Person : Entity
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 这个人所属的省份
        /// </summary>
        public virtual Province Province { get; set; }

        public virtual ICollection<Car> Cars { get; set; }

        public Person() { }

        public Person(string name,params Car[] cars)
        {
            Name = name;
            if (cars != null)
            {
                Cars = new Collection<Car>();
                foreach (var item in cars)
                {
                    item.Person = this;
                    Cars.Add(item);
                }
            }
           


        }
    }
}
