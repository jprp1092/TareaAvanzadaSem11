namespace JN_WEB.Entities
{
    public class CursoEntRespuesta
    {
        public int Codigo { get; set; }
        public string Mensaje { get; set; } = string.Empty;
        public CursoEnt Objeto { get; set; } = null;
        public List<CursoEnt> Objetos { get; set; } = new List<CursoEnt>();
        public bool ResultadoTransaccion { get; set; }
    }

    public class CursoEnt
    {
        public long IdCurso { get; set; }
        public decimal Precio { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Instructor { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime Finalizacion { get; set; }
        public int Cupo { get; set; }
        public string Imagen { get; set; } = string.Empty;
    }
}
