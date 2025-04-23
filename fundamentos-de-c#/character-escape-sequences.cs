// Secuencias de escape de cáracteres
Console.WriteLine("Agregar\nNueva línea");  // \n agrega una nueva línea
Console.WriteLine("Agregar\tTabulación");   // \t agrega una tabulación
Console.WriteLine("Agregar \"Comillas\"");  // \"Texto\" agrega las comillas

// Literal de cadena textual
Console.WriteLine(@"    Con @ antes de la cadena literal
    Se respetarán todos los espacios en blanco.");

// Concatenación de una cadena de literales y una variable  
string greeting = "Hola, soy";
string firstName = "José";
string message = "Hola, soy " + firstName;
string message1 = greeting + " " + firstName;
string message2 = $"{greeting} {firstName}";
Console.WriteLine(message);
Console.WriteLine(message1);
Console.WriteLine(message2);