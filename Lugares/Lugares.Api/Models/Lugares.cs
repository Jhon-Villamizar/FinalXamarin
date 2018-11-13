using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lugares.Api.Models
{
    [Table("Lugares")]
    public class Lugares
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Lugar { get; set; }
        [Required]
        public string Tipo { get; set; }
        [Required]
        public string Especialidad { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Web { get; set; }
        [Required]
        public string Imagen { get; set; }
        public Array Calificacion { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public object Punto { get; set; }
        public object Horarios { get; set; }
    
    }
}