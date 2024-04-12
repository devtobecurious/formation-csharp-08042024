using Microsoft.EntityFrameworkCore;

namespace DecouverteLinq
{
    /// <summary>
    ///  C'est un ORM
    /// </summary>
    internal class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }

        protected DefaultDbContext()
        {
        }

        public DbSet<Wookiee> Wookiees { get; set; } // Par convention : nom de la propriété = nom de la table en base de données
    }
}
