using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Entities
{
    public class ProfessorDbContext:DbContext
    {
        public ProfessorDbContext(DbContextOptions<ProfessorDbContext> options) : base(options)
        {
            
        }
        public DbSet<Professor> professors { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}
