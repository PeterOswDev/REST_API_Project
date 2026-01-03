using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using REST_API_Project.Data;

namespace REST_API_Project.Data
{
    /// <summary>
    /// Design-time factory dla FirstAPIContext.
    /// EF Core CLI używa tego do tworzenia DbContext przy migracjach,
    /// niezależnie od appsettings.json czy dependency injection.
    /// </summary>
    public class FirstAPIContextFactory : IDesignTimeDbContextFactory<FirstAPIContext>
    {
        public FirstAPIContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FirstAPIContext>();

            // Connection string wskazujący konkretną instancję SQL Server i bazę
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;Database=FirstAPIdotnet;Trusted_Connection=True;TrustServerCertificate=True");

            return new FirstAPIContext(optionsBuilder.Options);
        }
    }
}
