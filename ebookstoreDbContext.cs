using ebookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace ebookstore
{
    
    public class ebookstoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbConnection = "Server=localhost;Database=ebookstore;Uid='root';Pwd=12345";
            MySqlServerVersion mySqlServerVersion = new MySqlServerVersion(new Version(8,10,30));
            optionsBuilder.UseMySql(dbConnection, mySqlServerVersion);
        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<Admin> admin { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<CustomerMessage> customerMessages { get; set; }
        public DbSet<Publisher> publishers { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }

    }
}
