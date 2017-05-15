using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class CategoriaTransporteConfiguration : EntityTypeConfiguration<CategoriaTransporte>
    {
        public CategoriaTransporteConfiguration()
        {
            //Table Configurations
            ToTable("CategoriaTransporte");
            HasKey(c => c.CategoriaTransporteId);


            //Relationship Configurations
            //....
        }
    }
}
