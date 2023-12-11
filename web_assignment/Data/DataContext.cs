using Microsoft.EntityFrameworkCore;

namespace web_assignment.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<QuestionModel> QuestionModels => Set<QuestionModel>();
}

