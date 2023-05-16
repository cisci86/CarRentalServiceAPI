using CarRentalServiceAPI;
using CarRentalServiceAPI.AutoMapper;
using Microsoft.EntityFrameworkCore;

var LocalHostAllowed = "_localhostAllowed";

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddDbContext<CarRentalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CarRentalServiceAPIContext")));

builder.Services.AddAutoMapper(typeof(RentalProfile));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: LocalHostAllowed,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200")
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials();
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("_localhostAllowed");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
