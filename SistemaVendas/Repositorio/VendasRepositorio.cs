using SistemaVendas.Entidade;

namespace SistemaVendas.Repositorio;

public class VendasRepositorio : IVendasRepositorio
{
    public IList<Vendas> BuscarVendas(short mes, short ano)
    {
        return new List<Vendas>
    {
        new Vendas
        {
            Data = new DateTime(2022,09,13),
            Valor = 500.00m
        },
        new Vendas
        {
            Data= new DateTime(2022,04,16),
            Valor = 1000.00m
        },
        new Vendas
        {
            Data= new DateTime(2022,06,15),
            Valor = 399.99m
        }
    };
    }
}
