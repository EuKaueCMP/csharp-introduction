] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Repositories] git ls-files -- MovimentacaoRepository.cs • completed
2026-09-29 22:46:54.080 [info] [         26ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Repositories/MovimentacaoRepository.cs • completed
2026-09-29 22:46:54.093 [info] [         12ms] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Repositories] git ls-files -- MovimentacaoRepository.cs • completed
2026-09-29 22:49:16.221 [info] [         22ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Repositories/MovimentacaoRepository.cs • completed
2026-09-29 22:49:16.236 [info] [         14ms] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Repositories] git ls-files -- MovimentacaoRepository.cs • completed
2026-09-29 22:54:21.288 [info] [         18ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Applications/Conversions/DateTimeToOnly.cs • completed
2026-09-29 22:54:21.320 [info] [         31ms] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Applications/Conversions] git ls-files -- DateTimeToOnly.cs • completed
2026-09-29 22:54:21.484 [info] [         30ms] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Applications/Conversions] git rev-parse --show-toplevel --git-dir --git-common-dir --show-superproject-working-tree • completed
2026-09-29 22:55:22.043 [info] [         39ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Applications/Conversions/DateTimeToOnly.cs • completed
2026-09-29 22:55:22.074 [info] [         30ms] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Applications/Conversions] git ls-files -- DateTimeToOnly.cs • completed
2026-09-29 22:55:33.077 [info] [         55ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Interfaces/IStatusTranferenciaRepository.cs • completed
2026-09-29 22:55:33.106 [info] [→3           ] (spawn) [/home/kaue/Documents/studies/learning-csharp] git blame --root --incremental --encoding=utf-8 -- Exercicios/27_09_2026__API Banco/Interfaces/IStatusTranferenciaRepository.cs • starting...
2026-09-29 22:55:33.174 [info] [←3       79ms] (spawn) [/home/kaue/Documents/studies/learning-csharp] git blame --root --incremental --encoding=utf-8 -- Exercicios/27_09_2026__API Banco/Interfaces/IStatusTranferenciaRepository.cs • completed
2026-09-29 22:55:33.255 [info] [         27ms] [/home/kaue/Documents/studies/learning-csharp] git log --format=%x1E%H%x1D --summary -n1 e3618744042756729abbe2dd2e53841238b130af^ -- Exercicios/27_09_2026__API Banco/Interfaces/IStatusTranferenciaInterface.cs • completed
2026-09-29 22:55:33.256 [info] [         18ms] [/home/kaue/Documents/studies/learning-csharp] git log --format=%x1E%H%x1D%aN%x1D%aE%x1D%at%x1D%cN%x1D%cE%x1D%ct%x1D%P%x1D%D%x1D%B%x1D --numstat --raw -M --use-mailmap -m --no-min-parents -n1 e3618744042756729abbe2dd2e53841238b130af -- • completed
2026-09-29 22:55:33.269 [info] [         81ms] [/home/kaue/Documents/studies/learning-csharp] git show --textconv HEAD:./Exercicios/27_09_2026__API Banco/Interfaces/IStatusTranferenciaRepository.cs -- • completed
2026-09-29 22:56:24.336 [info] [         17ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Applications/Conversions/DateTimeToOnly.cs • completed
2026-09-29 22:56:24.348 [info] [         11ms] [/home/kaue/Documents/studies/learning-csharp/Exercicios/27_09_2026__API Banco/Applications/Conversions] git ls-files -- DateTimeToOnly.cs • completed
2026-09-29 22:57:50.345 [info] [         34ms] [/home/kaue/Documents/studies/learning-csharp] git ls-files -- Exercicios/27_09_2026__API Banco/Applications/Conversions/DateTimeToOnly.cs • completed
2026-09-29 22:57:50.367 [inusing BancoAPI.Contexts;
using BancoAPI.Domains;

namespace BancoAPI
{
    public class MovimentacaoRepository : IMovimentacaoRepository
    {
        private readonly AppDbContext ctx;
        public MovimentacaoRepository(AppDbContext _ctx) => ctx = _ctx;

        public List<movimentacao> Listar() => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).ToList();

        public List<movimentacao> ObterPorUsuarioId(int usuarioId) => ctx.movimentacao.OrderByDescending(m => m.data_movimentacao).Where(m => m.usuario_id == usuarioId).ToList();

        public List<movimentacao> ObterPorData(DateOnly data).wh;
        public List<movimentacao Obter
    }
}