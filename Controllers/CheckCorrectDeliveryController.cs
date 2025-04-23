using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.ContractsRealization;
using System.Threading.Tasks;
using Warehouse_Management_System.Domain.Contracts;

namespace Warehouse_Management_System.Services
{
    public class CheckCorrectDeliveryService
    {
        private readonly ICheckCorrectDeliveryService _checkCorrectDeliveryService;

        public CheckCorrectDeliveryService(ICheckCorrectDeliveryService checkCorrectDeliveryService)
        {
            _checkCorrectDeliveryService = checkCorrectDeliveryService;
        }
            
        /// <summary>
        /// Проверяет идентификатор ячейки, введенный логистом.
        /// </summary>
        /// <param name="currentInstructionId">ID текущей инструкции.</param>
        /// <param name="inputCellId">Введенный идентификатор ячейки.</param>
        /// <returns>Результат проверки.</returns>
        public async Task<string> VerifyCellIdAsync(int currentInstructionId, int inputCellId)
        {
            var resultMessage = await _checkCorrectDeliveryService.VerifyCellIdAsync(currentInstructionId, inputCellId);
            return resultMessage;
        }
    }
}