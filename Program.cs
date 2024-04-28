using Microsoft.EntityFrameworkCore;
using PlatformService.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//Добавление зависимости 
builder.Services.AddDbContext<ApplicationDataContext>(opt=> opt.UseInMemoryDatabase("InMem"));
builder.Services.AddScoped<IPlatformRep, PlatformRep>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


PropDb.PrepPopulation(app);

app.Run();


