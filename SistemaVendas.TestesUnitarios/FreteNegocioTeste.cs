using SistemaVendas.Negocio;

namespace SistemaVendas.TestesUnitarios;

public class FreteNegocioTeste
{

    [Theory(DisplayName = "Deve calcular o valor do frete de até 5km com sucesso")]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    [InlineData(0)]
    public void DeveCalcularValorDoFreteAte5KmComSucesso(short distanciaKm)
    {
        var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

        Assert.Equal(0.00m, valorFrete);
    }

    [Theory(DisplayName = "Deve calcular o valor do frete de maior que 5km e menor que 15km com sucesso")]
    [InlineData(6)]
    [InlineData(7)]
    [InlineData(10)]
    [InlineData(11)]
    [InlineData(14)]
    public void DeveCalcularValorDoFreteMaiorQue5KmEMenorQue15KmComSucesso(short distanciaKm)
    {
        var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

        Assert.Equal(10.00m, valorFrete);
    }

    [Theory(DisplayName = "Deve calcular o valor do frete maior ou igual a 15km com sucesso")]
    [InlineData(15)]
    [InlineData(100)]
    [InlineData(200)]
    [InlineData(500)]
    [InlineData(1000)]
    public void DeveCalcularValorDoFreteMaiorIgualA15KmComSucesso(short distanciaKm)
    {
        var valorFrete = new FreteNegocio().CalcularFrete(distanciaKm);

        Assert.Equal(30.00m, valorFrete);
    }
}