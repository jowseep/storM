using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Data;
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

// Enable services
builder.Services.AddTransient<StoreService>();
builder.Services.AddDbContext<StoreInfoContext>();

// Enable repositories
builder.Services.AddTransient<StoreRepository>();
builder.Services.AddTransient<ProductRepository>();
builder.Services.AddTransient<PaidTransactionRepository>();
builder.Services.AddTransient<PaidDebtRepository>();
builder.Services.AddTransient<DebtRepository>();
builder.Services.AddTransient<DebtItemRepository>();
builder.Services.AddTransient<DebtRepository>();
builder.Services.AddTransient<BorrowerRepository>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//builder.Services.AddControllers().AddJsonOptions(x =>
//                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

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
