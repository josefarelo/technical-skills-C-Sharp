class Program
{
    static void Main()
    {
        string listaCompras = "Leche, pan, huevos, jamón, queso, pan integral, yogur";
        
        // IndexOf para encontrar la primera vez que aparece un producto
        int primeraAparicionPan = listaCompras.IndexOf("pan");
        Console.WriteLine($"La palabra 'pan' aparece por primera vez en la posición: {primeraAparicionPan}");
        
        // LastIndexOf para encontrar la última vez que aparece un producto
        int ultimaAparicionPan = listaCompras.LastIndexOf("pan");
        Console.WriteLine($"La palabra 'pan' aparece por última vez en la posición: {ultimaAparicionPan}");
        
        // IndexOfAny para buscar productos que empiezan con ciertas letras
        char[] letrasBuscadas = { 'L', 'h', 'q' };
        int primerProductoConLetras = listaCompras.IndexOfAny(letrasBuscadas);
        Console.WriteLine($"El primer producto que empieza con L, h o q está en la posición: {primerProductoConLetras}");
        
        Console.WriteLine("\n--- Análisis de la lista ---");
        Console.WriteLine($"Texto completo: \"{listaCompras}\"");
        Console.WriteLine($"Primer 'pan': posición {primeraAparicionPan} -> \"{listaCompras.Substring(primeraAparicionPan, 3)}\"");
        Console.WriteLine($"Último 'pan': posición {ultimaAparicionPan} -> \"{listaCompras.Substring(ultimaAparicionPan, 10)}\"");
        Console.WriteLine($"Primera letra L/h/q: posición {primerProductoConLetras} -> \"{listaCompras[primerProductoConLetras]}\"");
    }
}

/*
    La palabra 'pan' aparece por primera vez en la posición: 7
    La palabra 'pan' aparece por última vez en la posición: 34
    El primer producto que empieza con L, h o q está en la posición: 0

    --- Análisis de la lista ---
    Texto completo: "Leche, pan, huevos, jamón, queso, pan integral, yogur"
    Primer 'pan': posición 7 -> "pan"
    último 'pan': posición 34 -> "pan integr"
    Primera letra L/h/q: posición 0 -> "L"
*/