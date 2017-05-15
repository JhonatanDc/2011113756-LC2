using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class CategoriaAlimentacionConfiguration: EntityTypeConfiguration<CategoriaAlimentacion>
    {
        public CategoriaAlimentacionConfiguration()
        {
            //Table Configurations
            ToTable("CategoriaAlimentacion");
            HasKey(c => c.CategoriaAlimentacionId);


            //Relationship Configurations
            //....
        }
    }
}
