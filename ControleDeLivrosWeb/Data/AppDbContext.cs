﻿using CadastroDeLivrosWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeLivrosWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
                
        }

        public DbSet<Categoria> Categorias { get; set; } 
    }

}
