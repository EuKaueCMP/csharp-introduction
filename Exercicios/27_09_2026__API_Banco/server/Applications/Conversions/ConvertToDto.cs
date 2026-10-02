using BancoAPI.Domains;
using BancoAPI.DTO;
using BancoAPI.DTOs;

namespace BancoAPI.Applications.Conversions
{
    public static class ConvertToDto
    {
        public static ListarLogTransferenciaDTO LogTransferenciaToDto(log_transferencia logTransf)
        {
            return new ListarLogTransferenciaDTO
            {
                log_id = logTransf.log_id,
                transferencia_id = logTransf.transferencia_id,
                data_alteracao = logTransf.data_alteracao,
                descricao_log = logTransf.descricao_log,
                status_id = logTransf.status_id
            };
        }

        public static ListarMovimentacaoDTO MovimentacaoToDto(movimentacao movimentacao)
        {
            return new ListarMovimentacaoDTO
            {
                movimentacao_id = movimentacao.movimentacao_id,
                usuario_id = movimentacao.usuario_id,
                tipo_movimentacao_id = movimentacao.tipo_movimentacao_id,
                saldo_anterior = movimentacao.saldo_anterior,
                saldo_atual = movimentacao.saldo_atual,
                data_movimentacao = movimentacao.data_movimentacao
            };
        }
    }
}