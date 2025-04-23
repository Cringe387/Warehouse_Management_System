using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.Interfaces;

namespace Warehouse_Management_System.Domain.UseCases
{
    public class CheckCorrectDeliveryService
    {
        private readonly IRepository _repository;

        public CheckCorrectDeliveryService(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Проверяет ID ячейки, введенный логистом, и завершает текущую инструкцию.
        /// </summary>
        /// <param name="currentInstructionId">ID текущей инструкции.</param>
        /// <param name="inputCellId">ID ячейки, введенный логистом.</param>
        /// <returns>Сообщение о результате проверки.</returns>
        public async Task<string> VerifyCellIdAsync(int currentInstructionId, int inputCellId)
        {
            var currentInstruction = await _repository.GetCurrentInstructionById(currentInstructionId);

            if (currentInstruction == null)
            {
                return "Текущая инструкция не найдена.";
            }

            // Проверка совпадения ID ячейки
            if (currentInstruction.Location != inputCellId)
            {
                return "Неверный ID ячейки. Пожалуйста, введите ID ячейки заново.";
            }

            // Создание завершенной инструкции
            var completedInstruction = new CompletedInstruction
            {
                CurrentInstructionId = currentInstructionId,
                Type = "Доставка завершена",
                ProductId = currentInstruction.ProductId,
                Location = inputCellId
            };

            await _repository.AddCompletedInstructionAsync(completedInstruction);

            // Обновление статуса текущей инструкции
            currentInstruction.Status = "Завершено";
            await _repository.UpdateCurrentInstructionAsync(currentInstruction);

            // Обнуление текущей инструкции
            currentInstruction.Status = null;
            currentInstruction.StorageManagerId = 0; // Или другое значение по умолчанию
            currentInstruction.StorageLogistId = 0; // Или другое значение по умолчанию
            currentInstruction.ProductId = 0; // Или другое значение по умолчанию
            currentInstruction.Location = 0; // Или другое значение по умолчанию

            await _repository.UpdateCurrentInstructionAsync(currentInstruction);

            return "Доставка успешно завершена.";
        }
    }
}
