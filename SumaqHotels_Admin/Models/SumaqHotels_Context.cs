﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SumaqHotels_Admin.Models
{
    public class SumaqHotels_Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SumaqHotels_Context() : base("name=SumaqHotels_Context")
        {
            this.Configuration.LazyLoadingEnabled = false; //desactivo el lazy loading para llamar explicitamente los objetos asociados a propiedades de navegacion
            this.Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer<SumaqHotels_Context>(new SumaqHotelsDbInitialier());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<SumaqHotels_Context,SumaqHotels_Admin.Migrations.Configuration>());
        }

        #region definicion de tablas dbset
        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.Hotel> Hoteles { get; set; }

        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.GrupoHotelero> GruposHoteleros { get; set; }

        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.HotelDireccion> HotelesDireccion { get; set; }

        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.TipoHotel> TipoHoteles { get; set; }

        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.Habitacion> Habitaciones { get; set; }

        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.TipoHabitacion> TiposHabitaciones { get; set; }
        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.ServicioDeHabitacion> ServiciosDeHabitacion { get; set; }
        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.CamaAdicional> CamasAdicionales { get; set; }
        public System.Data.Entity.DbSet<SumaqHotels_Admin.Models.TipoCama> TiposCamas { get; set; }
		public DbSet<SumaqHotels_Admin.Models.ImagenHotel> ImagenesHotel { get; set; }
        public DbSet<SumaqHotels_Admin.Models.ImagenTipoHabitacion> ImagenesTipoHabitacion { get; set; }
        #endregion
    }

    public class SumaqHotelsDbInitialier : DropCreateDatabaseAlways<SumaqHotels_Context>
    {
        protected override void Seed(SumaqHotels_Context context) // fpaz: semilla para el llenado automatico de la BD
        {
            #region Semilla de Categorias de Hoteles
            var listCategorias = new List<Categoria>
                {
                    new Categoria { CantEstrellas = 1, Descripcion="Hoteles 1 Estrella"},                     
                    new Categoria { CantEstrellas = 2, Descripcion="Hoteles 2 Estrellas"},
                    new Categoria { CantEstrellas = 3, Descripcion="Hoteles 3 Estrellas"},
                    new Categoria { CantEstrellas = 4, Descripcion="Hoteles 4 Estrellas"},
                    new Categoria { CantEstrellas = 5, Descripcion="Hoteles 5 Estrellas"}
                };
            foreach (var item in listCategorias)
            {
                context.Categorias.Add(item);
            }
            #endregion

            #region Semilla de los Tipos de Hoteles
            var tiposHoteles = new List<TipoHotel>
                {
                    new TipoHotel { Nombre="Urbano", Descripcion="descripcion temporal"},
                    new TipoHotel { Nombre="Spa & Resort", Descripcion="descripcion temporal"},
                    new TipoHotel { Nombre="Apart Hotel", Descripcion="descripcion temporal"},
                    new TipoHotel { Nombre="Posada", Descripcion="descripcion temporal"},
                    new TipoHotel { Nombre="Hotel Casino", Descripcion="descripcion temporal"}
                };
            foreach (var item in tiposHoteles)
            {
                context.TipoHoteles.Add(item);
            }
            #endregion

            #region Semilla de los Servicios de Habitacion por defecto
            var listServicios = new List<ServicioDeHabitacion>
                {
                    new ServicioDeHabitacion { Nombre="Baño Privado",Descripcion="descripcion temporal"},                    
                    new ServicioDeHabitacion { Nombre="Aire Acondicionado",Descripcion="descripcion temporal"},                    
                    new ServicioDeHabitacion { Nombre="Tv por Cable",Descripcion="descripcion temporal"},                    
                    new ServicioDeHabitacion { Nombre="Wifi",Descripcion="descripcion temporal"},                    
                    new ServicioDeHabitacion { Nombre="Frigobar",Descripcion="descripcion temporal"},                    
                };
            foreach (var item in listServicios)
            {
                context.ServiciosDeHabitacion.Add(item);
            }
            #endregion

            #region Semilla de los Tipos de Camas
            var tiposCamas = new List<TipoCama>
                {
                    new TipoCama { Nombre="1 Plaza", Descripcion="Cama de 1 Plaza"},
                    new TipoCama { Nombre="2 Plazas", Descripcion="Cama de 2 Plazas"},
                    new TipoCama { Nombre="2 Plazas Queen Size", Descripcion="Cama de 2 Plazas Queen Size"},
                    new TipoCama { Nombre="2 Plazas King Size", Descripcion="Cama de 2 Plazas King Size"}
                };
            foreach (var item in tiposCamas)
            {
                context.TiposCamas.Add(item);
            }
            #endregion            

            base.Seed(context);
        }
    }
}
