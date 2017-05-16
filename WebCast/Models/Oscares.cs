using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebCast.Models
{
    public class Oscares : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Actor> Actores { get; set; }
    }
}