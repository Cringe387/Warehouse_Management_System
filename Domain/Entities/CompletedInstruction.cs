using System.ComponentModel.DataAnnotations;


namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая завершенную инструкцию в системе управления складом.
    /// </summary>
    public class CompletedInstruction
    {
        /// <summary>
        /// Уникальный идентификатор завершенной инструкции.
        /// </summary>
        [Key]
        public int CompletedInstructionId { get; set; }

        /// <summary>
        /// Идентификатор текущей инструкции, связанной с завершенной инструкцией.
        /// </summary>
        public int CurrentInstructionId { get; set; }

        /// <summary>
        /// Тип завершенной инструкции.
        /// </summary>
        public string? Type { get; set; }

        /// <summary>
        /// Идентификатор продукта, связанного с завершенной инструкцией.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Местоположение, связанное с завершенной инструкцией.
        /// </summary>
        public int Location { get; set; }
    }
}

