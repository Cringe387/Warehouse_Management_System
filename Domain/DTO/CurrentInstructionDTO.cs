using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class CurrentInstructionDTO
    {
        public string? Status { get; set; }
        public int StorageManagerId { get; set; }
        public int StorageLogistId { get; set; }
        public int ProductId { get; set; }
        public int Location { get; set; }

        public CurrentInstruction ConvertToCurrentInstruction()
        {
            return new CurrentInstruction()
            {
                Status = Status,
                StorageManagerId = StorageManagerId,
                StorageLogistId = StorageLogistId,
                ProductId = ProductId,
                Location = Location
            };
        }
        public static CurrentInstructionDTO FromCurrentInstruction(CurrentInstruction currentInstruction)
        {
            return new CurrentInstructionDTO
            {
                Status = currentInstruction.Status,
                StorageLogistId = currentInstruction.StorageLogistId,
                ProductId = currentInstruction.ProductId,
                Location = currentInstruction.Location,
            };
        }
    }
}
