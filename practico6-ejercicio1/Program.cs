internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int a, b;
        a=10;
        b=a;
        Console.WriteLine("valor de a:"+a);
        Console.WriteLine("valor de b:"+b);

        int n,aux;
        Console.WriteLine("Ingrese un valor");
        var valor = Console.ReadLine();
        bool resultado = int.TryParse(valor,out n);

        if (resultado)
        {
            if (n>0)
            {
                Console.Write("Numero invertido: ");
                while (n>0)
                {
                    aux=n%10;
                    Console.Write(aux);
                    n/=10;
                }
            }else
            {
                Console.WriteLine("Numero no valido");
            }
        }else
        {
            Console.WriteLine("No se pudo convertir a entero");
        }
    }
}