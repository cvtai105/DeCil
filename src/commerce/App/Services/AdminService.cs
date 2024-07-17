using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using App.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Services
{
    public class AdminService
    {
        private readonly AppDbContext _context;

        public AdminService( AppDbContext context)
        {
            _context = context;
        }

        public async Task<Admin?> FindByEmailAsync(string email)
        {
            return await _context.Admins.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}