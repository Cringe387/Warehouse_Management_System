using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class ReceiptInvoiceDTO
    {
        public string? Type { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

        public ReceiptInvoice ConvertToReceiptInvoice()
        {
            return new ReceiptInvoice()
            {
                Type = Type,
                CreationDateTime = CreationDateTime,
                ProductId = ProductId,
                SupplierId = SupplierId,
            };
        }

        public static ReceiptInvoiceDTO FromReceiptInvoice(ReceiptInvoice receiptInvoice)
        {
            return new ReceiptInvoiceDTO
            {
                Type = receiptInvoice.Type,
                CreationDateTime = receiptInvoice.CreationDateTime,
                ProductId = receiptInvoice.ProductId,
                SupplierId = receiptInvoice.SupplierId,
            };
        }
    }
}
