using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class TransporteConfiguration : EntityTypeConfiguration<Transporte>
    {
        public TransporteConfiguration()
        {
            //Table Configurations
            ToTable("Transporte");
            HasKey(c => c.TransporteId);


            //Relationship Configurations
            //....
        }
    }
}
