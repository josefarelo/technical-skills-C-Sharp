// Realización de conversiones de datos

// Uso de ToString() para convertir un número en string
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); // 57

// Convertir un objeto string en int mediante el método Parse() auxiliar
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); // 12

// Convertir un objeto string en int mediante la clase Convert
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); // 35

// Comparar la coerción trunca y la conversión redondea
int value = (int)1.5m; // truncamiento
Console.WriteLine(value); // 1

int value2 = Convert.ToInt32(1.5m); // conversión redondeada
Console.WriteLine(value2); // 2

// Convertir una cadena en un entero con TryParse()
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Medición: {result}");
} else {
    Console.WriteLine("No se puede informar la medición.");
}
Console.WriteLine($"Medición (con desplazamiento): {50 + result}");


// Combinar valores de matriz de cadenas como cadenas y como desafío de enteros
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}"); // ABCDEF
Console.WriteLine($"Total: {total}"); // 68.3