using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.DTOs;
using BancoAPI.Interfaces;

namespace BancoAPI.Services
{
    public class TipoUsuarioService
    {
        private readonly ITipoUsuarioRepository _repository;
        public TipoUsuarioService(ITipoUsuarioRepository repository) => _repository = repository;

        public async Task<List<ListarTipoUsuarioDTO>> Listar()
        {
            List<tipo_usuario> tipoAlteracoes = await _repository.Listar();
            return tipoAlteracoes.Select(tm => ConvertToDto.TipoUsuarioToDto(tm)).ToList();
        }

        public async Task<ListarTipoUsuarioDTO> ObterPorId(int tipoId) => ConvertToDto.TipoUsuarioToDto(await _repository.ObterPorId(tipoId)) ?? throw new DomainException("Nenhum tipo localiza");
        public async Task<ListarTipoUsuarioDTO> Adicionar(tipo_usuario tipoUsuario)
        {
            if (string.IsNullOrWhiteSpace(tipoUsuario.tipo))
                throw new DomainException("Adicione um nome para o tipo de alteração!");

            if (await _repository.ObterPorNome(tipoUsuario.tipo))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Adicionar(tipoUsuario);
            return ConvertToDto.TipoUsuarioToDto(tipoUsuario);
        }

        public async Task<ListarTipoUsuarioDTO> Atualizar(tipo_usuario tipoUsuario)
        {
            if (string.IsNullOrWhiteSpace(tipoUsuario.tipo))
                throw new DomainException("Adicione um novo nome para o tipo de alteração!");

            if (await _repository.ObterPorNome(tipoUsuario.tipo))
                throw new DomainException("Este tipo de alteração jã existe!");


            _repository.Atualizar(tipoUsuario);
            return ConvertToDto.TipoUsuarioToDto(tipoUsuario);
        }
    }
}
