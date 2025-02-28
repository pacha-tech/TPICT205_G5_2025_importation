using correction_205.Models;
using System.Collections.Generic;
using System.Linq;

namespace correction_205.Services
{
    public class EnseignantService
    {
        private readonly ApplicationDbContext _context;

        public EnseignantService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddEnseignant(Enseignant enseignant)
        {
            _context.Enseignant.Add(enseignant);
            _context.SaveChanges();
        }

        public IEnumerable<Enseignant> GetAllEnseignant()
        {
            return _context.Enseignant.ToList();
        }
    }
}