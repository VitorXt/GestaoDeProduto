using GestaoDeProduto.Application.Interfaces;
using GestaoDeProduto.Application.Services;
using GestaoDeProduto.Data.Repositories;
using GestaoDeProduto.Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region configuração injecoes
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
            ////             Interface       , e sua implementação
            ///              o que é feito aqui? ele instancia ProdutoRepository e envia a instancia para a camada usar
            ///              ProdutoRepository produtoReposito = New ProdutoRepository();
builder.Services.AddScoped<IProdutoService, ProdutoService>();


#endregion

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
