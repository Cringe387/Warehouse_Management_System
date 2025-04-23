using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.DTO;

namespace Warehouse_Management_System.Domain.Contracts
{
    public interface ICheckCorrectDeliveryService
    {
        /// <summary>
        /// Проверяет ID ячейки, введенный логистом, и завершает текущую инструкцию.
        /// </summary>
        /// <param name="currentInstructionId">ID текущей инструкции.</param>
        /// <param name="inputCellId">ID ячейки, введенный логистом.</param>
        /// <returns>Сообщение о результате проверки.</returns>
        Task<string> VerifyCellIdAsync(int currentInstructionId, int inputCellId);
    }
}