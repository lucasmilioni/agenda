namespace Agenda.Presentation.Models
{
    /// <summary>
    /// Modelo de dados para as informações do usuario autenticado que serão gravadas no COOKIE de autenticação do ASPNET
    /// </summary>
    public class AuthenticationModel
    {
        public Guid IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataHoraAcesso { get; set; }
    }
}
  