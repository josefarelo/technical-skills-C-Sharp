// DECLARACIÓN DE VARIABLES


// Creación de variables
string firstName;    // Crea una variable tipo string
firstName = "José";
Console.WriteLine(firstName);

char sex;    // Crea una variable tipo char
sex = 'M';
Console.WriteLine(sex);

int age;    // Crea una variable tipo integer
age = 26;
Console.WriteLine(age);

decimal gradeAverage;    // Crea una variable tipo decimal
gradeAverage = 7.785M;
Console.WriteLine(gradeAverage);

bool studying;    // Crea una variable tipo boolean
studying = true;
Console.WriteLine(studying);

Console.WriteLine($"Hola, me llamo {firstName}, mi sexo es {sex}, tengo {age} años. Mi promedio de notas es {gradeAverage}. Y si preguntan si estoy estudiando, la respuesta es {studying}.");

// Inicializar variable
string initializeVariable = "Así se puede declarar e inicializar una variable";
Console.WriteLine(initializeVariable);


// Variables locales con tipo implícito
var message = "Las variables var deben ser inicializadas.";

