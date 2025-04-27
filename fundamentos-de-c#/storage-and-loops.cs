// Fundamentos de las matrices
string[] codesIDs = new string[5];

codesIDs[0] = "A123";
codesIDs[1] = "B456";
codesIDs[2] = "C789";
codesIDs[3] = "D101";
codesIDs[4] = "E112";
codesIDs[5] = "F131";

string[] newCodesIDs = [ "A131", "B112", "C101", "D789", "E456", "F123" ];
Console.WriteLine($"Codes IDs: {codesIDs}.");

codesIDs[0] = "G415";
Console.WriteLine($"Reassign First Code: {codesIDs[0]}");



// Implementación de la instrucción foreach
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Resuitado total: {sum})");
}
Console.WriteLine($"Tenemos {sum} items en el inventario.");



// Implementación de bucle DO-WHILE
int counter = 1;

do
{
    Console.WriteLine($"Iteración número: {counter}");
    counter++;
} while (counter <= 5);



// Implementación de bucle WHILE
int numb = 5;

while (numb > 0)
{
    Console.WriteLine($"Número actual: {numb}");
    numb--;
}



// Implementación de bucle FOR
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Valor de i: {i}");
}



// Implementación de bucles

// Creación de un array de números
int[] number = { 10, 20, 30, 40, 50 };

Console.WriteLine("Ejemplo combinado de bucles con arrays");

// Bucle FOR para rellenar un array
int[] squares = new int[5];
Console.WriteLine("\n1. Rellenando array con FOR:");
for (int i = 0; i < squares.Length; i++)
{
    squares[i] = numbers[i] * numbers[i];
    Console.WriteLine($"Cuadrado de {numbers[i]} = {squares[i]}");
}

// Bucle WHILE para buscar un elemento
Console.WriteLine("\n2. Buscando elemento con WHILE:");
int searchedValue = 900;
int index = 0;
bool found = false;

while (index < squares.Length && !found)
{
    if (squares[index] == searchedValue)
    {
        found = true;
        Console.WriteLine($"¡found {searchedValue} en posición {index}!");
    }
    index++;
}

if (!found)
{
    Console.WriteLine($"{searchedValue} no found en el array");
}

// Bucle DO-WHILE para sumar elementos
Console.WriteLine("\n3. Sumando elementos con DO-WHILE:");
int suma = 0;
int contador = 0;

do
{
    suma += squares[contador];
    Console.WriteLine($"Suma parcial: {suma}");
    contador++;
} while (contador < squares.Length);

Console.WriteLine($"Suma total: {suma}");

// Bucle FOREACH para mostrar elementos
Console.WriteLine("\n4. Mostrando elementos con FOREACH:");
foreach (int num in squares)
{
    Console.WriteLine($"Elemento: {num}");
}