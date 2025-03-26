using Warehouse_Management_System.Domain.Entities;

namespace Warehouse_Management_System.Domain.DTO
{
    public class SupplierDTO
    {
        public string? Name { get; set; }
        public string? ContactPerson { get; set; }
        public string? Phone { get; set; }
        public string? AddressSupplier { get; set; }

        public Supplier ConvertToSupplier()
        {
            return new Supplier()
            {
                Name = Name,
                ContactPerson = ContactPerson,
                Phone = Phone,
                AddressSupplier = AddressSupplier
            };
        }

        public static SupplierDTO FromSupplier(Supplier supplier)
        {
            return new SupplierDTO
            {
                Name = supplier.Name,
                ContactPerson = supplier.ContactPerson,
                Phone = supplier.Phone,
                AddressSupplier = supplier.AddressSupplier
            };
        }
    }
}
