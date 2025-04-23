using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.UseCases;
using System.Threading.Tasks;
using Warehouse_Management_System.Domain.Contracts;

namespace Warehouse_Management_System.Services
{
    public class AddingProductService
    {
        private readonly IAddingProductDataService _addingProductDataService;

        public AddingProductService(IAddingProductDataService addingProductDataService)
        {
            _addingProductDataService = addingProductDataService;
        }

        /// <summary>
        /// Добавляет новую продукцию.
        /// </summary>
        /// <param name="productionDto">DTO с данными о продукции.</param>
        /// <returns>Результат добавления продукции.</returns>
        public async Task<string> AddProductionAsync(ProductionDTO productionDto)
        {
            if (productionDto == null)
            {
                return "Данные о продукции не могут быть пустыми.";
            }

            var addedProduction = await _addingProductDataService.AddProductionAsync(productionDto);
            return addedProduction != null ? "Продукция успешно добавлена." : "Ошибка добавления продукции.";
        }

        /// <summary>
        /// Добавляет нового поставщика.
        /// </summary>
        /// <param name="supplierDto">DTO с данными о поставщике.</param>
        /// <returns>Результат добавления поставщика.</returns>
        public async Task<string> AddSupplierAsync(SupplierDTO supplierDto)
        {
            if (supplierDto == null)
            {
                return "Данные о поставщике не могут быть пустыми.";
            }

            var addedSupplier = await _addingProductDataService.AddSupplierAsync(supplierDto);
            return addedSupplier != null ? "Поставщик успешно добавлен." : "Ошибка добавления поставщика.";
        }

        /// <summary>
        /// Добавляет новую накладную.
        /// </summary>
        /// <param name="receiptInvoiceDto">DTO с данными о накладной.</param>
        /// <param name="supplierId">ID поставщика.</param>
        /// <param name="productId">ID продукции.</param>
        /// <returns>Результат добавления накладной.</returns>
        public async Task<string> AddReceiptInvoiceAsync(ReceiptInvoiceDTO receiptInvoiceDto, int supplierId, int productId)
        {
            if (receiptInvoiceDto == null)
            {
                return "Данные о накладной не могут быть пустыми.";
            }

            var addedReceiptInvoice = await _addingProductDataService.AddReceiptInvoiceAsync(receiptInvoiceDto, supplierId, productId);
            return addedReceiptInvoice != null ? "Накладная успешно добавлена." : "Ошибка добавления накладной.";
        }
    }
}