using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.EntityFramework.TableMap
{
    public class PersonMap : EntityTypeConfiguration<PersonMap>
    {
        public PersonMap()
        {
            ToTable("Person");
        }
    }
}
