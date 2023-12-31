﻿using JN_WEB.Entities;

namespace JN_WEB.Interfaces
{
    public interface IUsuariosModel
    {

        public UsuarioEntRespuesta? IniciarSesion(UsuarioEnt entidad);
        public UsuarioEntRespuesta? RegistrarUsuario(UsuarioEnt entidad);
        public UsuarioEntRespuesta? RecuperarContrasenna(UsuarioEnt entidad);
        public UsuarioEntRespuesta? CambiarContrasenna(UsuarioEnt entidad);
        public UsuarioEntRespuesta? ConsultarUsuarios();
        public UsuarioEntRespuesta? ConsultarUsuario(long q);
        public UsuarioEntRespuesta? CambiarEstado(UsuarioEnt entidad);
        public RolEntRespuesta? ConsultarRoles();
        public string Encrypt(string toEncrypt);

    }
}
