using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Alpaca_Smith.Models
{
    public class Alpaca_SmithContext : DbContext
    {
        public Alpaca_SmithContext() : base("name=Alpaca_SmithContext")
        {

        }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }
    }
}