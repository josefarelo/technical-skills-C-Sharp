// Sumas con conversión implícita de datos
int twelve = 12;
int seven = 7;
Console.WriteLine(twelve + seven);  // 19


// Operaciones matemáticas
int A = 15;
int B = 10;

int sum = A + B;
int difference = A - B;
int product = A * B;
int quotient = A / B;
decimal decimalQuotient = 15.5m / B;
decimal intToDecimalQuotient = (decimal)A / (decimal)B;

Console.WriteLine($"Sum: {sum}");   // 25
Console.WriteLine($"Difference: {difference}"); // 5
Console.WriteLine($"Product: {product}");   // 150
Console.WriteLine($"Quotient: {quotient}"); // 1
Console.WriteLine($"Decimal quotient: {decimalQuotient}");  // 1,55
Console.WriteLine($"Int to Decimal quotient: {intToDecimalQuotient}");  // 1,5
// El operador Módulo % indica el resto de la división int
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");   // Modulus of 200 / 5 : 0
Console.WriteLine($"Modulus of A / B : {A % B}");   // Modulus of A / B : 2


// Práctica

int currentAssignments = 5;

int marcelo1 = 93;
int marcelo2 = 87;
int marcelo3 = 98;
int marcelo4 = 95;
int marcelo5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int noelia1 = 84;
int noelia2 = 96;
int noelia3 = 73;
int noelia4 = 85;
int noelia5 = 79;

int alvaro1 = 90;
int alvaro2 = 92;
int alvaro3 = 98;
int alvaro4 = 100;
int alvaro5 = 97;

decimal marceloAvrScore = (decimal)(marcelo1 + marcelo2 + marcelo3 + marcelo4 + marcelo5) / currentAssignments;
decimal nicolasAvrScore = (decimal)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
decimal noeliaAvrScore = (decimal)(noelia1 + noelia2 + noelia3 + noelia4 + noelia5) / currentAssignments;
decimal alvaroSum = (decimal)(alvaro1 + alvaro2 + alvaro3 + alvaro4 + alvaro5) / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");                // Student		Grade
Console.WriteLine("Marcelo:\t" + marceloAvrScore);      // Marcelo:	    94,6
Console.WriteLine("Nicolas:\t" + nicolasAvrScore);      // Nicolas:	    83,6
Console.WriteLine("Noelia:\t\t" + noeliaAvrScore);      // Noelia:		83,4
Console.WriteLine("Alvaro:\t\t" + alvaroSum);           // Alvaro:		95,4