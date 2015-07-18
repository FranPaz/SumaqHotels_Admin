namespace SumaqHotels_Admin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CamaAdicionals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        PrecioAdicional = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoCamaId = c.Int(nullable: false),
                        TipoHabitacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoCamas", t => t.TipoCamaId, cascadeDelete: true)
                .ForeignKey("dbo.TipoHabitacions", t => t.TipoHabitacionId, cascadeDelete: true)
                .Index(t => t.TipoCamaId)
                .Index(t => t.TipoHabitacionId);
            
            CreateTable(
                "dbo.TipoCamas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoHabitacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        PrecioBase = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlazasBase = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Habitacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NroHab = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Plazas = c.Int(nullable: false),
                        TipoHabitacionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoHabitacions", t => t.TipoHabitacionId, cascadeDelete: true)
                .Index(t => t.TipoHabitacionId);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        CantPisos = c.Int(nullable: false),
                        Telefono = c.String(),
                        CodPostal = c.String(),
                        UrlWeb = c.String(),
                        DireccionComun = c.String(),
                        CategoriaId = c.Int(nullable: false),
                        TipoHotelId = c.Int(nullable: false),
                        GrupoHoteleroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoHoteleroes", t => t.GrupoHoteleroId, cascadeDelete: true)
                .ForeignKey("dbo.TipoHotels", t => t.TipoHotelId, cascadeDelete: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.TipoHotelId)
                .Index(t => t.GrupoHoteleroId);
            
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CantEstrellas = c.Int(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GrupoHoteleroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HotelDireccions",
                c => new
                    {
                        HotelId = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.HotelId)
                .ForeignKey("dbo.Hotels", t => t.HotelId)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.ImagenHotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HotelId = c.Int(nullable: false),
                        Nombre = c.String(),
                        TextoAlt = c.String(),
                        Contenido = c.Binary(),
                        TipoHabitacion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .ForeignKey("dbo.TipoHabitacions", t => t.TipoHabitacion_Id)
                .Index(t => t.HotelId)
                .Index(t => t.TipoHabitacion_Id);
            
            CreateTable(
                "dbo.TipoHotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServicioDeHabitacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImagenTipoHabitacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoHabitacionId = c.Int(nullable: false),
                        Nombre = c.String(),
                        TextoAlt = c.String(),
                        Contenido = c.Binary(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoHabitacions", t => t.TipoHabitacionId, cascadeDelete: true)
                .Index(t => t.TipoHabitacionId);
            
            CreateTable(
                "dbo.ServicioDeHabitacionTipoHabitacions",
                c => new
                    {
                        ServicioDeHabitacion_Id = c.Int(nullable: false),
                        TipoHabitacion_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServicioDeHabitacion_Id, t.TipoHabitacion_Id })
                .ForeignKey("dbo.ServicioDeHabitacions", t => t.ServicioDeHabitacion_Id, cascadeDelete: true)
                .ForeignKey("dbo.TipoHabitacions", t => t.TipoHabitacion_Id, cascadeDelete: true)
                .Index(t => t.ServicioDeHabitacion_Id)
                .Index(t => t.TipoHabitacion_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImagenTipoHabitacions", "TipoHabitacionId", "dbo.TipoHabitacions");
            DropForeignKey("dbo.ServicioDeHabitacionTipoHabitacions", "TipoHabitacion_Id", "dbo.TipoHabitacions");
            DropForeignKey("dbo.ServicioDeHabitacionTipoHabitacions", "ServicioDeHabitacion_Id", "dbo.ServicioDeHabitacions");
            DropForeignKey("dbo.ImagenHotels", "TipoHabitacion_Id", "dbo.TipoHabitacions");
            DropForeignKey("dbo.TipoHabitacions", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "TipoHotelId", "dbo.TipoHotels");
            DropForeignKey("dbo.ImagenHotels", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.HotelDireccions", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "GrupoHoteleroId", "dbo.GrupoHoteleroes");
            DropForeignKey("dbo.Hotels", "CategoriaId", "dbo.Categorias");
            DropForeignKey("dbo.Habitacions", "TipoHabitacionId", "dbo.TipoHabitacions");
            DropForeignKey("dbo.CamaAdicionals", "TipoHabitacionId", "dbo.TipoHabitacions");
            DropForeignKey("dbo.CamaAdicionals", "TipoCamaId", "dbo.TipoCamas");
            DropIndex("dbo.ServicioDeHabitacionTipoHabitacions", new[] { "TipoHabitacion_Id" });
            DropIndex("dbo.ServicioDeHabitacionTipoHabitacions", new[] { "ServicioDeHabitacion_Id" });
            DropIndex("dbo.ImagenTipoHabitacions", new[] { "TipoHabitacionId" });
            DropIndex("dbo.ImagenHotels", new[] { "TipoHabitacion_Id" });
            DropIndex("dbo.ImagenHotels", new[] { "HotelId" });
            DropIndex("dbo.HotelDireccions", new[] { "HotelId" });
            DropIndex("dbo.Hotels", new[] { "GrupoHoteleroId" });
            DropIndex("dbo.Hotels", new[] { "TipoHotelId" });
            DropIndex("dbo.Hotels", new[] { "CategoriaId" });
            DropIndex("dbo.Habitacions", new[] { "TipoHabitacionId" });
            DropIndex("dbo.TipoHabitacions", new[] { "HotelId" });
            DropIndex("dbo.CamaAdicionals", new[] { "TipoHabitacionId" });
            DropIndex("dbo.CamaAdicionals", new[] { "TipoCamaId" });
            DropTable("dbo.ServicioDeHabitacionTipoHabitacions");
            DropTable("dbo.ImagenTipoHabitacions");
            DropTable("dbo.ServicioDeHabitacions");
            DropTable("dbo.TipoHotels");
            DropTable("dbo.ImagenHotels");
            DropTable("dbo.HotelDireccions");
            DropTable("dbo.GrupoHoteleroes");
            DropTable("dbo.Categorias");
            DropTable("dbo.Hotels");
            DropTable("dbo.Habitacions");
            DropTable("dbo.TipoHabitacions");
            DropTable("dbo.TipoCamas");
            DropTable("dbo.CamaAdicionals");
        }
    }
}
