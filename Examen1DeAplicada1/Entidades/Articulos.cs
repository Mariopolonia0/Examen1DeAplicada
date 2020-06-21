using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Examen1DeAplicada1.Entidades
{
    public class Articulos
    {
        [Key]
        public int productoId { get; set; }
        public string descripcion  { get; set; }
        public string existencia  { get; set; }
        public double costo { get; set; }
        public int valorInventario { get; set; }
         
    }
}
