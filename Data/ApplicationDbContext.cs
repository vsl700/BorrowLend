using BorrowLend.Models;
using Microsoft.EntityFrameworkCore;

namespace BorrowLend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<Expense> Expenses { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
