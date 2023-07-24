using JN_WEB.Entities;
using static JN_WEB.Entities.CursoEnt;

namespace JN_WEB.Interfaces
{
    public interface ICursosModel
    {

        public CursoEntRespuesta? ConsultarCursos();

        public CursoEntRespuesta? ConsultarCursosUsuario();

    }
}
