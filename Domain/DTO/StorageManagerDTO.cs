using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class StorageManagerDTO
    {
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public StorageManager ConvertToStorageManager()
        {
            return new StorageManager()
            {
                Name = Name,
                Login = Login,
                Password = Password
            };
        }

        public static StorageManagerDTO FromStorageManager(StorageManager storageManager)
        {
            return new StorageManagerDTO
            {
                Name = storageManager.Name,
                Login = storageManager.Login,
                Password = storageManager.Password
            };
        }
    }
}
