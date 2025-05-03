// Ordenar alfanumérica con Sort() e invertir el orden con Reverse()
string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

/*
    Sorted...
    -- A11
    -- A13
    -- B12
    -- B14
    
    Reversed...
    -- B14
    -- B12
    -- A13
    -- A11
*/

// Borrar valores de los elementos del array con Clear() y cambiar el número del elemento del array con Resize()
string[] pallets = [ "B14", "A11", "B12", "A13" ];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

/*
    Clearing 2 ... count: 4
    --
    --
    -- B12
    -- A13
    
    Resizing 6 ... count: 6
    --
    --
    -- B12
    -- A13
    -- C01
    -- C02
    
    Resizing 3 ... count: 3
    --
    --
    -- B12
*/


// Métodos de matriz del tipo de datos String

// Usar métodos ToCharArray() y Split() para crear arrays y usar método Join() para crear un string uniendo un array char
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

/*
    3,2,1,c,b,a
    3
    2
    1
    c
    b
    a
*/