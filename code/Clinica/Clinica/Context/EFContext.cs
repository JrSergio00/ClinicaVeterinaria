using Clinica.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clinica.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Clinica")
        {
            Database.SetInitializer<EFContext>(
            new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Consulta> Consultas { get; set; }

        public DbSet<Especie> Especies { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Exame> Exames { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veterinario> Veterinarios{ get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}