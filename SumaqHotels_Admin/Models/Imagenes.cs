using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SumaqHotels_Admin.Models
{
    public abstract class Imagen
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TextoAlt { get; set; }
        public byte[] Contenido { get; set; }
        
    }

    public class ImagenHotel:Imagen
    {
        // 1 a M con Hotel (uno)
        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }

    public class ImagenTipoHabitacion:Imagen
    {
        //1 a M con Tipo Habitacion (uno)
        public int TipoHabitacionId { get; set; }
        public virtual TipoHabitacion TipoHabitacion { get; set; }
        
    }
}