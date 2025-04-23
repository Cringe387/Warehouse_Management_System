using Warehouse_Management_System.Domain.DTOs;
using Warehouse_Management_System.Domain.Contracts;
using System.Threading.Tasks;
using Warehouse_Management_System.Domain.DTO;

namespace Warehouse_Management_System
{
    public class AuthenticationController
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// Регистрация нового менеджера склада.
        /// </summary>
        /// <param name="newStorageManager">DTO нового менеджера склада для регистрации.</param>
        /// <returns>Результат регистрации.</returns>
        public async Task<string> RegisterStorageManagerAsync(StorageManagerDTO newStorageManager)
        {
            if (newStorageManager == null)
            {
                throw new ArgumentNullException(nameof(newStorageManager));
            }

            var registeredManager = await _authenticationService.RegisterStorageManagerAsync(newStorageManager);
            return registeredManager != null ? "Регистрация успешна." : "Ошибка регистрации.";
        }

        /// <summary>
        /// Вход менеджера склада.
        /// </summary>
        /// <param name="login">Логин менеджера склада.</param>
        /// <param name="password">Пароль менеджера склада.</param>
        /// <returns>Результат входа.</returns>
        public async Task<string> LoginStorageManagerAsync(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Логин и пароль не могут быть пустыми.");
            }

            var loggedManager = await _authenticationService.LoginStorageManagerAsync(login, password);
            return loggedManager != null ? "Вход успешен." : "Ошибка входа.";
        }

        /// <summary>
        /// Регистрация нового логиста склада.
        /// </summary>
        /// <param name="newStorageLogist">DTO нового логиста склада для регистрации.</param>
        /// <returns>Результат регистрации.</returns>
        public async Task<string> RegisterStorageLogistAsync(StorageLogistDTO newStorageLogist)
        {
            if (newStorageLogist == null)
            {
                throw new ArgumentNullException(nameof(newStorageLogist));
            }

            var registeredLogist = await _authenticationService.RegisterStorageLogistAsync(newStorageLogist);
            return registeredLogist != null ? "Регистрация логиста успешна." : "Ошибка регистрации логиста.";
        }

        /// <summary>
        /// Вход логиста склада.
        /// </summary>
        /// <param name="login">Логин логиста склада.</param>
        /// <param name="password">Пароль логиста склада.</param>
        /// <returns>Результат входа.</returns>
        public async Task<string> LoginStorageLogistAsync(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Логин и пароль не могут быть пустыми.");
            }

            var loggedLogist = await _authenticationService.LoginStorageLogistAsync(login, password);
            return loggedLogist != null ? "Вход логиста успешен." : "Ошибка входа логиста.";
        }
    }
}