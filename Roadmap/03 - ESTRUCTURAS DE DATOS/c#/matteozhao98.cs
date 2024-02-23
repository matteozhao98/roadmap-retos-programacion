using System;

internal class Program
{

    /*
    * EJERCICIO:
    * - Muestra ejemplos de creación de todas las estructuras soportadas por defecto en tu lenguaje.
    * - Utiliza operaciones de inserción, borrado, actualización y ordenación.
    *
    * DIFICULTAD EXTRA (opcional):
    * Crea una agenda de contactos por terminal.
    * - Debes implementar funcionalidades de búsqueda, inserción, actualización y eliminación de contactos.
    * - Cada contacto debe tener un nombre y un número de teléfono.
    * - El programa solicita en primer lugar cuál es la operación que se quiere realizar, y a continuación
    *   los datos necesarios para llevarla a cabo.
    * - El programa no puede dejar introducir números de teléfono no númericos y con más de 11 dígitos.
    *   (o el número de dígitos que quieras)
    * - También se debe proponer una operación de finalización del programa.
    */

    //Estructuras de datos
    //Enum
    enum eDiaSemana
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes,
        Sabado,
        Domingo
    }

    //Array de enteros
    int[] miArray = new int[2];

    //Lista de strings
    List<string> listaNombres = new List<string>();

    //Diccionario
    Dictionary<string, int> edad = new Dictionary<string, int>();

    //Estructuras de control
    //if else
    if(listaNombres.Count == 2) Console.WriteLine("El tamaño de la lista es 2");
    else if(listaNombres.Count > 2) Console.WriteLine("La lista tiene más de 2 valores");
    else Console.WriteLine("La lista tiene menos de 2 valores");

    //for
    for (int i = 0; i<100; i++)
	{
        Console.WriteLine(i);
	}

    //foreach
    foreach (string nombre in listaNombres)
    {
        Console.WriteLine(nombre);
    }

    //while
    int i = 0;
    bool check = true;
    while (check)
    {
        if (i <= 10) Console.WriteLine(i++);
        else check = false;
    }

    //switch
    switch (i)
    {
        case 1: Console.WriteLine("Soy un 1"); break;
        case 2: Console.WriteLine("Soy un 2"); break;
        //etc...
        case 10: Console.WriteLine("Soy un 10"); break;
        default: Console.WriteLine("No voy desde el 1 al 10"); break;
    }

    //Inserción de datos
    string nombre = "Brais";
    listaNombres.Add(nuevaString);

    //Borrado de datos
    edad.Add("Matteo ", 25);
    foreach (var item in edad)
        Console.WriteLine(item);

    //Actualización de datos
    miArray[0] = 1;
    miArray[1] = 2:

    miArray[1] = 3;
}