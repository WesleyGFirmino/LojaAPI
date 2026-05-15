using LojaApi.Repositories;
using LojaApi.Services;

var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddSingleton<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<CategoriaService>();
builder.Services.AddScoped<ProdutoService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();