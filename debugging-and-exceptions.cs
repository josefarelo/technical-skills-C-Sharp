// Excepciones personalizadas para manejo de errores específicos
public class PagoInsuficienteException : Exception
{
    public PagoInsuficienteException(string mensaje) : base(mensaje) { }
}

public class ValorNegativoException : Exception
{
    public ValorNegativoException(string mensaje) : base(mensaje) { }
}

public class CambioInsuficienteException : Exception
{
    public CambioInsuficienteException(string mensaje) : base(mensaje) { }
}

public class CajaRegistradora
{
    private int billetes20;
    private int billetes10;
    private int billetes5;
    private int billetes1;
    
    public CajaRegistradora(int b20, int b10, int b5, int b1)
    {
        billetes20 = b20;
        billetes10 = b10;
        billetes5 = b5;
        billetes1 = b1;
    }
    
    public void CalcularCambio(decimal total, decimal pago)
    {
        Console.WriteLine($"\nOperación: Total = ${total}, Pago = ${pago}");
        
        // Rechazar valores negativos
        if(total < 0 || pago < 0)
            throw new ValorNegativoException("Error: No se aceptan valores negativos");
        
        // Verificar pago suficiente
        if(pago < total)
            throw new PagoInsuficienteException($"Error: El pago (${pago}) no cubre el total (${total})");
        
        // Calcular cambio a devolver
        int cambio = (int)(pago - total);
        int resto = cambio;
        
        Console.WriteLine($"Cambio a devolver: ${cambio}");
        
        // Hacer copias temporales de los billetes disponibles
        int temp20 = billetes20;
        int temp10 = billetes10;
        int temp5 = billetes5;
        int temp1 = billetes1;
        
        try
        {
            // Proceso de entrega de billetes
            EntregarBilletes(ref resto, 20, ref temp20);
            EntregarBilletes(ref resto, 10, ref temp10);
            EntregarBilletes(ref resto, 5, ref temp5);
            EntregarBilletes(ref resto, 1, ref temp1);
            
            // Verificar si se pudo dar todo el cambio
            if(resto > 0)
                throw new CambioInsuficienteException($"Error: Faltan ${resto} por entregar (billetes insuficientes)");
            
            // Actualizar los billetes disponibles si todo fue exitoso
            billetes20 = temp20;
            billetes10 = temp10;
            billetes5 = temp5;
            billetes1 = temp1;
            
            Console.WriteLine("¡Cambio entregado correctamente!");
        }
        catch
        {
            throw new CambioInsuficienteException("Error: No se pudo completar la entrega del cambio");
        }
    }
    
    private void EntregarBilletes(ref int resto, int valorBillete, ref int disponibles)
    {
        int cantidad = Math.Min(resto / valorBillete, disponibles);
        resto -= cantidad * valorBillete;
        disponibles -= cantidad;
        
        if(cantidad > 0)
            Console.WriteLine($" - Entregando {cantidad} billete(s) de ${valorBillete}");
    }
    
    public void MostrarDisponible()
    {
        Console.WriteLine("\nBilletes disponibles:");
        Console.WriteLine($" - $20: {billetes20}");
        Console.WriteLine($" - $10: {billetes10}");
        Console.WriteLine($" - $5: {billetes5}");
        Console.WriteLine($" - $1: {billetes1}");
    }
}

class Programa
{
    static void Main()
    {
        Console.WriteLine("Sistema de Caja Registradora");
        Console.WriteLine("---------------------------");
        
        // Inicializar la caja con 5 billetes de cada denominación
        CajaRegistradora miCaja = new CajaRegistradora(5, 5, 5, 5);
        miCaja.MostrarDisponible();
        
        // Ejemplos de operaciones
        ProbarOperacion(miCaja, 35, 100);    // Caso exitoso
        ProbarOperacion(miCaja, 100, 50);    // Pago insuficiente
        ProbarOperacion(miCaja, -10, 50);    // Valor negativo
        ProbarOperacion(miCaja, 18, 50);     // Caso exitoso
        
        // Probar con caja limitada
        CajaRegistradora cajaLimitada = new CajaRegistradora(1, 0, 3, 10);
        cajaLimitada.MostrarDisponible();
        ProbarOperacion(cajaLimitada, 12, 50);  // Cambio justo
        ProbarOperacion(cajaLimitada, 15, 50);  // Falta cambio
    }
    
    static void ProbarOperacion(CajaRegistradora caja, decimal total, decimal pago)
    {
        try
        {
            caja.CalcularCambio(total, pago);
            caja.MostrarDisponible();
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
        }
    }
}