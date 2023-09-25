namespace MultiTenancy.Settings
{
    public class TenantSettings
    {
        public Configuration Configuration { get; set; } = default!;
        public List<Tenant> Tenants { get; set; } = new();
    }
}
