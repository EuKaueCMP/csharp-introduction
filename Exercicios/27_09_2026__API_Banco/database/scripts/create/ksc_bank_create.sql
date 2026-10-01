CREATE DATABASE ksc_bank;
CREATE SCHEMA IF NOT EXISTS banco;

CREATE TABLE banco.tipo_usuario
(
	tipo_usuario_id SERIAL PRIMARY KEY,
	tipo VARCHAR(20) UNIQUE NOT NULL
);

CREATE TABLE banco.usuario
(
	usuario_id SERIAL PRIMARY KEY,
	nome TEXT NOT NULL,
	email VARCHAR(100) UNIQUE NOT NULL,
	senha VARCHAR(100) NOT NULL ,
	saldo NUMERIC(10, 2) DEFAULT 0,
	tipo_usuario_id INTEGER REFERENCES banco.tipo_usuario(tipo_usuario_id)
);

CREATE TABLE banco.tipo_alteracao
(
	tipo_alteracao_id SERIAL PRIMARY KEY,
	nome_alteracao VARCHAR(20)
);

CREATE TABLE banco.usuario_log
(
	log_id SERIAL PRIMARY KEY,
	usuario_id INTEGER REFERENCES banco.usuario(usuario_id) NOT NULL,
	tipo_alteracao_id INTEGER REFERENCES banco.tipo_alteracao(tipo_alteracao_id) NOT NULL,
	nome VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	saldo NUMERIC(10, 2) NOT NULL
);

CREATE TABLE banco.tipo_transferencia
(
	tipo_transferencia_id SERIAL PRIMARY KEY,
	nome_tipo VARCHAR(20) NOT NULL
);

CREATE TABLE banco.status_transferencia
(
	status_transferencia_id SERIAL PRIMARY KEY,
	nome_status VARCHAR(20) NOT NULL
);

CREATE TABLE banco.transferencia
(
	transferencia_id SERIAL PRIMARY KEY,
	usuario_remetente_id INTEGER REFERENCES banco.usuairo(usuario_id),
	usuario_destinatario_id INTEGER REFERENCES banco.usuario(usuario_id),
	data_transferencia TIMESTAMP,
	tipo_id INTEGER REFERENCES banco.tipo_transferencia(tipo_transferencia_id),
	status_id INTEGER REFERENCES banco.status_transferencia(status_transferencia_id)
);

CREATE TABLE banco.log_transferencia
(
	transferencia_id INTEGER REFERENCES banco.transferencia(transferencia_id),
	descricao_log TEXT NOT NULL,
	status_id INTEGER REFERENCES banco.status_transferencia(status_transferencia_id) NOT NULL,
	data_alteracao TIMESTAMP DEFAULT CLOCK_TIMESTAMP()
);

CREATE TABLE banco.tipo_movimentacao
(
	tipo_movimentacao_id SERIAL PRIMARY KEY,
	tipo VARCHAR(20)
);

CREATE TABLE banco.movimentacao
(
	movimentacao_id SERIAL PRIMARY KEY,
	usuario_id INTEGER REFERENCES banco.usuario(usuario_id),
	transferencia_id INTEGER REFERENCES banco.transferencia(transferencia_id),
	tipo_movimentacao_id INTEGER REFERENCES banco.tipo_movimentacao(tipo_movimentacao_id),
	saldo_movimentado NUMERIC(10, 2) NOT NULL,
	saldo_anterior NUMERIC(10, 2) NOT NULL,
	saldo_atual NUMERIC(10, 2) NOT NULL,
	data_movimentacao TIMESTAMP DEFAULT CLOCK_TIMESTAMP()
);

CREATE TABLE banco.ativo_investimento
(
	ativo_id SERIAL PRIMARY KEY,
	ticker VARCHAR(7) NOT NULL,
	tipo VARCHAR(20) NOT NULL,
	tipo_mercado VARCHAR(15) NOT NULL,
	codigo_mercado VARCHAR(15) NOT NULL,
	issuer_code VARCHAR(15) NOT NULL,
	currency VARCHAR(15) NOT NULL,
	isin VARCHAR(13) NOT NULL,
);
--
--CREATE TABLE banco.investimento 
--(
--	investimento_id SERIAL PRIMARY KEY,
--	usuario_id INTEGER REFERENCES banco.usuario(usuario_id),
--	ativo_id INTEGER REFERENCE banco.ativo_investimeno(ativo_id),
--	valor_aplicado NUMERIC(10, 2) NOT NULL,
--	data_investimento TIMESTAMP CLOCK_TIMESTAMP(),
--);
--
--CREATE TYPE tipo_emissor AS ENUM('GOVERNO', 'BANCO', 'EMPRESA');
--CREATE TYPE nivel_emissor AS ENUM('PJ', 'FEDERAL', 'ESTADUAL', 'NACIONAL');
--CREATE TYPE status_emissor AS ENUM('ATIVO', 'INATIVO', 'EM FALIMENTO');
--
--CREATE TABLE emissor_renda_fixa
--(
--	emissor_id SERIAL PRIMARY KEY,
--	razao_social TEXT NOT NULL,
--	cnpj VARCHAR(16) NOT NULL,
--	tipo_emissor tipo_emissor NOT NULL,
--	nivel_emissor nivel_emissor NOT NULL,
--	rating VARCHAR(20) NOT NULL,
--	agencia_rating VARCHAR(30) NOT NULL,
--	cobertura BOOLEAN NOT NULL,
--	limite_fgc NUMBER(10, 2 ) DEFAULT(250.000),
--	status_emissor status_emissor NOT NULL,
--	data_cadastro TIMESTAMP CLOCK_TIMESTEMP()
--);
--
--CREATE TYPE tipo_titulo_rf AS ENUM('CDB', 'CDI', 'LCA', 'LCI', 'CRI', 'CRA', 'TIT', 'DEBENTURE', 'LF', 'LCD');
--CREATE TYPE tipo_remuneracao_rf AS ENUM('PREFIXADA', 'POS_FIXADA', 'HIBRADA');
--CREATE TYPE  indice_referencia_rf AS ENUM('CDI', 'SELIC', 'IGP_M', 'TR', 'NULL');
--CREATE TYPE liquidez_rf AS ENUM ('DIARIO', 'NO_VENCIMENTO', 'APOS_CARENCIA');
--CREATE TYPE status_rf AS ENUM ('ATIVO', 'INATIVO', 'ENCERRADO', 'VENCIDO');
--
--CREATE TABLE banco.titulo_renda_fixa
--(
--	titulo_id SERIAL PRIMARY KEY,
--	emissor_id INTEGER REFERENCE banco.emissor_renda_fixa(emissor_id),
--	codigo VARCHAR(20),
--	nome VARCHAR(30) NOT NULL,
--	tipo_titulo tipo_titulo_rf NOT NULL,
--	tipo_remuneracao tipo_remuneracao_rf NOT NULL,
--	taxa DECIMAL(10, 4) NOT NULL,
--	indice_referencia indice_referencia_rf	NOT NULL,
--	liquidez liquidez NOT NULL,
--	isencao_ir BOOLEAN NOT NULL,
--	sujeito_iof BOOLEAN NOT NULL,
--	status_rf status_rf NOT NULL,
--	data_cadastro TIMESTAMP CLOCK_TIMESTAMP(),
--);
--
--CREATE TABLE banco.investimento_renda_fixa 
--(
--	investimento_renda_fixa_id SERIAL PRIMARY KEY,
--	investimento_id INTEGER REFERENCES banco.investimento(investimento_id),
--	
--);