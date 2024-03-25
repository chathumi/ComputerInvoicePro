using ComputerInvoicePro.Model;
using Microsoft.EntityFrameworkCore;

namespace ComputerInvoicePro.Data
{
    public class ComputerInvoiceDbContext : DbContext
    {
        public ComputerInvoiceDbContext(DbContextOptions<ComputerInvoiceDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }
    }
}
