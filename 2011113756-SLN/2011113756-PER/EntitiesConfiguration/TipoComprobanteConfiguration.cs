using _2011113756_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER.EntitiesConfiguration
{
    public class TipoComprobanteConfiguration :EntityTypeConfiguration<TipoComprobante>
    {
        public TipoComprobanteConfiguration()
        {
            //Table Configurations
            ToTable("TipoComprobante");
            HasKey(c => c.TipoComprobanteId);


            //Relationship Configurations
            //....
        }
    }
}
