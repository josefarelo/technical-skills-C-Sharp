// Agregar lógica de bifurcación mediante las instrucciones if, else if y else

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Tirada de dados: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("Has sacado dobles! +2 bonus en el total!");
    total += 2;
}

if (total >= 16)
{
    Console.WriteLine("Ganaste una mazo de cartas especial y una figura!");
}
else if (total >= 10)
{
    Console.WriteLine("Ganaste un mazo de cartas!");
}
else if (total == 7)
{
    Console.WriteLine("Ganaste un peluche!");
}
else
{
    Console.WriteLine("No ganaste nada.");
}
