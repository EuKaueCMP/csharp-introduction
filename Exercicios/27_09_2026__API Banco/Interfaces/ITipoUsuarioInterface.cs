using BancoAPI.Domains;

namespace BancoAPI
{
    public interface ITipoUsuarioInterface
    {
        public List<tipo_usuario> Listar();
        public tipo_usuario ObterPorId(int id);
        public void Adicionar(tipo_usuario tipoUsuario);
        public void Altualizar(int id, tipo_usuario tipoUsuario);
    }
}