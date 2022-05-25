using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Required]
        public float precio { get; set; }
        [Required]
        public float ancho { get; set; }
        [Required]
        public float largo { get; set; }
        [Required]
        public float peso { get; set; }
        [Required]
        public int productId { get; set; }
        public Producto producto { get; set; }
    }
}