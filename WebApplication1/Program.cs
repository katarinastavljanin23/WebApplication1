using WebApplication1.Modeli;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Register the IProductRepository and ICategoryRepository services with the connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddScoped<IProductRepository>(provider => new ProductRepository(connectionString));
builder.Services.AddScoped<ICategoryRepository>(provider => new CategoryRepository(connectionString));

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Enables the Swagger UI
}

app.UseAuthorization();

app.MapControllers();

app.Run();
