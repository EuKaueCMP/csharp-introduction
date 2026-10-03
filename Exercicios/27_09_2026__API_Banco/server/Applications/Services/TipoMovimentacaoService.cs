using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.DTOs;
using BancoAPI.Interfaces;

namespace BancoAPI.Services
{
    public class TipoMovimentacaoService
    {
        private readonly ITipoMovimentacaoRepository _repository;
        public TipoMovimentacaoService(ITipoMovimentacaoRepository repository) => _repository = repository;

        public async Task<List<ListarTipoMovimentacaoDTO>> Listar()
        {
            List<tipo_movimentacao> tipoAlteracoes = await _repository.Listar();
            return tipoAlteracoes.Select(tm => ConvertToDto.TipoMovimentacaoToDto(tm)).ToList();
        }

        public async Task<ListarTipoMovimentacaoDTO> ObterPorId(int tipoId) => ConvertToDto.TipoMovimentacaoToDto(await _repository.ObterPorId(tipoId)) ?? throw new DomainException("Nenhum tipo localiza");
        public async Task<ListarTipoMovimentacaoDTO> Adicionar(tipo_movimentacao tipoMovimentacao)
        {
            if (string.IsNullOrWhiteSpace(tipoMovimentacao.tipo))
                throw new DomainException("Adicione um nome para o tipo de alteração!");

            if (await _repository.ObterPorNome(tipoMovimentacao.tipo))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Adicionar(tipoMovimentacao);
            return ConvertToDto.TipoMovimentacaoToDto(tipoMovimentacao);
        }

        public async Task<ListarTipoMovimentacaoDTO> Atualizar(tipo_movimentacao tipoMovimentacao)
        {
            if (string.IsNullOrWhiteSpace(tipoMovimentacao.tipo))
                throw new DomainException("Adicione um novo nome para o tipo de alteração!");

            if (await _repository.ObterPorNome(tipoMovimentacao.tipo))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Atualizar(tipoMovimentacao);
            return ConvertToDto.TipoMovimentacaoToDto(tipoMovimentacao);
        }
    }
}
