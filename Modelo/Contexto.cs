using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CadastroDesktop.Modelo
{
    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.CpfCnpj)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Cep)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Limite)
                .HasPrecision(19, 2);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefone)
                .IsUnicode(false);
        }
    }
}
