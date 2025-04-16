using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTOs
{
    public class ReceiptInvoiceDTO
    {
        /// <summary>
        /// Тип накладной на получение.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Дата и время создания накладной на получение.
        /// </summary>
        public DateTime CreationDateTime { get; set; }
    }
}
