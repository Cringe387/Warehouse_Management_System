using Microsoft.EntityFrameworkCore;
using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Storage
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Production> Productions { get; set; }
        public DbSet<ReceiptInvoice> ReceiptInvoices { get; set; }
        public DbSet<StorageCell> StorageCells { get; set; }
        public DbSet<StorageLogist> StorageLogists { get; set; }
        public DbSet<StorageManager> StorageManagers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<CompletedInstruction> CompletedInstructions { get; set; }
        public DbSet<CurrentInstruction> CurrentInstructions { get; set; }

    }
} 