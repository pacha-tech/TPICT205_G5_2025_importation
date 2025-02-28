using correction_205.Models;

public class Supprimer_PVService
{
    private readonly ApplicationDbContext _context;

    public Supprimer_PVService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> SupprimerPV(string codePV)
    {
        var pv = await _context.Creation_PV.FindAsync(codePV);
        if (pv == null) return false;

        _context.Creation_PV.Remove(pv);
        await _context.SaveChangesAsync();
        return true;
    }
}