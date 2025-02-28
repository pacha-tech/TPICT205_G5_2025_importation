using System.Collections.Generic;
using System.Threading.Tasks;
using correction_205.Models;
using correction_205.Pages;
using Microsoft.EntityFrameworkCore;

public class Consulter_PVService
{
    private readonly ApplicationDbContext _context;

    public Consulter_PVService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Méthode pour consulter tous les PV
    public async Task<List<Creation_PV1>> ConsulterPV()
    {
        // Récupérer tous les PV depuis la base de données
        return await _context.Creation_PV.ToListAsync();
    }
}