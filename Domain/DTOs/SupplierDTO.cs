using System.ComponentModel.DataAnnotations;
using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTOs
{
    public class SupplierDTO
    {
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

        /// <summary>
        /// Адрес поставщика.
        /// </summary>
        public string? AddressSupplier { get; set; }
    }
}
