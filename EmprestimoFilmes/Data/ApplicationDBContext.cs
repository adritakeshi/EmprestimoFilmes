using EmprestimoFilmes.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoFilmes.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {
        }

        public DbSet<EmprestimosModel> Emprestimos { get; set; }
    }
}
