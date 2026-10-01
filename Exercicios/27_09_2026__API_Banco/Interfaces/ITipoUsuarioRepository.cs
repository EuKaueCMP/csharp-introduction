using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoUsuarioRepository
    {
        public Task<List<tipo_usuario>> Listar();
        public Task<tipo_usuario> ObterPorId(int id);
        public void Adicionar(tipo_usuario tipoUsuario);
        public void Atualizar(tipo_usuario tipoUsuario);
    }
}