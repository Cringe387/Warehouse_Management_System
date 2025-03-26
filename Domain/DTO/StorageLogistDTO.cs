using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class StorageLogistDTO
    {
        public string? Name { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }

        public StorageLogist ConvertToStorageLogist()
        {
            return new StorageLogist()
            {
                Name = Name,
                Login = Login,
                Password = Password
            };
        }

        public static StorageLogistDTO FromStorageLogist(StorageLogist storageLogist)
        {
            return new StorageLogistDTO
            {
                Name = storageLogist.Name,
                Login = storageLogist.Login,
                Password = storageLogist.Password
            };
        }
    }
}
