namespace TecnologiaObjetosPracticaFinal;

public class ArchivoAsignacion
{
    public int ArchivoAsignacionId { get; set; }
    public Asignacion Asignacion { get; set; }
    public Archivo Archivo { get; set; }


    public ArchivoAsignacion() { }


    public ArchivoAsignacion(int archivoAsignacionId, Asignacion asignacion, Archivo archivo)
    {
        ArchivoAsignacionId = archivoAsignacionId;
        Asignacion = asignacion;
        Archivo = archivo;
    }


    public int ObtenerTamañoArchivo() => Archivo?.ObtenerTamañoArchivo() ?? 0;


    public byte[] DescargarArchivo() => Archivo?.DescargarArchivo();


    public bool SubirArchivo(byte[] contenido)
    {
        if (Archivo == null) return false;
        return Archivo.SubirArchivo(contenido);
    }


    public Estudiante SubidoPor() => Archivo?.Estudiante;
}