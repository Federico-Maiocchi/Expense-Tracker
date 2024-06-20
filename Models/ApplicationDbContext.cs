using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext : DbContext
    {
        //Costruttore Vuoto
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}

        //DbSet transazioni
        public DbSet<Transaction> Transactions { get; set; }

        //DbSet categorie
        public DbSet<Category> Categories { get; set; }

    }
}
