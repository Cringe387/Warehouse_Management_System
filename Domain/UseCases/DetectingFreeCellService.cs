using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.Interfaces;
using Warehouse_Management_System.Domain.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse_Management_System.Domain.UseCases
{
    public class DetectingFreeCellService
    {
        private readonly IRepository _repository;

        public DetectingFreeCellService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Проверяет свободные ячейки и создает текущую инструкцию для продукции.
        /// </summary>
        /// <param name="productId">ID продукции, которую нужно разместить.</param>
        /// <param name="storageLogistId">ID логиста, занимающегося перевозкой.</param>
        /// <param name="storageManagerId">ID менеджера (необязательный параметр).</param>
        /// <returns>Сообщение о результате операции.</returns>
        public async Task<string> FindSuitableStorageCellAsync(int productId, int storageLogistId, int? storageManagerId)
        {
            var allCells = await _repository.GetAllCellsAsync();
            var suitableCell = allCells.FirstOrDefault(cell => cell.Occupied == false && cell.ProductId == productId);

            if (suitableCell != null)
            {
                // Создание новой текущей инструкции
                var currentInstruction = new CurrentInstruction
                {
                    Status = "В процессе",
                    StorageManagerId = storageManagerId ?? 0, // Если менеджер не указан, можно использовать 0 или другое значение по умолчанию
                    StorageLogistId = storageLogistId,
                    ProductId = productId,
                    Location = suitableCell.StorageCellId
                };

                // Сохранение текущей инструкции в базе данных
                await _repository.AddCurrentInstructionAsync(currentInstruction);

                return $"Продукция должна быть доставлена логистом {storageLogistId} в ячейку: {suitableCell.Name} (ID: {suitableCell.StorageCellId}).";
            }
            else
            {
                // Отправка задания менеджеру на перенос крупногабаритной продукции на резервный склад
                await SendManagerTaskForOversizedProduct(storageLogistId, productId);
                return $"Менеджеру отправлено задание на перенос продукции.";
            }
        }

        /// <summary>
        /// Отправляет менеджеру задание на перенос крупногабаритной продукции на резервный склад.
        /// </summary>
        /// <param name="storageManagerId">ID логиста.</param>
        /// <param name="productId">ID продукции.</param>
        private async Task SendManagerTaskForOversizedProduct(int storageManagerId, int productId)
        {
            Console.WriteLine($"Менеджеру с ID {storageManagerId} отправлено задание на перенос продукции с ID {productId} на резервный склад.");
        }
    }
}