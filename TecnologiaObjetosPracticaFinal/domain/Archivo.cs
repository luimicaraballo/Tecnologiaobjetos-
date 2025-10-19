namespace TecnologiaObjetosPracticaFinal;

public class Archivo
{
    public int ArchivoId { get; set; }
    public string Nombre { get; set; }
    public byte[] Contenido { get; set; }
    public string Formato { get; set; }
    public DateTime FechaSubida { get; set; }
    public Estudiante Estudiante { get; set; }


    public Archivo() { }


    public Archivo(int archivoId, string nombre, byte[] contenido, string formato, DateTime fechaSubida, Estudiante estudiante)
    {
        ArchivoId = archivoId;
        Nombre = nombre;
        Contenido = contenido;
        Formato = formato;
        FechaSubida = fechaSubida;
        Estudiante = estudiante;
    }


    public virtual int ObtenerTamañoArchivo() => Contenido?.Length ?? 0;


    public virtual byte[] DescargarArchivo()
    {
// Return a copy to simulate download
        return Contenido == null ? null : (byte[])Contenido.Clone();
    }


    public virtual bool SubirArchivo(byte[] contenido)
    {
        if (contenido == null) return false;
        Contenido = contenido;
        FechaSubida = DateTime.Now;
        return true;
    }


    public bool ValidarTamaño(int maxBytes)
    {
        return ObtenerTamañoArchivo() <= maxBytes;
    }
}
