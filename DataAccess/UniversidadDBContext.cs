using Microsoft.EntityFrameworkCore;
using Universidad.Models.DataModels;

namespace Universidad.DataAccess
{
    public class UniverdidadDBContext : DbContext
    {
        public UniverdidadDBContext(DbContextOptions<UniverdidadDBContext> options) : base(options)
        {
            //TODO:Add Dbsets(Tablas de nuestra BD)
        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
    }
}
