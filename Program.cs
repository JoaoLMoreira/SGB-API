using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SgbProject.Data;
using SgbProject.Models;
using SgbProject.Repositories;
using SgbProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<Context>();
builder.Services.AddScoped<IRepository<Bovino>, BovinosRepository>();
builder.Services.AddScoped<IRepository<Baixa>, BaixaRepository>();
builder.Services.AddScoped<IRepository<Usuario>, UsuariosRepository>();

builder.Services.AddScoped<IBaixasServices, BaixasService>();

builder.Services.AddScoped<IBovinosService, BovinosService>(bs =>
{
    var baixaRepository = bs.GetRequiredService<IRepository<Baixa>>();
    var bovinoRepository = bs.GetRequiredService<IRepository<Bovino>>();

    return new BovinosService(baixaRepository, bovinoRepository);
});
builder.Services.AddScoped<IUsuariosService, UsuariosService>(us =>
{
    var usuariosRepository = us.GetRequiredService<IRepository<Usuario>>();
    return new UsuariosService(usuariosRepository);
});



builder.Services.AddDbContext<Context>(options =>
options.UseSqlServer("server=.\\SQLEXPRESS;database=SGB;trusted_connection=true;"));
//notebook//options.UseSqlServer("server=DESKTOP-DQFMKA0\\SQLEXPRESS;database=SGB;trusted_connection=true;"));
//options.UseSqlServer("" +
//"Data Source=.;" +
//"Initial Catalog=SGB;" +
//"Integrated Security=True;" +
////"User ID=sa;Password=1234;" +
//"Connect Timeout=15;" +
//"Encrypt=False;" +
//"TrustServerCertificate=False"
//));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
