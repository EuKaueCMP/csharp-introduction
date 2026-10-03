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

        public static ListarTipoAlteracaoDTO TipoAltacaoToDto(tipo_alteracao tipoAlteracao)
        {
            return new ListarTipoAlteracaoDTO
            {
                tipo_alteracao_id = tipoAlteracao.tipo_alteracao_id,
                nome_alteracao = tipoAlteracao.nome_alteracao
            };
        }

        public static ListarTipoMovimentacaoDTO TipoMovimentacaoToDto(tipo_movimentacao tipoMovimentacao)
        {
            return new ListarTipoMovimentacaoDTO
            {
                tipo_movimentacao_id = tipoMovimentacao.tipo_movimentacao_id,
                tipo = tipoMovimentacao.tipo
            };
        }

        public static ListarTipoTransferenciaDTO TipoTransferenciaToDto(tipo_transferencia tipoTransferencia)
        {
            return new ListarTipoTransferenciaDTO
            {
                tipo_transferencia_id = tipoTransferencia.tipo_transferencia_id,
                nome_tipo = tipoTransferencia.nome_tipo
            };
        }

        public static ListarTipoUsuarioDTO TipoUsuarioToDto(tipo_usuario tipoUsuario)
        {
            return new ListarTipoUsuarioDTO
            {
                tipo_usuario_id = tipoUsuario.tipo_usuario_id,
                nome_tipo = tipoUsuario.tipo
            };
        }

        public static ListarTransferenciaUsuarioDestinatarioDTO TransferenciaDestinatarioToDto(transferencia transferenciaDestinatario)
        {
            return new ListarTransferenciaUsuarioDestinatarioDTO
            {
                transferencia_id = transferenciaDestinatario.transferencia_id,
                status_id = transferenciaDestinatario.status_id,
                tipo_id = transferenciaDestinatario.tipo_id,
                usuario_destinatario_id = transferenciaDestinatario.usuario_destinatario_id,
                nome_destinatario = transferenciaDestinatario.usuario_destinatario.nome,
                usuario_remetente_id = transferenciaDestinatario.usuario_remetente_id,
                nome_remetente = transferenciaDestinatario.usuario_remetente.nome,
                data_transferencia = transferenciaDestinatario.data_transferencia
            };
        }

        public static ListarTransferenciaUsuarioRemetenteDTO TransferenciaUsuRemetenteToDto(transferencia transferenciaDestinatario)
        {
            return new ListarTransferenciaUsuarioRemetenteDTO
            {
                transferencia_id = transferenciaDestinatario.transferencia_id,
                status_id = transferenciaDestinatario.status_id,
                tipo_id = transferenciaDestinatario.tipo_id,
                usuario_remetente_id = transferenciaDestinatario.usuario_remetente_id,
                nome_remetente = transferenciaDestinatario.usuario_remetente.nome,
                usuario_destinatario_id = transferenciaDestinatario.usuario_destinatario_id,
                nome_destinatario = transferenciaDestinatario.usuario_destinatario.nome,
                data_transferencia = transferenciaDestinatario.data_transferencia
            };
        }
    }
}