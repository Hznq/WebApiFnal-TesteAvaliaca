using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApiFnal.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebApiFnalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApiFnalContext") ?? throw new InvalidOperationException("Connection string 'WebApiFnalContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();

//politicas de Cors origin
builder.Services.AddCors(etecPoliticas =>
{
    etecPoliticas.AddPolicy("EtecAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });

});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("EtecAll");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
