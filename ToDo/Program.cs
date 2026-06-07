using clases;
int ID= 1000;
int opcion=0;
int busqueda;
string descripcion;
Random rand=new Random();

List<Tarea> tareasPendientes=new List<Tarea>();
List<Tarea> tareasRealizadas=new List<Tarea>();

while (opcion != 5)
{
    Console.WriteLine("Opciones:\n1-Cargar tarea\n2-Mover tarea\n3-Buscar tarea\n4-Listar tareas pendientes\n5-Salir");
    do
    {
        int.TryParse(Console.ReadLine(), out opcion);
    } while (opcion<1 || opcion>5);

    switch (opcion)
    {
        case 1:
            ID++;
            Console.WriteLine("Ingrese una descripcion de la tarea");
            descripcion=Console.ReadLine();
            CargarTarea(ID, descripcion);
        break;
        case 2:
            Console.WriteLine("Ingrese el id de la tarea para marcarla como realizada");
            int.TryParse(Console.ReadLine(), out busqueda);
            MoverTarea(tareasPendientes, tareasRealizadas, busqueda);
        break;
    }

}

void CargarTarea(int id, string descripcion)
{
    int durac= rand.Next(10,101);
    tareasPendientes.Add(new Tarea{TareaID=id, Descripcion=descripcion, Duracion=durac});
    Console.WriteLine("Tarea cargada con exito");
}

void MoverTarea(List<Tarea> listaP, List<Tarea> listaR, int id)
{
    bool encontrado=false;
    foreach (Tarea t in listaP)
    {
        if (t.TareaID == id)
        {
            listaR.Add(t);
            listaP.Remove(t);
            Console.WriteLine("Tarea movida con exito");
            encontrado=true;
            break;
        }
    }
    if (!encontrado)
    {
        Console.WriteLine("No se encuentra dicha tarea en la lista de pendientes");
    }
}