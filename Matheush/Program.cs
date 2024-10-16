using API.Models;
using Matheush;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MatheusHenriqueDataContext>();
var MatheusHenrique = builder.Build();

MatheusHenrique.MapGet("/", () => "Prova");

MatheusHenrique.MapPost("/funcionario/cadastrar", ([FromBody] Funcionario funcionario,
    [FromServices] MatheusDataFunc ctx) =>
{
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
});

MatheusHenrique.MapGet("/funcionario/listar", ([FromServices] MatheusDataFunc ctx) =>
{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound();
});
MatheusHenrique.MapPost("/folha/cadastrar", ([FromBody] Folha folha,
    [FromServices] MatheusHenriqueDataContext ctx) =>
{
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
});

MatheusHenrique.MapGet("/folha/listar", ([FromServices] MatheusHenriqueDataContext ctx) =>
{
    if (ctx.Folhas.Any())
    {
        return Results.Ok(ctx.Folhas.ToList());
    }
    return Results.NotFound();
});

MatheusHenrique.MapGet("/folha/buscar/{id}", ([FromRoute] int id,
    [FromServices] MatheusHenriqueDataContext ctx) =>
{
    Folha? tarefa = ctx.Folhas.Find(id);
    if (tarefa is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(tarefa);
});

MatheusHenrique.Run();
