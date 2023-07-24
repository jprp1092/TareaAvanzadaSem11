using JN_WEB.Entities;

namespace JN_WEB.Interfaces
{
    public interface ICarritoModel
    {
        public CarritoEntRespuesta? AgregarCursoCarrito(CarritoEnt entidad);
        public CarritoEntRespuesta? ConsultarResumenCarrito();
    }
}
