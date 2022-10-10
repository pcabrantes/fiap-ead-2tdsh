using EcommerceWebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Configurando injeção de dependência
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoriaRepository, MockCategoriaRepository>();
builder.Services.AddScoped<IProdutoRepository, MockProdutoRepository>();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
