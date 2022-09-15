using SistemaVendas.Negocio;
using SistemaVendas.Repositorio;

var valorMediaMensal = new VendasNegocio(new VendasRepositorio()).CalcularMediaMensal(06, 2023);
Console.WriteLine($"O Valor médio mensal é {valorMediaMensal}");
