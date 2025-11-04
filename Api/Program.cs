using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence;
using Application;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";

        builder.Services.AddInfrastructureServices(connectionString);
        builder.Services.RegisterApplicationServices();


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();

        var app = builder.Build();

        app.MapControllers();

        app.Urls.Add("http://0.0.0.0:5005");

        app.Run();
    }
}