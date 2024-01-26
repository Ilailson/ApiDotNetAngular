using BackDOT.Models;
using Microsoft.EntityFrameworkCore;

namespace BackDOT.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {  
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}
