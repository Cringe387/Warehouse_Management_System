using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class CompletedInstructionDTO
    {
        public int CurrentInstructionId { get; set; }
        public string? Type { get; set; }
        public int ProductId { get; set; }
        public int Location { get; set; }

        public CompletedInstruction ConvertToCompletedInstruction()
        {
            return new CompletedInstruction()
            {
                CurrentInstructionId = CurrentInstructionId,
                Type = Type,
                ProductId = ProductId,
                Location = Location
            };
        }

        public static CompletedInstructionDTO FromCompletedInstruction(CompletedInstruction completedInstruction)
        {
            return new CompletedInstructionDTO
            {
                CurrentInstructionId = completedInstruction.CurrentInstructionId,
                Type = completedInstruction.Type,
                ProductId = completedInstruction.ProductId,
                Location = completedInstruction.Location
            };
        }
    }
}
