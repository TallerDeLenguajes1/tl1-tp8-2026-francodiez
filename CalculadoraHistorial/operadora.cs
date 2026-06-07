namespace operadora;
public enum TipoOperacion{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar // Representa la acción de borrar el resultado actual o el historial
}

public class Operacion{
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
    private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
    private TipoOperacion operacion;// El tipo de operación realizada
    public double Resultado{
        get{
            switch(operacion){
                case TipoOperacion.Suma:
                    return resultadoAnterior + nuevoValor;
                case TipoOperacion.Resta:
                    return resultadoAnterior - nuevoValor;
                case TipoOperacion.Multiplicacion:
                    return resultadoAnterior * nuevoValor;
                case TipoOperacion.Division:
                    return resultadoAnterior / nuevoValor;
                case TipoOperacion.Limpiar:
                    return 0;
                default:
                    return resultadoAnterior;
            }
        }
    }
// Propiedad pública para acceder al nuevo valor utilizado en la operación
    public double NuevoValor{
        get => nuevoValor;
    }

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }
}

public class Calculadora
{
    private double resultadoActual; 
    public double ResultadoOp
    {
        get => resultadoActual;
    }
    
    private List<Operacion> historial;

    public Calculadora() //cuando se crea para que empieze en 0
    {
        resultadoActual = 0;
        historial = new List<Operacion>();
    }

    public void Sumar(double termino)
    {
        double anterior = resultadoActual;
        
        resultadoActual =resultadoActual + termino;

        Operacion nuevaOp = new Operacion(anterior, termino, TipoOperacion.Suma);
        historial.Add(nuevaOp);
    }

    public void Restar(double termino)
    {
        double anterior = resultadoActual;
        
        resultadoActual =resultadoActual - termino;

        Operacion nuevaOp = new Operacion(anterior, termino, TipoOperacion.Resta);
        historial.Add(nuevaOp);
    }

    public void Multiplicar(double termino)
    {
        double anterior = resultadoActual;
        
        resultadoActual =resultadoActual * termino;

        Operacion nuevaOp = new Operacion(anterior, termino, TipoOperacion.Multiplicacion);
        historial.Add(nuevaOp);
    }

    public void Dividir(double termino)
    {
        double anterior = resultadoActual;
        
        resultadoActual =resultadoActual / termino;

        Operacion nuevaOp = new Operacion(anterior, termino, TipoOperacion.Division);
        historial.Add(nuevaOp);
    }

    public void Limpiar()
    {
        double anterior = resultadoActual;
        
        resultadoActual =0;

        Operacion nuevaOp = new Operacion(anterior, 0, TipoOperacion.Limpiar);
        historial.Add(nuevaOp);
    }

    public void MostrarHistorial()
    {
        foreach(Operacion op in historial)
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"Valor ingresado:{op.NuevoValor}");
            Console.WriteLine($"Resultado de la operacion:{op.Resultado}");
        }
    }
}