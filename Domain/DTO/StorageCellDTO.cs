using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class StorageCellDTO
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Zone { get; set; }
        public int Capacity { get; set; }
        public int ProductId { get; set; }
        public int CurrentQuantity { get; set; }
        public bool Occupied { get; set; }

        public StorageCell ConvertToStorageCell()
        {
            return new StorageCell()
            {
                Name = Name,
                Type = Type,
                Zone = Zone,
                Capacity = Capacity,
                ProductId = ProductId,
                CurrentQuantity = CurrentQuantity,
                Occupied = Occupied
            };
        }

        public static StorageCellDTO FromStorageCell(StorageCell storageCell)
        {
            return new StorageCellDTO
            {
                Name = storageCell.Name,
                Type = storageCell.Type,
                Zone = storageCell.Zone,
                Capacity = storageCell.Capacity,
                ProductId = storageCell.ProductId,
                CurrentQuantity = storageCell.CurrentQuantity,
                Occupied = storageCell.Occupied
            };
        }
    }
}
