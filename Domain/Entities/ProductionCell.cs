using System.ComponentModel.DataAnnotations;

namespace Warehouse_Management_System.Domain.Entities
{
    public class ProductionCell
    {
        /// <summary>
        /// Уникальный идентификатор продукта.
        /// </summary>
        [Key]
        public int ProductId { get; set; }

        /// <summary>Warehouse_management_system
        /// Название продукта.
        /// </summary>
        public string? NameProduction { get; set; }

        // <summary>
        /// Уникальный идентификатор ячейки хранения.
        /// </summary>
        public int StorageCellId { get; set; }

        /// <summary>
        /// Название ячейки хранения.
        /// </summary>
        public string? NameCell { get; set; }

        /// <summary>
        /// Тип ячейки хранения.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Зона, в которой расположена ячейка хранения.
        /// </summary>
        public string? Zone { get; set; }

        /// <summary>
        /// Вместимость ячейки хранения.
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Текущая количество продукта в ячейке.
        /// </summary>
        public int CurrentQuantity { get; set; }
    }
}
