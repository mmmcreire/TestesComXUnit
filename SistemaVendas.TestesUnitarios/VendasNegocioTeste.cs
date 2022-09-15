using Moq;
using SistemaVendas.Entidade;
using SistemaVendas.Negocio;
using SistemaVendas.Repositorio;

namespace SistemaVendas.TestesUnitarios;

public class VendasNegocioTeste
{
    VendasNegocio _vendasNegocio;
    Mock<IVendasRepositorio> _vendasRepositorioMock;

    public VendasNegocioTeste()
    {
        var retorno = new List<Vendas>
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
            },
            new Vendas
            {
                Data= new DateTime(2011,06,15),
                Valor = 11.99m
            }
        };

        _vendasRepositorioMock = new Mock<IVendasRepositorio>();
        _vendasRepositorioMock.Setup(v => v.BuscarVendas(It.IsAny<short>(), It.IsAny<short>())).Returns(retorno);

        _vendasNegocio = new VendasNegocio(_vendasRepositorioMock.Object);
    }

    [Fact(DisplayName = "Deve calcular a média mensal com sucesso")]
    public void DeveCalcularMediaMensalComSucesso()
    {
        var valorMensal = _vendasNegocio.CalcularMediaMensal(4, 2021);
        Assert.Equal(478m, valorMensal);
    }
}
