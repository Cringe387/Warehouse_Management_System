using System.ComponentModel.DataAnnotations;


namespace Warehouse_Management_System.Domain.Entities
{
    /// <summary>
    /// Модель, представляющая менеджера склада в системе управления складом.
    /// </summary>
    public class StorageManager
    {
        /// <summary>
        /// Уникальный идентификатор менеджера склада.
        /// </summary>
        [Key]
        public int StorageManagerId { get; set; }

        /// <summary>
        /// Имя менеджера склада.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Логин менеджера склада.
        /// </summary>
        public string? Login { get; set; }

        private string hashedPassword;

        /// <summary>
        /// Пароль менеджера склада. 
        /// При установке пароля он автоматически хешируется.
        /// </summary>
        public string Password
        {
            get { return hashedPassword; }
            set { HashPassword(value); }
        }

        /// <summary>
		/// Проверяет, соответствует ли введенный пароль хешированному паролю менеджера склада.
		/// </summary>
		/// <param name="password">Пароль для проверки.</param>
		/// <returns>true, если пароль соответствует; иначе false.</returns>
		public bool IsValidPassword(string password)
        {
            return Password == password;
        }

        /// <summary>
        /// Хеширует пароль менеджера склада.
        /// </summary>
        /// <param name="password">Пароль, который нужно захешировать.</param>
        private void HashPassword(string password)
        {
            hashedPassword = password;
        }
    }
}
