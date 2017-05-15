using _2011113756_ENT;
using _2011113756_PER.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2011113756_PER
{
    public class PaqueteTuristicoDbContext : DbContext
    {

        public DbSet<Alimentacion> alimentacion { get; set; }
        public DbSet<CalificacionHospedaje> calificacionHospedaje { get; set; }
        public DbSet<CategoriaAlimentacion> categoriaAlimentacion { get; set; }
        public DbSet<CategoriaHospedaje> categoriaHospedaje { get; set; }
        public DbSet<CategoriaTransporte> categoriaTransporte { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<ComprobantePago> comprobantePago { get; set; }
        public DbSet<Empleado> empleado { get; set; }
        public DbSet<Hospedaje> hospedaje { get; set; }
        public DbSet<MedioPago> medioPago { get; set; }
        public DbSet<Paquete> paquete { get; set; }
        public DbSet<Persona> persona { get; set; }
        public DbSet<ServicioHospedaje> servicioHospedaje { get; set; }
        public DbSet<ServicioTuristico> servicioTuristico { get; set; }
        public DbSet<TipoComprobante> tipoComprobante { get; set; }
        public DbSet<TipoHospedaje> tipoHospedaje { get; set; }
        public DbSet<TipoTransporte> tipoTransporte { get; set; }
        public DbSet<Transporte> transporte { get; set; }
        public DbSet<VentaPaquete> ventaPaquete { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlimentacionConfiguration());
            modelBuilder.Configurations.Add(new CalificacionHospedajeConfiguration());
            modelBuilder.Configurations.Add(new CategoriaAlimentacionConfiguration());
            modelBuilder.Configurations.Add(new CategoriaHospedajeConfiguration());
            modelBuilder.Configurations.Add(new CategoriaTransporteConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ComprobantePagoConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new HospedajeConfiguration());
            modelBuilder.Configurations.Add(new MedioPagoConfiguration());
            modelBuilder.Configurations.Add(new PaqueteConfiguration());
            modelBuilder.Configurations.Add(new PersonaConfiguration());
            modelBuilder.Configurations.Add(new ServicioHospedajeConfiguration());
            modelBuilder.Configurations.Add(new ServicioTuristicoConfiguration());
            modelBuilder.Configurations.Add(new TipoComprobanteConfiguration());
            modelBuilder.Configurations.Add(new TipoHospedajeConfiguration());
            modelBuilder.Configurations.Add(new TipoTransporteConfiguration());
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new VentaPaqueteConfiguration());

















            base.OnModelCreating(modelBuilder);
        }





    }
}
