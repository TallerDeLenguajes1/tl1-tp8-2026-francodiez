using operadora;

int opcion;
double n;
Calculadora calcu=new Calculadora();

Console.WriteLine("Tiene una calculadora que permite encadenar operaciones sobre un mismo resultado guardado, empieza con cero");

do
{
    Console.WriteLine("Ingresa una operacion a realizar:\n1-Suma\n2-Resta\n3-Multiplicar\n4-Dividir\n5-Limpiar\n6-Historial\n7-Salir");
    do
    {
        int.TryParse(Console.ReadLine(),out opcion);    
    } while (opcion<1 || opcion>7);
    
    switch (opcion)
    {
        case 1:
        Console.WriteLine("Ingrese un numero");
        double.TryParse(Console.ReadLine(),out n);
        calcu.Sumar(n);
        Console.WriteLine("Resultado:"+calcu.ResultadoOp);
        break;
        case 2:
        Console.WriteLine("Ingrese un numero");
        double.TryParse(Console.ReadLine(),out n);
        calcu.Restar(n);
        Console.WriteLine("Resultado:"+calcu.ResultadoOp);
        break;
        case 3:
        Console.WriteLine("Ingrese un numero");
        double.TryParse(Console.ReadLine(),out n);
        calcu.Multiplicar(n);
        Console.WriteLine("Resultado:"+calcu.ResultadoOp);
        break;
        case 4:
        Console.WriteLine("Ingrese un numero distinto de cero");
        do{
            double.TryParse(Console.ReadLine(),out n);
        } while (n==0);
        calcu.Dividir(n);
        Console.WriteLine("Resultado:"+calcu.ResultadoOp);
        break;
        case 5:
        calcu.Limpiar();
        break;
        case 6:
        calcu.MostrarHistorial();
        break;
        default:
        break;
    }
} while (opcion!=7);

