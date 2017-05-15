using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class TipoHospedajeConfiguration : EntityTypeConfiguration<TipoHospedaje>
    {
        public TipoHospedajeConfiguration()
        {
            //Table Configurations
            ToTable("TipoHospedaje");
            HasKey(c => c.TipoHospedajeId);


            //Relationship Configurations
            //....
        }
    }
}
