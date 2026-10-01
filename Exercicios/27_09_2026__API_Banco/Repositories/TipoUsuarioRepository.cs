file:///home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API_Banco/server/Repositories/TipoUsuarioRepository.cs {"mtime":1790729935227,"ctime":1790729935227,"size":740,"etag":"3gnf5lrh8nr","orphaned":false,"typeId":""}
using BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly AppDbContext ctx;
        public TipoUsuarioRepository(AppDbContext _ctx)
        {
            ctx = _ctx;
        }

        public asybc Task<List<tipo_usuario>> Listar() => ctx.tipo_usuario.ToList();

        public tipo_usuario ObterPorId(int id) => ctx.tipo_usuario.Find(id);

        public void Adicionar(tipo_usuario tipoUsu)
        {
            ctx.tipo_usuario.Add(tipoUsu);
            ctx.SaveChanges();
        }

        public void Atualizar(tipo_usuario tipoUsu)
        {
            ctx.tipo_usuario.Update(tipoUsu);
            ctx.SaveChanges();
        }
    }
}