namespace TecnologiaObjetosPracticaFinal;

class Program
{
    static List<Proyecto> proyectos = new List<Proyecto>();
    static List<Estudiante> estudiantes = new List<Estudiante>();


    static void Main(string[] args)
    {
        SeedData();
        while (true)
        {
            Console.WriteLine("--- Menu Principal ---");
            Console.WriteLine("1. Crear proyecto");
            Console.WriteLine("2. Listar proyectos");
            Console.WriteLine("3. Crear estudiante");
            Console.WriteLine("4. Asignar estudiante a proyecto");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opcion: ");
            var option = Console.ReadLine();


            switch (option)
            {
                case "1": CrearProyectoMenu(); break;
                case "2": ListarProyectos(); break;
                case "3": CrearEstudianteMenu(); break;
                case "4": AsignarEstudianteProyecto(); break;
                case "5": return;
                default: Console.WriteLine("Opcion no valida"); break;
            }


            Console.WriteLine();
        }
    }


    static void SeedData()
    {
        var u = new Usuario(1, "juan@dominio.com", "1234");
        u.SetPassword("1234");
        var e = new Estudiante(1, "Juan", "Perez", "juan@dominio.com", DateTime.Parse("2000-01-01"), "555-1234",
            "Calle Falsa 123", "MAT001", u);
        estudiantes.Add(e);


        var p = new Proyecto(1, "Proyecto Ejemplo", "Descripcion del proyecto", EstadoProyecto.PLANIFICADO);
        proyectos.Add(p);
        
    }


    static void CrearProyectoMenu()
    {
        Console.Write("Nombre del proyecto: ");
        var nombre = Console.ReadLine();
        Console.Write("Descripcion: ");
        var desc = Console.ReadLine();
        var id = proyectos.Count + 1;
        var p = new Proyecto(id, nombre, desc, EstadoProyecto.PLANIFICADO);
        proyectos.Add(p);
        Console.WriteLine($"Proyecto {nombre} creado con id {id}");
        
        Console.ReadKey();
        Console.Clear();
    }


    static void ListarProyectos()
    {
        foreach (var p in proyectos)
        {
            Console.WriteLine(
                $"Id: {p.ProyectoId} - {p.Nombre} - Estado: {p.EstadoProyecto} - Progreso: {p.ConsultarProgreso()}");
        }
        
        Console.ReadKey();
        Console.Clear();
    }


    static void CrearEstudianteMenu()
    {
        Console.Write("Nombre: ");
        var nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        var apellido = Console.ReadLine();
        Console.Write("Correo: ");
        var correo = Console.ReadLine();
        var id = estudiantes.Count + 1;
        var usuario = new Usuario(id + 100, correo, "init");
        var e = new Estudiante(id, nombre, apellido, correo, DateTime.Now.AddYears(-20), "", "", "MAT" + id,
            usuario);
        estudiantes.Add(e);
        Console.WriteLine($"Estudiante {e.GetNombreCompleto()} creado con id {e.EstudianteId}");
        
        Console.ReadKey();
        Console.Clear();
    }


    static void AsignarEstudianteProyecto()
    {
        Console.WriteLine("Selecciona estudiante por id:");
        foreach (var e in estudiantes) Console.WriteLine($"{e.EstudianteId}: {e.GetNombreCompleto()}");
        if (!int.TryParse(Console.ReadLine(), out var idE)) return;
        var est = estudiantes.Find(x => x.EstudianteId == idE);
        if (est == null)
        {
            Console.WriteLine("Estudiante no encontrado");
            return;
        }


        Console.WriteLine("Selecciona proyecto por id:");
        foreach (var p in proyectos) Console.WriteLine($"{p.ProyectoId}: {p.Nombre}");
        if (!int.TryParse(Console.ReadLine(), out var idP)) return;
        var proy = proyectos.Find(x => x.ProyectoId == idP);
        if (proy == null)
        {
            Console.WriteLine("Proyecto no encontrado");
            return;
        }


        Console.WriteLine("Selecciona rol: 0=LIDER,1=RESPONSABLE,2=COLABORADOR,3=REVISOR");
        if (!int.TryParse(Console.ReadLine(), out var rolInt)) return;
        var rol = (RolEnProyecto)rolInt;


        var participacion = new Participacion(proy.Participaciones.Count + 1, proy, est, rol);
        proy.AgregarParticipacion(participacion);
        Console.WriteLine($"Estudiante {est.GetNombreCompleto()} asignado al proyecto {proy.Nombre} como {rol}");
        
        Console.ReadKey();
        Console.Clear();
    }
}