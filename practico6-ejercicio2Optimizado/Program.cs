using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
       bool flag = true,flag2= true, resultadoA,resultadoB, resultadoC;
       string input, inputA,inputB,inputC;
       int option;
       float a,b,c;

       while (flag)
       {
            do
            {
                Console.WriteLine("Ingrese la operacion que desea realizar:\n");
                Console.WriteLine("-1:Suma\n-2:Resta\n-3:Producto\n-4:Cociente\n-5:Operaciones avanzadas\n-6:Salir");
                input = Console.ReadLine()!;
            } while (string.IsNullOrEmpty(input));

            bool resultadoOption = int.TryParse(input,out option);
            if (resultadoOption && 1<=option && option<=6)
            {
                if (1<=option && option<=4)
                {
                    do
                    {
                        Console.WriteLine("ingrese el primer numero:");
                        inputA = Console.ReadLine()!;
                        Console.WriteLine("ingrese el segundo numero:");
                        inputB = Console.ReadLine()!;
                    } while (string.IsNullOrEmpty(inputA) && string.IsNullOrEmpty(inputB));

                    resultadoA = float.TryParse(inputA, NumberStyles.Float,CultureInfo.InvariantCulture, out a);
                    resultadoB = float.TryParse(inputB, NumberStyles.Float,CultureInfo.InvariantCulture, out b);

                    if (resultadoA && resultadoB)
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine(inputA+"+"+inputB+"="+(a+b));
                                break;
                            case 2:
                                Console.WriteLine(inputA+"-"+inputB+"="+(a-b));
                                break;
                            case 3:
                                Console.WriteLine(inputA+"*"+inputB+"="+(a*b));
                                break;
                            case 4:
                                Console.WriteLine(inputA+"/"+inputB+"="+(a/b));
                                break;
                        }
                    }else
                    {
                        Console.WriteLine("Error al ingresar operandos");
                    }
                }else
                {
                    if (option == 5)
                    {
                        while (flag2)
                        {
                            do
                            {
                                Console.WriteLine("Operaciones Avanzadas:\n");
                                Console.WriteLine("-1:V abs\n-2:Cuadrado\n-3:Raiz cuadrada\n-4:Sen(x)\n-5:Cos(x)\n-6:Parte entera\n-7:Resolver a+b\n-8:Volver");
                                input = Console.ReadLine()!;
                            } while (string.IsNullOrEmpty(input));

                            resultadoOption = int.TryParse(input,out option);

                            if (resultadoOption && 1<=option && option<=8)
                            {
                                if (1<=option && option<=6)
                                {
                                    do
                                    {
                                        Console.WriteLine("Ingrese valor:");
                                        inputC = Console.ReadLine()!;
                                        
                                    } while (string.IsNullOrEmpty(inputC));

                                    resultadoC = float.TryParse(inputC, NumberStyles.Float,CultureInfo.InvariantCulture, out c);

                                    if (resultadoC)
                                    {
                                        switch (option)
                                        {
                                            case 1:
                                                Console.WriteLine("V abs({0})="+Math.Abs(c),c);
                                                break;
                                            case 2:
                                                Console.WriteLine("Potencia:"+Math.Pow(c,2));
                                                break;
                                            case 3:
                                                Console.WriteLine("raiz:"+Math.Sqrt(c));
                                                break;
                                            case 4:
                                                Console.WriteLine("sen()="+Math.Sin(c));
                                                break;
                                            case 5:
                                                Console.WriteLine("cos()="+Math.Cos(c));
                                                break;
                                            case 6:
                                                Console.WriteLine("parte entera:"+Math.Floor(c));
                                                break;
                                        }
                                    }else
                                    {
                                        Console.WriteLine("Error numero");
                                    }
                                }else
                                {
                                    if (option==7)
                                    {
                                        do
                                        {
                                            Console.WriteLine("Ingrese operacion de la forma a+b:");
                                            inputC = Console.ReadLine()!;  
                                        } while (string.IsNullOrEmpty(inputC));

                                        string[] operandos = inputC.Split("+");
                                        resultadoA = float.TryParse(operandos[0], NumberStyles.Float,CultureInfo.InvariantCulture, out a);
                                        resultadoB = float.TryParse(operandos[1], NumberStyles.Float,CultureInfo.InvariantCulture, out b);
                                        if (resultadoA && resultadoB)
                                        {
                                            Console.WriteLine(inputC+"="+(a+b));
                                        }else
                                        {
                                            Console.WriteLine("Error al ingresar expresion");
                                        }

                                    }else
                                    {
                                        flag2=false;
                                    }
                                }
                            }else
                            {
                                Console.WriteLine("Opcion incorrecta");
                            }
                        }  
                    }else
                    {
                        flag = false;
                    } 
                }
            }else
            {
                Console.WriteLine("Opcion incorrecta");
            }
        }
    }    
}