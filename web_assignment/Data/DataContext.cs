using Microsoft.EntityFrameworkCore;

namespace web_assignment.Data;

// DataContext class represents the database context for interacting with the underlying database.
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {}
    public DbSet<QuestionModel> QuestionModels => Set<QuestionModel>();
}

