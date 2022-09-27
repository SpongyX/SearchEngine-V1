using Microsoft.EntityFrameworkCore;
using SearchEngine.Data;
using SearchEngine.Interfaces;
using SearchEngine.Services;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddScoped<IStoredLibrary, StoredLibraryService>();
builder.Services.AddScoped<IUserService, UserService>();

//Inject Db Context
builder.Services.AddDbContext<SearchEngineContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Add services to the container.
builder.Services.AddCors();
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
app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
