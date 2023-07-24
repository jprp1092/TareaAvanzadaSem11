using JN_WEB.Entities;
using System.Net.Http.Headers;
using System.Net.Http;
using JN_WEB.Interfaces;

namespace JN_WEB.Models
{
    public class CursosModel : ICursosModel
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private string _baseUrl;

        public CursosModel(HttpClient httpClient, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _baseUrl = _configuration.GetSection("Variables:urlBase").Value;
            _HttpContextAccessor = httpContextAccessor;
        }

        public CursoEntRespuesta? ConsultarCursos()
        {
            string token = _HttpContextAccessor.HttpContext.Session.GetString("TokenUsuario");
            string url = "/api/Curso/ConsultarCursos";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = _httpClient.GetAsync(_baseUrl + url).Result;
            return response.Content.ReadFromJsonAsync<CursoEntRespuesta>().Result;
        }

        public CursoEntRespuesta? ConsultarCursosUsuario()
        {
            string token = _HttpContextAccessor.HttpContext.Session.GetString("TokenUsuario");
            string url = "/api/Curso/ConsultarCursosUsuario";

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = _httpClient.GetAsync(_baseUrl + url).Result;
            return response.Content.ReadFromJsonAsync<CursoEntRespuesta>().Result;
        }

    }
}
