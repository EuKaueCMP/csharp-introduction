using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoUsuarioRepository
    {
        public List<tipo_usuario> Listar();
        public tipo_usuario ObterPorId(int id);
        public void Adicionar(tipo_usuario tipoUsuario);
        public void Atualizar(tipo_usuario tipoUsuario);
    }
}