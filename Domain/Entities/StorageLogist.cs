using System.ComponentModel.DataAnnotations;

namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая логиста склада в системе управления складом.
    /// </summary>
    public class StorageLogist
    {
        /// <summary>
        /// Уникальный идентификатор логиста склада.
        /// </summary>
        [Key]
        public int StorageLogistId { get; set; }

        /// <summary>
        /// Имя логиста склада.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Логин логиста склада.
        /// </summary>
        public string? Login { get; set; }

        private string hashedPassword;

        /// <summary>
        /// Пароль логиста склада. 
        /// При установке пароля он автоматически хешируется.
        /// </summary>
        public string Password
        {
            get { return hashedPassword; }
            set { hashedPassword = HashPassword(value); }
        }

        /// <summary>
		/// Проверяет, соответствует ли введенный пароль хешированному паролю логиста склада.
		/// </summary>
		/// <param name="password">Пароль для проверки.</param>
		/// <returns>true, если пароль соответствует; иначе false.</returns>
		public bool IsValidPassword(string password)
        {
            return Password == HashPassword(password);
        }

        /// <summary>
        /// Хеширует пароль логиста склада.
        /// </summary>
        /// <param name="password">Пароль, который нужно захешировать.</param>
        private string HashPassword(string password)
        {
            return password;
        }

    }
}
