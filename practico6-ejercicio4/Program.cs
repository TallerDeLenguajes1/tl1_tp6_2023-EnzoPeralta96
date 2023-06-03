internal class Program
{
    private static void Main(string[] args)
    {
        string cadena1, cadena2, cadena3, palabra;
        do
        {
            Console.WriteLine("Ingrese un texto:");
            cadena1 = Console.ReadLine();

        } while (String.IsNullOrEmpty(cadena1));
        

        //int longitudCadena = cadena1.Length; otra forma
        Console.WriteLine("La longitud de la cadena ingresada es:"+ cadena1.Length);

        do
        {
            Console.WriteLine("Ingrese un segundo texto:");
            cadena2 = Console.ReadLine();
        } while (String.IsNullOrEmpty(cadena2));

        
        cadena3 = string.Concat(cadena1," ",cadena2);
        Console.WriteLine("Cadenas concatenadas:"+cadena3);

        Console.WriteLine("Subcadena de cadena1:" + cadena1.Substring(0,10));

        Console.WriteLine("Recorrido en ciclo foreach:");
        foreach (var caracter in cadena1)
        {
            Console.WriteLine(caracter);
        }
        Console.WriteLine("fin de ciclo foreach:");

        Console.WriteLine("Buscar ocurrencia de una palabra:");
        do
        {
            Console.WriteLine("Ingrese la palabra que desea buscar");
            palabra = Console.ReadLine();
        } while (String.IsNullOrEmpty(palabra));    

        int indice = cadena1.IndexOf(palabra,StringComparison.OrdinalIgnoreCase);
        //indexOf distingue entre mayusculas y minusculas
        //StringComparison.OrdinalIgnoreCase sirve para que la busqueda se haga sin diferenciar Mayus y minusc.
        if (indice!=-1)
        {
            Console.WriteLine("La palabra {0} fue encontrada en el indice {1}",palabra, indice);
        }else
        {
            Console.WriteLine("La palabra {0} NO fue encontrada",palabra);
        }

        cadena1 = cadena1.ToUpper();
        Console.WriteLine("cadena en mayusculas:"+cadena1);
        cadena1 = cadena1.ToLower();
        Console.WriteLine("cadena en minusculas:"+cadena1);
        
        string[] cadena4 = cadena1.Split(' ');
        foreach (string subCadena in cadena4)
        {
            Console.WriteLine(subCadena);
        }


    }
}