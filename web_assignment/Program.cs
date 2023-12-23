using Microsoft.EntityFrameworkCore;
using web_assignment.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(
    Options => {
        var config = builder.Configuration;
        var conString = config.GetConnectionString("database");
        Options.UseSqlite(conString);
    }); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "QuestionIndex",
    pattern: "AllQuestions",
    defaults: new {controller = "Question", action = "Index" }
    );

app.MapControllerRoute(
    name: "question_viewer_with_id",
    pattern: "Question/{id?}",
    defaults: new { controller = "Question", action = "Viewer"});

app.MapControllerRoute(
    name: "QuestionEditor",
    pattern: "Editor",
    defaults: new { controller = "Question", action = "Editor"});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.Run();

