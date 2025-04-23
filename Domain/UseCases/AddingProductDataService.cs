using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.Interfaces;
using Warehouse_Management_System.Domain.Entities;
using System;

namespace Warehouse_Management_System.Domain.UseCases 
{
    public class AddingProductDataService
    {
        private readonly IRepository _repository;

        public AddingProductDataService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Добавляет новую продукцию в базу данных.
        /// </summary>
        /// <param name="productionDto">DTO с данными о продукции.</param>
        /// <returns>Добавленная продукция.</returns>
        public async Task<Production> AddProductionAsync(ProductionDTO productionDto)
        {
            var production = new Production
            {
                Name = productionDto.Name,
                Article = productionDto.Article,
                Category = productionDto.Category,
                Weight = productionDto.Weight,
                Dimensions = productionDto.Dimensions,
                ExpiryDate = DateOnly.FromDateTime(productionDto.ExpiryDate),
                Price = productionDto.Price
            };

            return await _repository.AddProductionAsync(production);
        }

        /// <summary>
        /// Добавляет нового поставщика в базу данных.
        /// </summary>
        /// <param name="supplierDto">DTO с данными о поставщике.</param>
        /// <returns>Добавленный поставщик.</returns>
        public async Task<Supplier> AddSupplierAsync(SupplierDTO supplierDto)
        {
            var supplier = new Supplier
            {
                Name = supplierDto.Name,
                ContactPerson = supplierDto.ContactPerson,
                Phone = supplierDto.Phone,
                AddressSupplier = supplierDto.AddressSupplier
            };

            return await _repository.AddSupplierAsync(supplier);
        }

        /// <summary>
        /// Добавляет новую накладную в базу данных.
        /// </summary>
        /// <param name="receiptInvoiceDto">DTO с данными о накладной.</param>
        /// <param name="supplierId">ID поставщика.</param>
        /// <param name="productId">ID продукции.</param>
        /// <returns>Добавленная накладная.</returns>
        public async Task<ReceiptInvoice> AddReceiptInvoiceAsync(ReceiptInvoiceDTO receiptInvoiceDto, int supplierId, int productId)
        {
            var receiptInvoice = new ReceiptInvoice
            {
                Type = receiptInvoiceDto.Type,
                CreationDateTime = receiptInvoiceDto.CreationDateTime,
                SupplierId = supplierId,
                ProductId = productId
            };

            return await _repository.AddReceiptInvoiceAsync(receiptInvoice);
        }
    }
}
