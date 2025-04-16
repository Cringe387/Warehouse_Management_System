using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.Interfaces
{
    public interface IRepository
    {
        /// <summary>
        /// Получает список всей продукции.
        /// </summary>
        /// <returns>Список продукции.</returns>
        Task<List<Production>> GetAllProdAsync();

        /// <summary>
        /// Получает продукцию по её идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор продукции.</param>
        /// <returns>Продукция с указанным идентификатором.</returns>
        Task<Production?> GetProductionById(int id);

        /// <summary>
        /// Добавляет новую продукцию.
        /// </summary>
        /// <param name="newProduction">Новая продукция для добавления.</param>
        /// <returns>Добавленная продукция.</returns>
        Task<Production> AddProductionAsync(Production newProduction);

        /// <summary>
        /// Обновляет существующую продукцию.
        /// </summary>
        /// <param name="updateProduction">Продукция с обновленными данными.</param>
        /// <returns>Обновленная продукция.</returns>
        Task<Production> UpdateProductionAsync(Production updateProduction);

        /// <summary>
        /// Удаляет продукцию по её идентификатору.
        /// </summary>
        /// <param name="productionId">Идентификатор продукции для удаления.</param>
        /// <returns>Идентификатор удаленной продукции.</returns>
        Task<int> RemoveProductionAsync(int productionId);

        /// <summary>
        /// Получает список всех ячеек хранения.
        /// </summary>
        /// <returns>Список ячеек хранения.</returns>
        Task<List<StorageCell>> GetAllCellsAsync();

        /// <summary>
        /// Получает ячейку хранения по ее идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор ячейки хранения.</param>
        /// <returns>Ячейка хранения с указанным идентификатором.</returns>
        Task<StorageCell?> GetCellsById(int id);

        /// <summary>
        /// Получает идентификаторы не занятых ячеек хранения.
        /// </summary>
        /// <param name="cells">Ячейка для проверки.</param>
        /// <returns>Список идентификаторов не занятых ячеек.</returns>
        Task<List<int>> GetCellIdNoOccupiedAsync(StorageCell cells);

        /// <summary>
        /// Получает логиста по его логину.
        /// </summary>
        /// <param name="login">Логин логиста.</param>
        /// <returns>Логист с указанным логином.</returns>
        Task<StorageLogist?> GetStorageLogistByLoginAsync(string login);

        /// <summary>
        /// Добавляет нового логиста.
        /// </summary>
        /// <param name="newStorageLogist">Новый логист для добавления.</param>
        /// <returns>Добавленный логист.</returns>
        Task<StorageLogist> AddStorageLogistAsync(StorageLogist newStorageLogist);

        /// <summary>
        /// Обновляет существующего логиста.
        /// </summary>
        /// <param name="updateStorageLogist">Логист с обновленными данными.</param>
        /// <returns>Обновленный логист.</returns>
        Task<StorageLogist> UpdateStorageLogistAsync(StorageLogist updateStorageLogist);

        /// <summary>
        /// Удаляет логиста по его идентификатору.
        /// </summary>
        /// <param name="storageLogistId">Идентификатор логиста для удаления.</param>
        /// <returns>Идентификатор удаленного логиста.</returns>
        Task<int> RemoveStorageLogist(int storageLogistId);

        /// <summary>
        /// Получает менеджера склада по его логину.
        /// </summary>
        /// <param name="login">Логин менеджера склада.</param>
        /// <returns>Менеджер склада с указанным логином.</returns>
        Task<StorageManager?> GetStorageManagerByLoginAsync(string login);

        /// <summary>
        /// Добавляет нового менеджера склада.
        /// </summary>
        /// <param name="newStorageManager">Новый менеджер склада для добавления.</param>
        /// <returns>Добавленный менеджер склада.</returns>
        Task<StorageManager> AddStorageManagerAsync(StorageManager newStorageManager);

        /// <summary>
        /// Обновляет существующего менеджера склада.
        /// </summary>
        /// <param name="updateStorageManager">Менеджер склада с обновленными данными.</param>
        /// <returns>Обновленный менеджер склада.</returns>
        Task<StorageManager> UpdateStorageManagerAsync(StorageManager updateStorageManager);

        /// <summary>
        /// Удаляет менеджера склада по его идентификатору.
        /// </summary>
        /// <param name="storageManagerId">Идентификатор менеджера склада для удаления.</param>
        /// <returns>Идентификатор удаленного менеджера склада.</returns>
        Task<int> RemoveStorageManager(int storageManagerId);

        /// <summary>
        /// Получает список всех текущих инструкций.
        /// </summary>
        /// <returns>Список текущих инструкций.</returns>
        Task<List<CurrentInstruction>> GetAllCurrentInstruction();

        /// <summary>
        /// Получает текущую инструкцию по ее идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор текущей инструкции.</param>
        /// <returns>Текущая инструкция с указанным идентификатором.</returns>
        Task<CurrentInstruction?> GetCurrentInstructionById(int id);

        /// <summary>
        /// Добавляет новую текущую инструкцию.
        /// </summary>
        /// <param name="newСurrentInstruction">Новая текущая инструкция для добавления.</param>
        /// <returns>Добавленная текущая инструкция.</returns>
        Task<CurrentInstruction> AddCurrentInstructionAsync(CurrentInstruction newСurrentInstruction);

        /// <summary>
        /// Обновляет существующую текущую инструкцию.
        /// </summary>
        /// <param name="updateCurrentInstruction">Текущая инструкция с обновленными данными.</param>
        /// <returns>Обновленная текущая инструкция.</returns>
        Task<CurrentInstruction> UpdateCurrentInstructionAsync(CurrentInstruction updateCurrentInstruction);

        /// <summary>
        /// Удаляет текущую инструкцию по ее идентификатору.
        /// </summary>
        /// <param name="currentInstructionId">Идентификатор текущей инструкции для удаления.</param>
        /// <returns>Идентификатор удаленной текущей инструкции.</returns>
        Task<int> RemoveCurrentInstructionAsync(int currentInstructionId);

        /// <summary>
        /// Получает список всех завершенных инструкций.
        /// </summary>
        /// <returns>Список завершенных инструкций.</returns>
        Task<List<CompletedInstruction>> GetAllCompletedInstruction();

        /// <summary>
        /// Получает завершенную инструкцию по ее идентификатору.
        /// </summary>
        /// <param name="id">Идентификатор завершенной инструкции.</param>
        /// <returns>Завершенная инструкция с указанным идентификатором.</returns>
        Task<CompletedInstruction?> GetCompletedInstructionById(int id);

        /// <summary>
        /// Добавляет новую завершенную инструкцию.
        /// </summary>
        /// <param name="newCompletedInstruction">Новая завершенная инструкция для добавления.</param>
        /// <returns>Добавленная завершенная инструкция.</returns>
        Task<CompletedInstruction> AddCompletedInstructionAsync(CompletedInstruction newCompletedInstruction);

        /// <summary>
        /// Обновляет существующую завершенную инструкцию.
        /// </summary>
        /// <param name="updateCompletedInstruction">Завершенная инструкция с обновленными данными.</param>
        /// <returns>Обновленная завершенная инструкция.</returns>
        Task<CompletedInstruction> UpdateCompletedInstructionAsync(CompletedInstruction updateCompletedInstruction);

        /// <summary>
        /// Удаляет завершенную инструкцию по ее идентификатору.
        /// </summary>
        /// <param name="completedInstructionId">Идентификатор завершенной инструкции для удаления.</param>
        /// <returns>Идентификатор удаленной завершенной инструкции.</returns>
        Task<int> RemoveCompletedInstructionAsync(int completedInstructionId);

        /// <summary>
        /// Получает список поставщиков для накладной.
        /// </summary>
        /// <param name="receiptInvoice">Накладная для получения поставщиков.</param>
        /// <returns>Список поставщиков для указанной накладной.</returns>
        Task<List<ReceiptInvoiceSupplier>> GetInvoiceSupplierAsync(ReceiptInvoice receiptInvoice);

        /// <summary>
        /// Получает ячейки хранения для продукции.
        /// </summary>
        /// <param name="production">Продукция для получения ячеек хранения.</param>
        /// <returns>Список ячеек хранения для указанной продукции.</returns>
        Task<List<ProductionCell>> GetProductionCell(Production production);
    }
} 