using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class ProductionDTO
    {
        public string? Name { get; set; }
        public string? Article { get; set; }
        public string? Category { get; set; }
        public decimal Weight { get; set; }
        public string? Dimensions { get; set; }
        public DateOnly ExpiryDate { get; set; }
        public decimal Price { get; set; }

        public Production ConvertToProduction()
        {
            return new Production()
            {
                Name = Name,
                Article = Article,
                Category = Category,
                Weight = Weight,
                Dimensions = Dimensions,
                ExpiryDate = ExpiryDate,
                Price = Price
            };
        }

        public static ProductionDTO FromProduction(Production production)
        {
            return new ProductionDTO
            {
                Name = production.Name,
                Article = production.Article,
                Category = production.Category,
                Weight = production.Weight,
                Dimensions = production.Dimensions,
                ExpiryDate = production.ExpiryDate,
                Price = production.Price
            };
        }
    }
}
