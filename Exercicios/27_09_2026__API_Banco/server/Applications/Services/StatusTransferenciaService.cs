using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.DTOs;
using BancoAPI.Interfaces;

namespace BancoAPI.Services
{
    public class StatusTransferenciaService
    {
        private readonly IStatusTransferenciaRepository _repository;
        public StatusTransferenciaService(IStatusTransferenciaRepository repository) => _repository = repository;

        public async Task<List<ListarStatusTransferenciaDTO>> Listar()
        {
            List<status_transferencia> statsTransfs = await _repository.Listar();
            return statsTransfs.Select(ConvertToDto.StatusTransferenciaToDto).ToList();
        }

        public async Task<ListarStatusTransferenciaDTO> ObterPorId(int id) => await _repository.ObterPorId(id).ContinueWith(t => ConvertToDto.StatusTransferenciaToDto(t.Result)) ?? throw new DomainException("Status de transferência não encontrado.");

        public async Task<ListarStatusTransferenciaDTO> Adicionar(status_transferencia statusTransf)
        {
            _repository.Adicionar(statusTransf);
            return ConvertToDto.StatusTransferenciaToDto(statusTransf);
        }

        public async Task<ListarStatusTransferenciaDTO> Atualizar(status_transferencia statusTransf)
        {
            _repository.Atualizar(statusTransf);
            return ConvertToDto.StatusTransferenciaToDto(statusTransf);
        }
    }
}
