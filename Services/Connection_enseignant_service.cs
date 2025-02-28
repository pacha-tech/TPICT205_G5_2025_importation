using System;
using correction_205.Data;
using correction_205.Models;
using correction_205.Services;
using Microsoft.EntityFrameworkCore;

public class Auth_enseignant_Service
{
    private readonly ApplicationDbContext _context;

    public Auth_enseignant_Service(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> LoginAsync(Enseignant_connection loginModel)
    {
        var enseignant = await _context.Enseignant
            .FirstOrDefaultAsync(e => e.Email == loginModel.Email && e.Password == loginModel.Password);

        return enseignant != null; // retourne true si l'étudiant existe
    }
}