namespace Act1._5;

class Program
{
    static void Main(string[] args)
    {
       int respuesta;
        menu();
        switch (respuesta)
        {
            case 1:
            string nombre;
            int DNI;
            Console.WriteLine("Ingrese el nombre del alumno");
            nombre = Console.ReadLine();
            Console.WriteLine($"Ingrese el dni de {nombre}");
            DNI = int.TryParse(Console.ReadLine()); 
            curso.agregarAlumno();
            break;
            
            
            
        }
    }
    static void terminal()
    {
        System.Console.WriteLine("Ingrese la operacion que quiera realizar");
        System.Console.WriteLine();
        System.Console.WriteLine("1.Agregar nuevos alumnos, 2. Buscar un alumno por su dni, 3. Agregar una falta o media falta a un alumno, 4. Mostrar todos los alumnos, 5. Mostrar alumnos libres");

    }
    static int menu()
    {
        int respuesta;
        do
        {
            bool escorrecto = false;
            terminal();
            escorrecto = int.TryParse(Console.ReadLine(), out respuesta); 
            if(respuesta< 1 || respuesta>6)
            {
                System.Console.WriteLine("Error, no existe esa opcion");
            }
        } while (!escorrecto);
        return respuesta;
    }
    static int devolverInt()
    {
        int respuesta
        respuesta = int.TryParse(Console.ReadLine(), out respuesta); 
        return respuesta;
    }
}
