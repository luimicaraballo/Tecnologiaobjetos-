namespace TecnologiaObjetosPracticaFinal;

public class Proyecto
{
    public int ProyectoId { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public List<Tarea> Tareas { get; set; } = new List<Tarea>();
    public EstadoProyecto EstadoProyecto { get; set; }
    public List<Participacion> Participaciones { get; set; } = new List<Participacion>();

    public Proyecto(int proyectoId, string nombre, string descripcion, EstadoProyecto estado)
    {
        ProyectoId = proyectoId;
        Nombre = nombre;
        Descripcion = descripcion;
        EstadoProyecto = estado;
    }


    public void AgregarTarea(Tarea tarea)
    {
        if (tarea != null && !Tareas.Contains(tarea))
        {
            Tareas.Add(tarea);
            tarea.ProyectoAsignado = this;
        }
    }


    public List<Estudiante> GetIntegrantes()
    {
        return Participaciones.Select(p => p.Estudiante).ToList();
    }


    public void AgregarParticipacion(Participacion participacion)
    {
        if (participacion != null && !Participaciones.Contains(participacion))
        {
            Participaciones.Add(participacion);
        }
    }


    public string ConsultarProgreso()
    {
        if (Tareas.Count == 0) return "Sin tareas";
        var completadas = Tareas.Count(t => t.EstadoTarea == EstadoTarea.COMPLETADA);
        return $"{completadas} / {Tareas.Count} tareas completadas";
    }
}