using SistemaVendas.Repositorio;

namespace SistemaVendas.Negocio;

public class VendasNegocio
{
    private readonly IVendasRepositorio _vendasRepositorio;

    public VendasNegocio(IVendasRepositorio vendasRepositorio)
    {
        _vendasRepositorio = vendasRepositorio;
    }

    public decimal CalcularMediaMensal(short mes, short ano)
    {
        var vendas = _vendasRepositorio.BuscarVendas(mes, ano);
        var vendasMensal = vendas.Sum(s => s.Valor) / vendas.Count();
        return Math.Round(vendasMensal, 2);
    }
}
