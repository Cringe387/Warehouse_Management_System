using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTOs
{
    /// <summary>
    /// DTO (Data Transfer Object) для продукции.
    /// </summary>
    public class ProductionDTO
    {
        /// <summary>
        /// Название продукции.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Артикул продукции.
        /// </summary>
        public string? Article { get; set; }

        /// <summary>
        /// Категория продукции.
        /// </summary>
        public string? Category { get; set; }

        /// <summary>
        /// Вес продукции в килограммах.
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Размеры продукции (например, длина, ширина, высота).
        /// </summary>
        public string? Dimensions { get; set; }

        /// <summary>
        /// Дата истечения срока годности продукции.
        /// </summary>
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Цена продукции.
        /// </summary>
        public decimal Price { get; set; }
    }
}