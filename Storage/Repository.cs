using Warehouse_Management_System.Domain;
using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Numerics;


namespace Warehouse_Management_System.Storage;

public class Repository(ApplicationDbContext _context) : IRepository
{
    public async Task<List<Production>> GetAllProdAsync() =>
            await _context.Productions.ToListAsync();

    public async Task<Production?> GetProductionById(int id) =>
        await _context.Productions.FirstOrDefaultAsync(production => production.ProductId == id);

    public async Task<Production> AddProductionAsync(Production newProduction)
    {
        _context.Productions.Add(newProduction);
        await _context.SaveChangesAsync();

        return newProduction;
    }

    public async Task<Production> UpdateProductionAsync(Production updateProduction)
    {
        _context.Attach(updateProduction);
        await _context.SaveChangesAsync();

        return updateProduction;
    }

    public async Task<int> RemoveProductionAsync(int productionId)
    {
        var production = await _context.Productions.FindAsync(productionId);

        _context.Productions.Remove(production);
        await _context.SaveChangesAsync();

        return productionId;
    }

    public async Task<List<StorageCell>> GetAllCellsAsync() =>
           await _context.StorageCells.ToListAsync();

    public async Task<StorageCell?> GetCellsById(int id) =>
        await _context.StorageCells.FirstOrDefaultAsync(cells => cells.StorageCellId == id);


    public async Task<List<int>> GetCellIdNoOccupiedAsync(StorageCell cells)
    {
        var cellsOccupied = await _context.StorageCells
                                                       .Where(c => c.StorageCellId == cells.StorageCellId && cells.Occupied == false)
                                                       .Select(c => c.StorageCellId)
                                                       .ToListAsync();
        return cellsOccupied;
    }

    public async Task<StorageLogist?> GetStorageLogistByLoginAsync(string login) =>
        await _context.StorageLogists.FirstOrDefaultAsync(storageLogist => storageLogist.Login == login);

    public async Task<StorageLogist> AddStorageLogistAsync(StorageLogist newStorageLogist)
    {
        _context.StorageLogists.Add(newStorageLogist);
        await _context.SaveChangesAsync();

        return newStorageLogist;
    }

    public async Task<StorageLogist> UpdateStorageLogistAsync(StorageLogist updateStorageLogist)
    {
        _context.Attach(updateStorageLogist);
        await _context.SaveChangesAsync();

        return updateStorageLogist;
    }

    public async Task<int> RemoveStorageLogist(int storageLogistId)
    {
        var storageLosist = await _context.StorageLogists.FindAsync(storageLogistId);

        _context.StorageLogists.Remove(storageLosist);
        await _context.SaveChangesAsync();

        return storageLogistId;
    }

    public async Task<StorageManager?> GetStorageManagerByLoginAsync(string login) =>
        await _context.StorageManagers.FirstOrDefaultAsync(storageManager => storageManager.Login == login);


    public async Task<StorageManager> AddStorageManagerAsync(StorageManager newStorageManager)
    {
        _context.StorageManagers.Add(newStorageManager);
        await _context.SaveChangesAsync();

        return newStorageManager;
    }

    public async Task<StorageManager> UpdateStorageManagerAsync(StorageManager updateStorageManager)
    {
        _context.Attach(updateStorageManager);
        await _context.SaveChangesAsync();

        return updateStorageManager;
    }

    public async Task<int> RemoveStorageManager(int storageManagerId)
    {
        var storageManager = await _context.StorageManagers.FindAsync(storageManagerId);

        _context.StorageManagers.Remove(storageManager);
        await _context.SaveChangesAsync();

        return storageManagerId;
    }

    public async Task<List<CurrentInstruction>> GetAllCurrentInstruction() =>
            await _context.CurrentInstructions.ToListAsync();

    public async Task<CurrentInstruction?> GetCurrentInstructionById(int id) =>
        await _context.CurrentInstructions.FirstOrDefaultAsync(сurrentInstruction => сurrentInstruction.CurrentInstructionId == id);

    public async Task<CurrentInstruction> AddCurrentInstructionAsync(CurrentInstruction newСurrentInstruction)
    {
        _context.CurrentInstructions.Add(newСurrentInstruction);
        await _context.SaveChangesAsync();

        return newСurrentInstruction;
    }

    public async Task<CurrentInstruction> UpdateCurrentInstructionAsync(CurrentInstruction updateCurrentInstruction)
    {
        _context.Attach(updateCurrentInstruction);
        await _context.SaveChangesAsync();

        return updateCurrentInstruction;
    }

    public async Task<int> RemoveCurrentInstructionAsync(int currentInstructionId)
    {
        var currentInstruction = await _context.CurrentInstructions.FindAsync(currentInstructionId);

        _context.CurrentInstructions.Remove(currentInstruction);
        await _context.SaveChangesAsync();

        return currentInstructionId;
    }

    public async Task<List<CompletedInstruction>> GetAllCompletedInstruction() =>
            await _context.CompletedInstructions.ToListAsync();

    public async Task<CompletedInstruction?> GetCompletedInstructionById(int id) =>
        await _context.CompletedInstructions.FirstOrDefaultAsync(completedInstruction => completedInstruction.CompletedInstructionId == id);

    public async Task<CompletedInstruction> AddCompletedInstructionAsync(CompletedInstruction newCompletedInstruction)
    {
        _context.CompletedInstructions.Add(newCompletedInstruction);
        await _context.SaveChangesAsync();

        return newCompletedInstruction;
    }

    public async Task<CompletedInstruction> UpdateCompletedInstructionAsync(CompletedInstruction updateCompletedInstruction)
    {
        _context.Attach(updateCompletedInstruction);
        await _context.SaveChangesAsync();

        return updateCompletedInstruction;
    }

    public async Task<int> RemoveCompletedInstructionAsync(int completedInstructionId)
    {
        var completedInstruction = await _context.CompletedInstructions.FindAsync(completedInstructionId);

        _context.CompletedInstructions.Remove(completedInstruction);
        await _context.SaveChangesAsync();

        return completedInstructionId;
    }

    public async Task<List<ReceiptInvoiceSupplier>> GetInvoiceSupplierAsync(ReceiptInvoice receiptInvoice)
    {
        var invoiceSupplier = await _context.ReceiptInvoices.Join(_context.Suppliers,
            ri => ri.SupplierId,
            s => s.SupplierId,
            (ri, s) => new ReceiptInvoiceSupplier
            {
                ReceiptInvoiceId = ri.ReceiptInvoiceId,
                ProductId = ri.ProductId,
                CreationDateTime = ri.CreationDateTime,
                SupplierId = s.SupplierId,
                Name = s.Name,
                ContactPerson = s.ContactPerson,
                Phone = s.Phone
            }).ToListAsync();
        return invoiceSupplier;
    }

    public async Task<List<ProductionCell>> GetProductionCell(Production production)
    {
        var productionCell = await _context.Productions.Join(_context.StorageCells,
            pr => pr.ProductId,
            c => c.ProductId,
            (pr, c) => new ProductionCell
            {
                ProductId = pr.ProductId,
                NameProduction = pr.Name,
                StorageCellId = c.StorageCellId,
                NameCell = c.Name,
                Type = c.Type,
                Zone = c.Zone,
                Capacity = c.Capacity,
                CurrentQuantity = c.CurrentQuantity
            }).ToListAsync();
        return productionCell;
    }
}
