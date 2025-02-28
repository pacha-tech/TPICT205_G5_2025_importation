using correction_205.Models;
using System.Collections.Generic;
using System.Linq;

namespace correction_205.Services
{
    public class Creation_PVService
    {
        private readonly ApplicationDbContext _context;

        public Creation_PVService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddPV(Creation_PV1 creation_pv)
        {
            _context.Creation_PV.Add(creation_pv);
            _context.SaveChanges();
        }

        public IEnumerable<Creation_PV1> GetAllEnseignant()
        {
            return _context.Creation_PV.ToList();
        }
    }
}