using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.DTO;

namespace Warehouse_Management_System.Domain.Contracts
{
    public interface IAddingProductDataService
    {
        /// <summary>
        /// Добавляет новую продукцию в базу данных.
        /// </summary>
        /// <param name="productionDto">DTO с данными о продукции.</param>
        /// <returns>Добавленная продукция.</returns>
        Task<Production> AddProductionAsync(ProductionDTO productionDto);

        /// <summary>
        /// Добавляет нового поставщика в базу данных.
        /// </summary>
        /// <param name="supplierDto">DTO с данными о поставщике.</param>
        /// <returns>Добавленный поставщик.</returns>
        Task<Supplier> AddSupplierAsync(SupplierDTO supplierDto);

        /// <summary>
        /// Добавляет новую накладную в базу данных.
        /// </summary>
        /// <param name="receiptInvoiceDto">DTO с данными о накладной.</param>
        /// <param name="supplierId">ID поставщика.</param>
        /// <param name="productId">ID продукции.</param>
        /// <returns>Добавленная накладная.</returns>
        Task<ReceiptInvoice> AddReceiptInvoiceAsync(ReceiptInvoiceDTO receiptInvoiceDto, int supplierId, int productId);
    }
}