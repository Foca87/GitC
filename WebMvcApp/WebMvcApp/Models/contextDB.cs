using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebMvcApp.Models
{
    public class contextDB : DbContext
    {
        public DbSet<Pessoa> pessoas { get; set; }
        
        public System.Data.Entity.DbSet<WebMvcApp.Models.Carro> Carroes { get; set; } // Lembrar de adicionar. Foi gerado automaticamente.
    }
}