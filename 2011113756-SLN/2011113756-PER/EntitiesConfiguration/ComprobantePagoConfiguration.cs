using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class ComprobantePagoConfiguration : EntityTypeConfiguration<ComprobantePago>
    {
        public ComprobantePagoConfiguration()
        {
            //Table Configurations
            ToTable("ComprobantePago");
            HasKey(c => c.ComprobantePagoId);


            //Relationship Configurations
            //....
        }
    }
}
