using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.DTO;

namespace Warehouse_Management_System.Domain.Contracts
{
    public interface IDetectingFreeCellService
    {
        /// <summary>
        /// Находит подходящую свободную ячейку для размещения продукции.
        /// </summary>
        /// <param name="productId">ID продукции, которую нужно разместить.</param>
        /// <param name="storageLogistId">ID логиста, занимающегося перевозкой.</param>
        /// <param name="storageManagerId">ID менеджера (необязательный параметр).</param>
        /// <returns>Сообщение о результате операции.</returns>
        Task<string> FindSuitableStorageCellAsync(int productId, int storageLogistId, int? storageManagerId);

        /// <summary>
        /// Отправляет логисту задание на перенос крупногабаритной продукции на резервный склад.
        /// </summary>
        /// <param name="storageManagerId">ID логиста.</param>
        /// <param name="productId">ID продукции.</param>
        Task SendManagerTaskForOversizedProduct(int? storageManagerId, int productId);
    }
}