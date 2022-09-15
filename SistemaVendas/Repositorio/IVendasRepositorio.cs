using SistemaVendas.Entidade;

namespace SistemaVendas.Repositorio;

public interface IVendasRepositorio
{
    IList<Vendas> BuscarVendas(short mes, short ano);
}
