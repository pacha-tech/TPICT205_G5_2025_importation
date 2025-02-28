using correction_205.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace correction_205.Services
{
    public class EtudiantService
    {
        private readonly ApplicationDbContext _context;

        public EtudiantService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddEtudiant(Etudiant etudiant)
        {
            var existingEtudiant = await _context.Etudiants
       .FirstOrDefaultAsync(e => e.Matricule == etudiant.Matricule);

            if (existingEtudiant != null)
            {
                throw new InvalidOperationException("Le matricule existe déjà.");
            }

            _context.Etudiants.Add(etudiant);
            _context.SaveChanges();
        }

        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return _context.Etudiants.ToList();
        }
        public Etudiant GetEtudiantByMatricule(string matricule)
        {
            return _context.Etudiants.FirstOrDefault(e => e.Matricule == matricule);
        }
    }
}