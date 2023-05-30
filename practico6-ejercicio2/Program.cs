internal class Program
{
    const int indefinido = -9999;
    private static void Main(string[] args)
    {
        int flag = 1;
        int a,b,Operacion;
        int ResultadoOperacion;

        while(flag == 1){

            Console.WriteLine("Ingrese la operacion que desea realizar:\n-1:suma\n-2:resta\n-3:Producto\n-4:Cociente\n-5:Salir");
            var codigo = Console.ReadLine();
            bool resultado = int.TryParse(codigo, out Operacion);

            if (resultado &&  (1<=Operacion && Operacion<=5))
            {
                if (Operacion!=5)
                {
                    Console.WriteLine("Ingrese el primer numero");
                    var NumA = Console.ReadLine();
                    bool resultadoA = int.TryParse(NumA, out a);

                    Console.WriteLine("Ingrese el segundo numero");
                    var NumB = Console.ReadLine();
                    bool resultadoB = int.TryParse(NumB, out b);

                    if (resultadoA && resultadoB)
                    {
                        switch (Operacion)
                        {
                            case 1:
                                ResultadoOperacion = Calculadora(a,b,Operacion);
                                Console.WriteLine(a + "+" + b + "=" + ResultadoOperacion);
                                break;
                            case 2:
                                ResultadoOperacion = Calculadora(a,b,Operacion);
                                Console.WriteLine(a + "-" + b + "=" + ResultadoOperacion);
                                break;
                            case 3:
                                ResultadoOperacion = Calculadora(a,b,Operacion);
                                Console.WriteLine(a + "*" + b + "=" + ResultadoOperacion);
                                break;
                            case 4:
                                ResultadoOperacion = Calculadora(a,b,Operacion);
                                Console.WriteLine(a + "/" + b + "=" + ResultadoOperacion);
                                break;
                        }
                    }else
                    {
                        Console.WriteLine("Error al ingresar numeros");
                    }
                }else
                {
                    flag = 0;
                    Console.WriteLine("calculadora finalizada");
                }

            }else
            {
                Console.WriteLine("Operacion incorrecta");
            }
        }
    }
    
    static int Calculadora(int a, int b, int CodigoOperacion){
        switch (CodigoOperacion)
        {
            case 1:
                return a+b;
            case 2:
                return a-b;
            case 3:
                return a*b;
            case 4:
                if (b>0)
                {
                    return a/b;
                }else
                {
                    return indefinido;
                }
            default:
                return indefinido;
        }
    }
   
}