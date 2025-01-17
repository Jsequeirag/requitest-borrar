using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using requitools_be;
using requitools_be.Context;
using requitools_be.Interfaces;
using requitools_be.Repositories;

var builder = WebApplication.CreateBuilder(args);


//servicios
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IAutoresRepository, AutoresRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
//context
builder.Services.AddDbContext<RequiToolsDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<ExactusDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SOSDB")));

//builder.Services.AddDbContext<RequiToolsDbContext>(options => options.UseSqlServer("name=DefaultConnection"));
//builder.Services.AddDbContext<ExactusDbContext>(options => options.UseSqlServer("name=ExactusConnection"));

//builder.Services.AddDbContext<RequiToolsDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddDbContext<ExactusDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SOSDB")));

var app = builder.Build();

//swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/", () => "hello world"); 
app.MapControllers();
//Fin del área de los middlewares
app.Run();
// Scaffold-DbContext "Server=10.10.19.243,1621; Database=EXACTUS;User Id =AKILES;Password=R3sources;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -OutputDir scaffold -t liore.InfoEmpleadosAkiles