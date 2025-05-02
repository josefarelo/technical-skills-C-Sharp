string ume = "02-AZ-M"; // UME = Unidad de mantenimiento de existencias

string[] product = ume.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Buzo";
        break;
    case "02":
        type = "Remera";
        break;
    case "03":
        type = "Pantalón";
        break;
    default:
        type = "Otro";
        break;
}

switch (product[1])
{
    case "NG":
        color = "Negro";
        break;
    case "AZ":
        color = "Azul";
        break;
    default:
        color = "Blanco";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "Talla única para todos";
        break;
}

Console.WriteLine($"Producto: {size} {color} {type}");	// Producto: Medium Azul Remera