using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая поставщика в системе управления складом.
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Уникальный идентификатор поставщика.
        /// </summary>
        [Key]
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

        /// <summary>
        /// Адрес поставщика.
        /// </summary>
        public string? AddressSupplier { get; set; }
    }
}
