using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alpaca_Smith.Models
{
    /// 3 barras para comentar
    
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Imagen { get; set; }
        public string Titulo { get; set; }
        public string Precio { get; set; }
        public string Descripcion { get; set; }
    }
}