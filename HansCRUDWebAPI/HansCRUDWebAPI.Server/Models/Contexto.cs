// Rafael Hassegawa - 20/02/2024
// 2nd step - creating my context

using Microsoft.EntityFrameworkCore;

namespace HansCRUDWebAPI.Server.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes) 
        { 

        }
    }
}
