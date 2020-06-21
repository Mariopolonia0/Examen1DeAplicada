using Examen1DeAplicada1.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1DeAplicada1.DAL
{
    public class Contexto :DbContext
    {
        public DbSet <Articulos> Articulos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Data\BDExamen1.db");
        }        
    }
}
