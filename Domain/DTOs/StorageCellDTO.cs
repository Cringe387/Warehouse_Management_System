using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTOs
{
    public class StorageCellDTO
    {
        /// <summary>
        /// Уникальный идентификатор ячейки хранения.
        /// </summary>
        public int StorageCellId { get; set; }

        /// <summary>
        /// Название ячейки хранения.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Тип ячейки хранения.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Зона, в которой расположена ячейка хранения.
        /// </summary>
        public string? Zone { get; set; }

        /// <summary>
        /// Идентификатор продукта, хранящегося в ячейке.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Текущая количество продукта в ячейке.
        /// </summary>
        public int CurrentQuantity { get; set; }

        /// <summary>
        /// Занята ли ячейка хранения.
        /// </summary>
        public bool Occupied { get; set; }
    }
}
