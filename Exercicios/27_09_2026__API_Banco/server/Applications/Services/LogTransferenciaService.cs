using BancoAPI.Applications.Conversions;
using BancoAPI.Domains;
using BancoAPI.DTOs;
using BancoAPI.Interfaces;

namespace BancoAPI.Services
{
    public class LogTransferenciaService
    {
        private readonly ILogTransferenciaRepository _repository;
        public LogTransferenciaService(ILogTransferenciaRepository repository) => _repository = repository;

        public async Task<List<ListarLogTransferenciaDTO>> Listar()
        {
            List<log_transferencia> logs = await _repository.Listar();
            if (logs == null)
                throw new DomainException("Nenhum log de transfenrencia encontrado!");

            return logs.Select(nl => new ListarLogTransferenciaDTO
            {
                log_id = nl.log_id,
                transferencia_id = nl.transferencia_id,
                status_id = nl.status_id,
                descricao_log = nl.descricao_log,
                data_alteracao = nl.data_alteracao
            }).ToList();
        }

        public async Task<List<ListarLogTransferenciaDTO>> ObterPorUsuarioId(int usuarioId)
        {
            List<log_transferencia> logs = await _repository.ObterPorUsuarioId(usuarioId);
            if (logs == null)
                throw new DomainException("Nenhum log de transferencia encontrado!");

            return logs.Select(lw => ConvertToDto.LogTransferenciaToDto(lw)).ToList();
        }

        public async Task<List<ListarLogTransferenciaDTO>> ObterPorStatusId(int statusId)
        {
            List<log_transferencia> logs = await _repository.ObterPorStatusId(statusId) ?? throw new DomainException("Log de transferencia nao localizado!");
            return logs.Select(lw => ConvertToDto.LogTransferenciaToDto(lw)).ToList();
        }

        public async Task<List<ListarLogTransferenciaDTO>> ObterPorUsuarioIdStatusId(int usuarioId, int statusId)
        {
            List<log_transferencia> logs = (await _repository.ObterPorUsuarioIdStatusId(usuarioId, statusId)
                            ?? throw new DomainException("Log de transferencia nao localizado!"));

            return logs.Select(lw => ConvertToDto.LogTransferenciaToDto(lw)).ToList();
        }

        public async Task<ListarLogTransferenciaDTO> ObterPorId(int usuarioid)
        {
            return ConvertToDto.LogTransferenciaToDto(await _repository.ObterPorId(usuarioid)
                            ?? throw new DomainException("Log de transferencia nao localizado!"));
        }
    }
}