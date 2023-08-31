using Microsoft.EntityFrameworkCore;
using SignalRApi.Dal;
using SignalRApi.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddScoped<VisitorService>();
builder.Services.AddSignalR();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));




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
//https://dev.to/moe23/net-6-with-postgresql-576a //postgresql .net 6