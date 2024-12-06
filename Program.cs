using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddCors(o => {
    o.AddPolicy("AllowAll", a =>
                                a.AllowAnyHeader().
                                AllowAnyOrigin().
                                AllowAnyMethod()
    );
});
var dbpath = Path.Join(Directory.GetCurrentDirectory(), "carlist.db");
var conn = new SqliteConnection($"Data Source=C:\\Developer\\CarListApp.Api\\carlist.db");
builder.Services.AddDbContext<CarListDbContext>(o => o.UseSqlite(conn));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.MapGet("/cars",async (CarListDbContext db) => await db.cars.ToListAsync());

app.MapGet("/cars/{id}", async (int id,CarListDbContext db) => 
    await db.cars.FindAsync(id) is Car car ? Results.Ok(car) : Results.NotFound()
);

app.MapPut("/cars/{id}", async (int id, Car car, CarListDbContext db) =>
{
    var record = await db.cars.FindAsync(car.Id);
    if(record is null) return Results.NotFound();

    record.Make = car.Make;
    record.Model = car.Model;
    record.Vin = car.Vin;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/cars/{id}", async (int id, CarListDbContext db) =>
{
    var record = await db.cars.FindAsync(id);
    if (record is null) return Results.NotFound();

    db.Remove(record);

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapPost("/cars", async (int id,Car car, CarListDbContext db) =>
{
    await db.AddAsync(car);

    await db.SaveChangesAsync();

    return Results.Created($"/cars/{car.Id}",car);
});

app.Run();