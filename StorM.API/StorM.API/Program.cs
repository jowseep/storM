using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services;
using StorM.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add XML support
builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Enable PDF functionality
builder.Services.AddSingleton<FileExtensionContentTypeProvider>();

builder.Services.AddDbContext<StoreInfoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StormConnectionString")));

// Enable repositories

builder.Services.AddScoped<IStoreRepository ,StoreRepository>();
builder.Services.AddScoped<IProductRepository ,ProductRepository>();
builder.Services.AddScoped<IPaidTransactionRepository, PaidTransactionRepository>();
builder.Services.AddScoped<IPaidDebtRepository ,PaidDebtRepository>();
builder.Services.AddScoped<IDebtRepository,DebtRepository>();
builder.Services.AddScoped<IDebtItemRepository,DebtItemRepository>();
builder.Services.AddScoped<IDebtRepository, DebtRepository>();
builder.Services.AddScoped<IBorrowerRepository,BorrowerRepository>();

// Enable services
builder.Services.AddTransient<IStoreService, StoreService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IPaidTransactionService, PaidTransactionService>();
builder.Services.AddTransient<IPaidDebtService, PaidDebtService>();
builder.Services.AddTransient<IDebtService, DebtService>();
builder.Services.AddTransient<IDebtItemService, DebtItemService>();
builder.Services.AddTransient<IBorrowerService, BorrowerService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build(); 

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
