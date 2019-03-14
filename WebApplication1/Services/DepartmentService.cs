using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Services
{
    public class DepartmentService
    {
        private readonly WebApplication1Context _context;

        public DepartmentService(WebApplication1Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(dep => dep.Name).ToListAsync(); // o await indica que é uma função assyncrona
        }
    }
}
