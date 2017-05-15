namespace _2011113756_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alimentacions",
                c => new
                    {
                        AlimentacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AlimentacionId);
            
            CreateTable(
                "dbo.CalificacionHospedajes",
                c => new
                    {
                        CalificacionHospedajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CalificacionHospedajeId);
            
            CreateTable(
                "dbo.CategoriaAlimentacions",
                c => new
                    {
                        CategoriaAlimentacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaAlimentacionId);
            
            CreateTable(
                "dbo.CategoriaHospedajes",
                c => new
                    {
                        CategoriaHospedajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaHospedajeId);
            
            CreateTable(
                "dbo.CategoriaTransportes",
                c => new
                    {
                        CategoriaTransporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CategoriaTransporteId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.ComprobantePagoes",
                c => new
                    {
                        ComprobantePagoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ComprobantePagoId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Hospedajes",
                c => new
                    {
                        HospedajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.HospedajeId);
            
            CreateTable(
                "dbo.MedioPagoes",
                c => new
                    {
                        MedioPagoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MedioPagoId);
            
            CreateTable(
                "dbo.Paquetes",
                c => new
                    {
                        PaqueteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PaqueteId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PersonaId);
            
            CreateTable(
                "dbo.ServicioHospedajes",
                c => new
                    {
                        ServicioHospedajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ServicioHospedajeId);
            
            CreateTable(
                "dbo.ServicioTuristicoes",
                c => new
                    {
                        ServicioTuristicoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ServicioTuristicoId);
            
            CreateTable(
                "dbo.TipoComprobantes",
                c => new
                    {
                        TipoComprobanteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoComprobanteId);
            
            CreateTable(
                "dbo.TipoHospedajes",
                c => new
                    {
                        TipoHospedajeId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoHospedajeId);
            
            CreateTable(
                "dbo.TipoTransportes",
                c => new
                    {
                        TipoTransporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TipoTransporteId);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        TransporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TransporteId);
            
            CreateTable(
                "dbo.VentaPaquetes",
                c => new
                    {
                        VentaPaqueteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.VentaPaqueteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VentaPaquetes");
            DropTable("dbo.Transportes");
            DropTable("dbo.TipoTransportes");
            DropTable("dbo.TipoHospedajes");
            DropTable("dbo.TipoComprobantes");
            DropTable("dbo.ServicioTuristicoes");
            DropTable("dbo.ServicioHospedajes");
            DropTable("dbo.Personas");
            DropTable("dbo.Paquetes");
            DropTable("dbo.MedioPagoes");
            DropTable("dbo.Hospedajes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.ComprobantePagoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.CategoriaTransportes");
            DropTable("dbo.CategoriaHospedajes");
            DropTable("dbo.CategoriaAlimentacions");
            DropTable("dbo.CalificacionHospedajes");
            DropTable("dbo.Alimentacions");
        }
    }
}
