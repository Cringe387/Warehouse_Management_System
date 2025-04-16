using System.ComponentModel.DataAnnotations;

namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая текущую инструкцию в системе управления складом.
    /// </summary>
    public class CurrentInstruction
    {
        /// <summary>
        /// Уникальный идентификатор текущей инструкции.
        /// </summary>
        [Key]
        public int CurrentInstructionId { get; set; }

        /// <summary>
        /// Статус текущей инструкции.
        /// </summary>
        public string? Status { get; set; }

        /// <summary>
        /// Идентификатор менеджера склада, связанного с текущей инструкцией.
        /// </summary>
        public int StorageManagerId { get; set; }

        /// <summary>
        /// Идентификатор логиста склада, связанного с текущей инструкцией.
        /// </summary>
        public int StorageLogistId { get; set; }

        /// <summary>
        /// Идентификатор продукта, связанного с текущей инструкцией.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Местоположение, связанное с текущей инструкцией.
        /// </summary>
        public int Location { get; set; }
    }
}
