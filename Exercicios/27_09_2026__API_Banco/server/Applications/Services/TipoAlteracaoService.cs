using BancoAPI;
using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.DTOs;
using BancoAPI.Interfaces;

namespace BancoApi.Services
{
    public class TipoAlteracaoService
    {
        private readonly ITipoAlteracaoRepository _repository;
        public TipoAlteracaoService(ITipoAlteracaoRepository repository) => _repository = repository;

        public async Task<List<ListarTipoAlteracaoDTO>> Listar()
        {
            List<tipo_alteracao> tipoAlteracoes = await _repository.Listar();
            return tipoAlteracoes.Select(la => ConvertToDto.TipoAltacaoToDto(la)).ToList();
        }

        public async Task<ListarTipoAlteracaoDTO> ObterPorId(int tipoId) => ConvertToDto.TipoAltacaoToDto(await _repository.ObterPorId(tipoId)) ?? throw new DomainException("Nenhum tipo localiza");
        public async Task<ListarTipoAlteracaoDTO> Adicionar(tipo_alteracao tipoAlteracao)
        {
            if (string.IsNullOrWhiteSpace(tipoAlteracao.nome_alteracao))
                throw new DomainException("Adicione um nome para o tipo de alteração!");
                
            if (await _repository.ObterPorNome(tipoAlteracao.nome_alteracao))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Adicionar(tipoAlteracao);
            return ConvertToDto.TipoAltacaoToDto(tipoAlteracao);
        }

        public async Task<ListarTipoAlteracaoDTO> Atualizar(tipo_alteracao tipoAlteracao)
        {
            if (string.IsNullOrWhiteSpace(tipoAlteracao.nome_alteracao))
                throw new DomainException("Adicione um novo nome para o tipo de alteração!");
                
            if (await _repository.ObterPorNome(tipoAlteracao.nome_alteracao))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Atualizar(tipoAlteracao);
            return ConvertToDto.TipoAltacaoToDto(tipoAlteracao);
        }
    }
}