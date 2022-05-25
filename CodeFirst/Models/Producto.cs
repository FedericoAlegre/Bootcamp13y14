using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Producto
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string categoria { get; set; }
        [Required]
        public DateTime FechaBaja { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
    }
}