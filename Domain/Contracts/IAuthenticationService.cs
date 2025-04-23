using Warehouse_Management_System.Domain.Entities;
using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.DTO;


namespace Warehouse_Management_System.Domain.Contracts
{
    /// <summary>
    /// Интерфейс для аутентификации менеджеров склада.
    /// </summary>
    public interface IAuthenticationService
    {
        /// <summary>
        /// Регистрирует нового менеджера склада.
        /// </summary>
        /// <param name="newStorageManager">DTO нового менеджера склада для регистрации.</param>
        /// <returns>Зарегистрированный менеджер склада.</returns>
        public Task<StorageManager> RegisterStorageManagerAsync(StorageManagerDTO newStorageManager);

        /// <summary>
        /// Выполняет вход менеджера склада.
        /// </summary>
        /// <param name="login">Логин менеджера склада.</param>
        /// <param name="password">Пароль менеджера склада.</param>
        /// <returns>Менеджер склада, который выполнил вход.</returns>
        public Task<StorageManager> LoginStorageManagerAsync(string login, string password);

        /// <summary>
        /// Изменяет пароль менеджера склада.
        /// </summary>
        /// <param name="updatedStorageManager">DTO менеджера склада с обновленными данными.</param>
        /// <returns>Менеджер склада с обновленным паролем.</returns>
        public Task<StorageManager> ChangeStorageManagerPasswordAsync(StorageManagerDTO updatedStorageManager);

        /// <summary>
        /// Регистрирует нового логиста склада.
        /// </summary>
        /// <param name="newStorageLogist">DTO нового логиста склада для регистрации.</param>
        /// <returns>Зарегистрированный логист склада.</returns>
        public Task<StorageLogist> RegisterStorageLogistAsync(StorageLogistDTO newStorageLogist);

        /// <summary>
        /// Выполняет вход логиста склада.
        /// </summary>
        /// <param name="login">Логин логиста склада.</param>
        /// <param name="password">Пароль логиста склада.</param>
        /// <returns>Логист склада, который выполнил вход.</returns>
        public Task<StorageLogist> LoginStorageLogistAsync(string login, string password);

        /// <summary>
        /// Изменяет пароль логиста склада.
        /// </summary>
        /// <param name="updatedStorageLogist">DTO логиста склада с обновленными данными.</param>
        /// <returns>Логист склада с обновленным паролем.</returns>
        public Task<StorageLogist> ChangeStorageLogistPasswordAsync(StorageLogistDTO updatedStorageLogist);
    }
}
