using correction_205.Data;
using correction_205.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace correction_205.Services
{
    public class Modifier_PVService
    {
        /*
        private readonly ApplicationDbContext _context;

        public Modifier_PVService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Modifier_PV1>> GetAllPVsAsync()
        {
            return await _context.PV.ToListAsync();
        }

        public async Task<Modifier_PV1> GetPVAsync(string code)
        {
            return await _context.PV.FirstOrDefaultAsync(p => p.CODE_PV.Equals(code, StringComparison.OrdinalIgnoreCase));
        }

        public async Task UpdatePVAsync(Modifier_PV1 updatedPV)
        {
            var existingPV = await _context.PV.FindAsync(updatedPV.CODE_PV);
            if (existingPV != null)
            {
                existingPV.Nom_PV = updatedPV.Nom_PV;
                existingPV.Nom_UE = updatedPV.Nom_UE;
                existingPV.Nom_prof = updatedPV.Nom_prof;

                await _context.SaveChangesAsync();
            }
        }
        public async Task<Modifier_PV1> GetPVByCodeAsync(string codePV)
        {
            return await _context.PV.FindAsync(codePV);
        }
    }
        */
        private readonly ApplicationDbContext _context;

        public Modifier_PVService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ModifierPV(Modifier_PV1 modifierPV)
        {
            // Vérifiez si le PV existe en utilisant CODE_PV
            var pv = await _context.Creation_PV.FindAsync(modifierPV.CODE_PV);
            if (pv == null) return false;

            // Appliquez les modifications
            if (!string.IsNullOrEmpty(modifierPV.Nom_PV))
                pv.Nom_PV = modifierPV.Nom_PV;
            if (!string.IsNullOrEmpty(modifierPV.Nom_UE))
                pv.Nom_UE = modifierPV.Nom_UE;
            if (!string.IsNullOrEmpty(modifierPV.Nom_prof))
                pv.Nom_prof = modifierPV.Nom_prof;

            // Enregistrez les modifications
            await _context.SaveChangesAsync();
            return true;
        }
    }
    }