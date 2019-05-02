using Microsoft.EntityFrameworkCore;

namespace Unicef
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
    }
}