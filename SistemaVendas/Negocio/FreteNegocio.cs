namespace SistemaVendas.Negocio;

public class FreteNegocio
{
    public decimal CalcularFrete(int distanciaKm)
    {
        decimal valorFrete;
        if(distanciaKm <= 5)
        {
            valorFrete = 0.00m;
        }
        else if(distanciaKm > 5 && distanciaKm < 15)
        {
            valorFrete = 10.00m;
        }
        else
        {
            valorFrete = 30.00m;
        }
        return valorFrete;
    }
}
