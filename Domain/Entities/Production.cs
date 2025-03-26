using System.ComponentModel.DataAnnotations;


namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая продукт в системе управления складом.
    /// </summary>
    public class Production
    {
        /// <summary>
        /// Уникальный идентификатор продукта.
        /// </summary>
        [Key]
        public int ProductId { get; set; }

        /// <summary>Warehouse_management_system
        /// Название продукта.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Артикул продукта.
        /// </summary>
        public string? Article { get; set; }

        /// <summary>
        /// Категория продукта.
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Вес продукта в килограммах.
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Размеры продукта (например, длина, ширина, высота).
        /// </summary>
        public string? Dimensions { get; set; }

        /// <summary>
        /// Дата истечения срока годности продукта.
        /// </summary>
        public DateOnly ExpiryDate { get; set; }

        /// <summary>
        /// Цена продукта.
        /// </summary>
        public decimal Price { get; set; }
    }
}

