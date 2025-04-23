using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.ContractsRealization;
using Warehouse_Management_System.Domain.Contracts;

namespace Warehouse_Management_System.Services
{
    public class DetectingFreeCellService
    {
        private readonly IDetectingFreeCellService _detectingFreeCellService;

        public DetectingFreeCellService(IDetectingFreeCellService detectingFreeCellService)
        {
            _detectingFreeCellService = detectingFreeCellService;
        }

        /// <summary>
        /// Находит подходящую свободную ячейку для размещения продукции.
        /// </summary>
        /// <param name="productId">ID продукции.</param>
        /// <param name="storageManagerId">ID менеджера склада.</param>
        /// <returns>Результат поиска свободной ячейки.</returns>
        public async Task<string> FindSuitableStorageCellAsync(int productId, int storageLogistId, int storageManagerId)
        {
            var resultMessage = await _detectingFreeCellService.FindSuitableStorageCellAsync(productId, storageLogistId, storageManagerId);
            return resultMessage;
        }
    }
}