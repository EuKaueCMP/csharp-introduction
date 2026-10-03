using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.DTOs;
using BancoAPI.Interfaces;

namespace BancoAPI.Services
{
    public class TipoTransferenciaService
    {
        private readonly ITipoTransferenciaRepository _repository;
        public TipoTransferenciaService(ITipoTransferenciaRepository repository) => _repository = repository;

        public async Task<List<ListarTipoTransferenciaDTO>> Listar()
        {
            List<tipo_transferencia> tipoAlteracoes = await _repository.Listar();
            return tipoAlteracoes.Select(tm => ConvertToDto.TipoTransferenciaToDto(tm)).ToList();
        }

        public async Task<ListarTipoTransferenciaDTO> ObterPorId(int tipoId) => ConvertToDto.TipoTransferenciaToDto(await _repository.ObterPorId(tipoId)) ?? throw new DomainException("Nenhum tipo localiza");
        public async Task<ListarTipoTransferenciaDTO> Adicionar(tipo_transferencia tipoTransferencia)
        {
            if (string.IsNullOrWhiteSpace(tipoTransferencia.nome_tipo))
                throw new DomainException("Adicione um nome para o tipo de alteração!");

            if (await _repository.ObterPorNome(tipoTransferencia.nome_tipo))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Adicionar(tipoTransferencia);
            return ConvertToDto.TipoTransferenciaToDto(tipoTransferencia);
        }

        public async Task<ListarTipoTransferenciaDTO> Atualizar(tipo_transferencia tipoTransferencia)
        {
            if (string.IsNullOrWhiteSpace(tipoTransferencia.nome_tipo))
                throw new DomainException("Adicione um novo nome para o tipo de alteração!");

            if (await _repository.ObterPorNome(tipoTransferencia.nome_tipo))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Atualizar(tipoTransferencia);
            return ConvertToDto.TipoTransferenciaToDto(tipoTransferencia);
        }
    }
}
