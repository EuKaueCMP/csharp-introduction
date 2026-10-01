fo] [AutoSync] Triggered by Activity
2026-09-30 14:49:35.579 [info] Sync started.
2026-09-30 14:49:36.049 [info] Settings: No changes found during synchronizing settings.
2026-09-30 14:49:36.053 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 14:49:36.059 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 14:49:36.062 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 14:49:36.065 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 14:49:36.070 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 14:49:36.162 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 14:49:36.164 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 14:49:36.165 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 14:49:36.167 [info] Sync done. Took 589ms
2026-09-30 14:51:08.776 [info] [AutoSync] Triggered by Activity
2026-09-30 14:51:08.777 [info] Sync started.
2026-09-30 14:51:08.951 [info] Settings: No changes found during synchronizing settings.
2026-09-30 14:51:08.954 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 14:51:08.960 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 14:51:08.963 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 14:51:08.966 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 14:51:08.970 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 14:51:09.076 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 14:51:09.080 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 14:51:09.081 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 14:51:09.082 [info] Sync done. Took 307ms
2026-09-30 14:51:33.926 [info] [AutoSync] Triggered by Activity
2026-09-30 14:51:33.926 [info] Sync started.
2026-09-30 14:51:34.099 [info] Settings: No changes found during synchronizing settings.
2026-09-30 14:51:34.107 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 14:51:34.120 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 14:51:34.129 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 14:51:34.139 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 14:51:34.148 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 14:51:34.578 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 14:51:34.587 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 14:51:34.593 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 14:51:34.596 [info] Sync done. Took 671ms
2026-09-30 14:52:11.210 [info] [AutoSync] Triggered by Activity
2026-09-30 14:52:11.210 [info] Sync started.
2026-09-30 14:52:11.384 [info] Settings: No changes found during synchronizing settings.
2026-09-30 14:52:11.386 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 14:52:11.393 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 14:52:11.396 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 14:52:11.398 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 14:52:11.402 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 14:52:11.510 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 14:52:11.514 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 14:52:11.516 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 14:52:11.517 [info] Sync done. Took 308ms
2026-09-30 14:52:37.336 [info] [AutoSync] Triggered by Activity
2026-09-30 14:52:37.336 [info] Sync started.
2026-09-30 14:52:37.602 [info] Settings: No changes found during synchronizing settings.
2026-09-30 14:52:37.605 [info] Keybindings: No changes found during synchronizing keybindingsfile:///home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API_Banco/server/Repositories/TipoMovimentacaoRepository.cs {"mtime":1790790472243,"ctime":1790789843377,"size":880,"etag":"3gni4a2mhsc","orphaned":false,"typeId":""}
using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class TipoMovimentacaoRepository : ITipoAlteracaoRepository
    {
        private readonly AppDbContext ctx;
        public TipoMovimentacaoRepository(AppDbContext _ctx) => _ctx = ctx;

        public Task<List<tipo_movimentacao>> ListarAsync() => await ctx.tipo_movimentacao.ToListAsync();
        public Task<tipo_movimentacao> ObterPorId(int tipoId) => ctx.tipo_movimentacao.FindAsync(tipoId);

        public void Adicionar(tipo_movimentacao tipoMovimentacao)
        {
            ctx.tipo_movimentacao.AddAsync(tipoMovimentacao);
            ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_movimentacao tipoMovimentacao)
        {
            ctx.tipo_movimentacao.Update(tipoMovimentacao);
            ctx.SaveChangesAsync();
        }
    }
}