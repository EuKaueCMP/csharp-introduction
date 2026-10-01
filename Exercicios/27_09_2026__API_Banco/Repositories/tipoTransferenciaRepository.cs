:27.857 [info] Settings: No changes found during synchronizing settings.
2026-09-30 15:14:27.860 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 15:14:27.866 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 15:14:27.870 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 15:14:27.874 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 15:14:27.879 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 15:14:27.987 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 15:14:27.989 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 15:14:27.990 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 15:14:27.991 [info] Sync done. Took 773ms
2026-09-30 15:19:28.008 [info] [AutoSync] Triggered by Interval
2026-09-30 15:19:28.008 [info] Sync started.
2026-09-30 15:19:28.765 [info] Settings: No changes found during synchronizing settings.
2026-09-30 15:19:28.770 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 15:19:28.779 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 15:19:28.783 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 15:19:28.799 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 15:19:28.805 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 15:19:28.926 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 15:19:28.929 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 15:19:28.930 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 15:19:28.934 [info] Sync done. Took 926ms
2026-09-30 15:20:00.886 [info] [AutoSync] Triggered by Activity
2026-09-30 15:20:00.886 [info] Sync started.
2026-09-30 15:20:01.159 [info] Settings: No changes found during synchronizing settings.
2026-09-30 15:20:01.163 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 15:20:01.172 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 15:20:01.175 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 15:20:01.178 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 15:20:01.185 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 15:20:01.321 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 15:20:01.323 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 15:20:01.324 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 15:20:01.325 [info] Sync done. Took 441ms
2026-09-30 15:20:33.734 [info] [AutoSync] Triggered by Activity
2026-09-30 15:20:33.736 [info] Sync started.
2026-09-30 15:20:34.127 [info] Settings: No changes found during synchronizing settings.
2026-09-30 15:20:34.143 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 15:20:34.166 [info] Snippets: No changes found during synchronizing snippets.
2026-09-30 15:20:34.198 [info] Tasks: No changes found during synchronizing tasks.
2026-09-30 15:20:34.218 [info] Mcp: No changes found during synchronizing mcp.
2026-09-30 15:20:34.241 [info] GlobalState: No changes found during synchronizing ui state.
2026-09-30 15:20:34.364 [info] Extensions: No changes found during synchronizing extensions.
2026-09-30 15:20:34.367 [info] Prompts: No changes found during synchronizing prompts.
2026-09-30 15:20:34.371 [info] Profiles: No changes found during synchronizing profiles.
2026-09-30 15:20:34.372 [info] Sync done. Took 639ms
2026-09-30 15:20:56.940 [info] [AutoSync] Triggered by Activity
2026-09-30 15:20:56.940 [info] Sync started.
2026-09-30 15:20:57.128 [info] Settings: No changes found during synchronizing settings.
2026-09-30 15:20:57.133 [info] Keybindings: No changes found during synchronizing keybindings.
2026-09-30 15:20:57.140 [info] Snippets: No changes found during synchronizing snippets.
2026-09file:///home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API_Banco/server/Repositories/TipoTransferenciaRepository.cs {"mtime":1790791677673,"ctime":1790791677673,"size":0,"etag":"3gni61f340","orphaned":false,"typeId":""}
using BancoAPI.Contexts;
using BancoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace BancoAPI
{
    public class tipoTransferenciaRepository
    {
        private readonly AppDbContext ctx; 
        public tipoTransferenciaRepository(AppDbContext _ctx) => ctx = _ctx;

        public Task<List<tipo_transferencia>> Listar() => ctx.tipo_transferencia.ToListAsync();
        public async Task<tipo_transferencia> ObterPorid(int transferenciaId) => await ctx.tipo_transferencia.FindAsync(transferenciaId);
        
        public void Adicionar(tipo_transferencia tipoTransferencia)
        {
            ctx.tipo_transferencia.AddAsync(tipoTransferencia);
            ctx.SaveChangesAsync();
        }

        public void Atualizar(tipo_transferencia tipoTransferencia)
        {
            ctx.tipo_transferencia.Update(tipoTransferencia);
            ctx.SaveChangesAsync
        }
    }
}