using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.Entities
{
    [Table("Cars")]
    public  class Car:Entity
    {
        public virtual Person Person { get; set; }
        public virtual int PersonId { get; set; }
        public virtual CarBrand Brand { get; set; }
        public virtual int Price { get; set; }

        public Car()
        {
        }

        public Car(CarBrand brand, int price)
        {
            Brand = brand;
            Price = price;
        }
    }
}
