using System.ComponentModel.DataAnnotations;


namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая ячейку хранения в системе управления складом.
    /// </summary>
    public class StorageCell
    {
        /// <summary>
        /// Уникальный идентификатор ячейки хранения.
        /// </summary>
        [Key]
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
        /// Вместимость ячейки хранения.
        /// </summary>
        public int Capacity { get; set; }

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
