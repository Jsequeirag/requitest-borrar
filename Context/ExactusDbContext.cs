using Microsoft.EntityFrameworkCore;
using requitools_be.Entities;

namespace requitools_be.Context
{
    public class ExactusDbContext: DbContext
    {
        public ExactusDbContext(DbContextOptions<ExactusDbContext> options) : base(options)
        {

        }
   
    }
}
