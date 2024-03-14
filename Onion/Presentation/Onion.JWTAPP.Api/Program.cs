
using Onion.JWTAPP.Application;
using Onion.JWTAPP.Persistence;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region Service Registiration
builder.Services.AddApplicationService();
builder.Services.AddPersistenceServices(builder.Configuration); 
#endregion
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
