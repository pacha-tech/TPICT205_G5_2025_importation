using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace correction_205.Models {
public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Enseignant> Enseignant {  get; set; }
        public DbSet<Creation_PV1> Creation_PV { get; set; }
        public DbSet<Modifier_PV1> Modifier_PV { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etudiant>().ToTable("etudiant"); // Remplacez par le nouveau nom
            modelBuilder.Entity<Enseignant>().ToTable("enseignant");
            modelBuilder.Entity<Enseignant>()
           .HasKey(e => e.id); // Assurez-vous que la cl� est d�finie ici
            modelBuilder.Entity<Creation_PV1>().ToTable("PV");


            modelBuilder.Entity<Creation_PV1>()
            .HasKey(c => c.Code_PV);

            modelBuilder.Entity<Modifier_PV1>()
                .HasKey(m => m.Id);

            modelBuilder.Entity<Modifier_PV1>()
                .HasOne(m => m.PV) // Relation avec Creation_PV1
                .WithMany() // Relation 1 � plusieurs (si n�cessaire)
                .HasForeignKey(m => m.CODE_PV) // Cl� �trang�re
                .HasPrincipalKey(c => c.Code_PV); // Cl� principale de Creation_PV1
            
    }
    }
}