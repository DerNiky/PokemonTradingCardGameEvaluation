using Scraper.Modules.TradingCardGameCollector.Logic;
using Scraper.Modules.TradingCardGameCollector.Persistence;

namespace Scraper;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });

        builder.Services.AddScoped<TradingCardGameCollectorLogic>();
        builder.Services.AddScoped<TradingCardGameCollectorRepostiory>();

        builder.Services.AddControllers();

        builder.Services.AddSwaggerGen();

        builder.Services.AddEndpointsApiExplorer();


        var app = builder.Build();

        // if (app.Environment.IsDevelopment())
        // {
        app.UseSwagger();
        app.UseSwaggerUI();
        // }

        app.UseRouting();
        app.UseCors("AllowAll");
        app.MapControllers();
        app.Run();
    }
}