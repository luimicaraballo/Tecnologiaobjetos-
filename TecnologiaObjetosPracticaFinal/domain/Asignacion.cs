namespace TecnologiaObjetosPracticaFinal;

public class Asignacion
{
    public int AsignacionId { get; set; }
    public Estudiante Estudiante { get; set; }
    public Tarea Tarea { get; set; }
    public Participacion AsignadaPor { get; set; }
    public DateTime FechaAsignacion { get; set; }
    public List<ArchivoAsignacion> ArchivosAsignacion { get; set; } = new List<ArchivoAsignacion>();

    public Asignacion(int asignacionId, Estudiante estudiante, Tarea tarea, Participacion asignadaPor)
    {
        AsignacionId = asignacionId;
        Estudiante = estudiante;
        Tarea = tarea;
        AsignadaPor = asignadaPor;
        FechaAsignacion = DateTime.Now;
    }


    public void AgregarArchivoAsignacion(ArchivoAsignacion archivoAsignacion)
    {
        if (archivoAsignacion != null && !ArchivosAsignacion.Contains(archivoAsignacion))
        {
            ArchivosAsignacion.Add(archivoAsignacion);
        }
    }
}
