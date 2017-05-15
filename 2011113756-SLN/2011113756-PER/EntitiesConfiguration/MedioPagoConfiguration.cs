using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class MedioPagoConfiguration : EntityTypeConfiguration<MedioPago>
    {
        public MedioPagoConfiguration()
        {
            //Table Configurations
            ToTable("MedioPago");
            HasKey(c => c.MedioPagoId);


            //Relationship Configurations
            //....
        }
    }
}
