
namespace MultiTenancy.Models
{
    public class Product : IMustHaveTenancy
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Rate { get; set; }
        public int TenancyId { get; set; }
    }
}
