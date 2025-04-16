using System.ComponentModel.DataAnnotations;

namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая накладную на получение в системе управления складом.
    /// </summary>
    public class ReceiptInvoice
    {
        /// <summary>
        /// Уникальный идентификатор накладной на получение.
        /// </summary>
        [Key]
        public int ReceiptInvoiceId { get; set; }

        /// <summary>
        /// Тип накладной на получение.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Дата и время создания накладной на получение.
        /// </summary>
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Идентификатор продукта, связанного с накладной.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Идентификатор поставщика, связанного с накладной.
        /// </summary>
        public int SupplierId { get; set; }
    }
}
