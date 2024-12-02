using MeuSistema.Data;
using MeuSistema.Models;
using MeuSistema.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar o DbContext com SQLite
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=meusistema.db"));

// Registrar repositórios e serviços
builder.Services.AddScoped<IRepository<Pedido>, PedidoRepository>();
builder.Services.AddScoped<IRepository<Fornecedor>, FornecedorRepository>();
builder.Services.AddScoped<PedidoService>();
builder.Services.AddScoped<FornecedorService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:5285");
