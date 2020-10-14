using System;
using Microsoft.EntityFrameworkCore;
using ProjetCoreData.Models;

namespace projet_MVC
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions options) : base(options)
        {
        }

        protected DefaultContext()
        {
        }

        public DbSet<Utilisateur> Utilisateur { get; set; }

        //public DbSet<Utilisateur> Utilisateurs { }

    }
}