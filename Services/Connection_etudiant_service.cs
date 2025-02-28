using System;
using correction_205.Data;
using correction_205.Models;
using correction_205.Services;
using Microsoft.EntityFrameworkCore;

public class Auth_etudiant_Service
{
    private readonly ApplicationDbContext _context;

    public Auth_etudiant_Service(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> LoginAsync(Etudiant_connection loginModel)
    {
        var etudiant = await _context.Etudiants
            .FirstOrDefaultAsync(e => e.Matricule == loginModel.Matricule && e.Password == loginModel.Password);

        return etudiant != null; // retourne true si l'étudiant existe
    }
}