using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.Interfaces
{
    // Базовый интерфейс репозитория
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
    }

    // Интерфейс для работы с производством
    public interface IProductionRepository : IRepository<Production>
    {
        Task<IEnumerable<Production>> GetProductionsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<Production> GetProductionWithDetailsAsync(int id);
    }

    // Интерфейс для работы с приходными накладными
    public interface IReceiptInvoiceRepository : IRepository<ReceiptInvoice>
    {
        Task<IEnumerable<ReceiptInvoice>> GetInvoicesBySupplierAsync(int supplierId);
        Task<ReceiptInvoice> GetInvoiceWithDetailsAsync(int id);
    }

    // Интерфейс для работы со складскими ячейками
    public interface IStorageCellRepository : IRepository<StorageCell>
    {
        Task<IEnumerable<StorageCell>> GetAvailableCellsAsync();
        Task<StorageCell> GetCellWithContentsAsync(int id);
    }

    // Интерфейс для работы с логистами
    public interface IStorageLogistRepository : IRepository<StorageLogist>
    {
        Task<IEnumerable<StorageLogist>> GetLogistsByShiftAsync(string shift);
        Task<StorageLogist> GetLogistWithTasksAsync(int id);
    }

    // Интерфейс для работы с менеджерами склада
    public interface IStorageManagerRepository : IRepository<StorageManager>
    {
        Task<IEnumerable<StorageManager>> GetManagersByDepartmentAsync(string department);
        Task<StorageManager> GetManagerWithResponsibilitiesAsync(int id);
    }

    // Интерфейс для работы с поставщиками
    public interface ISupplierRepository : IRepository<Supplier>
    {
        Task<IEnumerable<Supplier>> GetActiveSuppliersAsync();
        Task<Supplier> GetSupplierWithInvoicesAsync(int id);
    }

    // Интерфейс для работы с выполненными инструкциями
    public interface ICompletedInstructionRepository : IRepository<CompletedInstruction>
    {
        Task<IEnumerable<CompletedInstruction>> GetCompletedInstructionsByDateAsync(DateTime date);
        Task<CompletedInstruction> GetCompletedInstructionWithDetailsAsync(int id);
    }

    // Интерфейс для работы с текущими инструкциями
    public interface ICurrentInstructionRepository : IRepository<CurrentInstruction>
    {
        Task<IEnumerable<CurrentInstruction>> GetActiveInstructionsAsync();
        Task<CurrentInstruction> GetCurrentInstructionWithDetailsAsync(int id);
    }

    // Интерфейс для работы с единицами измерения
    public interface IUnitRepository : IRepository<Unit>
    {
        Task<Unit> GetUnitByNameAsync(string name);
        Task<IEnumerable<Unit>> GetUnitsByTypeAsync(string type);
    }

    // Интерфейс для работы с категориями
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<IEnumerable<Category>> GetCategoriesWithProductsAsync();
        Task<Category> GetCategoryWithProductsAsync(int id);
    }

    // Интерфейс для работы с продуктами
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(int categoryId);
        Task<Product> GetProductWithDetailsAsync(int id);
        Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
    }

    // Интерфейс для работы со складами
    public interface IWarehouseRepository : IRepository<Warehouse>
    {
        Task<IEnumerable<Warehouse>> GetWarehousesByLocationAsync(string location);
        Task<Warehouse> GetWarehouseWithStockAsync(int id);
    }

    // Интерфейс для работы с запасами
    public interface IStockRepository : IRepository<Stock>
    {
        Task<IEnumerable<Stock>> GetStockByWarehouseAsync(int warehouseId);
        Task<Stock> GetStockByProductAndWarehouseAsync(int productId, int warehouseId);
        Task<IEnumerable<Stock>> GetLowStockItemsAsync(int threshold);
    }

    // Интерфейс для работы с транзакциями
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<IEnumerable<Transaction>> GetTransactionsByDateRangeAsync(DateTime startDate, DateTime endDate);
        Task<IEnumerable<Transaction>> GetTransactionsByTypeAsync(string type);
        Task<Transaction> GetTransactionWithDetailsAsync(int id);
    }
} 