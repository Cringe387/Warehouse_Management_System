using System.ComponentModel.DataAnnotations;

namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая накладную на получение в системе управления складом.
    /// </summary>
    public class ReceiptInvoiceSupplier
    {
        /// <summary>
        /// Уникальный идентификатор накладной на получение.
        /// </summary>
        [Key]
        public int ReceiptInvoiceId { get; set; }

        /// <summary>
        /// Идентификатор продукта, связанного с накладной.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Дата и время создания накладной на получение.
        /// </summary>
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Идентификатор поставщика, связанного с накладной.
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// Название поставщика.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Контактное лицо поставщика.
        /// </summary>
        public string? ContactPerson { get; set; }

        /// <summary>
        /// Телефон поставщика.
        /// </summary>
        public string? Phone { get; set; }
    }
}
