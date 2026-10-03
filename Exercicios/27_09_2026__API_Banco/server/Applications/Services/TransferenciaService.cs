using BancoAPI;
using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.Interfaces;

namespace BancoAPi
{
    public class TransferenciaService
    {
        private readonly ITransferenciaRepository _repository;
        public TransferenciaService(ITransferenciaRepository repository) => _repository = repository;

        public async Task<List<ListarTransferenciaUsuarioDestinatarioDTO>> ObterPorUsuarioRemetenteId(int destinatarioid)
        {
            if (destinatarioid == null || destinatarioid <= 0)
                throw new DomainException("Nenhuma transferencia localizada");

                List<transferencia> transferencias = await _repository.ObterPorUsuarioDestinatarioId(destinatarioid);

            return transferencias.Select(t => ConvertToDto.TransferenciaDestinatarioToDto(t)).ToList();
        }

        // public async Task<List<ListarTrans
    }
}