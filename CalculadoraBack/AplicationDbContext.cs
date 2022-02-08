using CalculadoraBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraBack
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<History> history { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        { 
        }
    }
}
