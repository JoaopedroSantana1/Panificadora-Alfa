-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01-Dez-2022 às 02:25
-- Versão do servidor: 10.4.24-MariaDB
-- versão do PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `projeto2`
--
DROP DATABASE IF EXISTS `projeto2`;
CREATE DATABASE IF NOT EXISTS `projeto2` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `projeto2`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `cadastro`
--

DROP TABLE IF EXISTS `cadastro`;
CREATE TABLE `cadastro` (
  `id_cadastro` int(10) NOT NULL,
  `nome_cliente` varchar(50) NOT NULL,
  `email_cliente` varchar(60) NOT NULL,
  `endereco_cliente` varchar(50) NOT NULL,
  `senha_cliente` varchar(16) NOT NULL,
  `perfil` int(1) DEFAULT NULL,
  `id_login` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `cadastro`
--

INSERT INTO `cadastro` (`id_cadastro`, `nome_cliente`, `email_cliente`, `endereco_cliente`, `senha_cliente`, `perfil`, `id_login`) VALUES
(1, 'Joao Pedro Santana Rosa', 'joaopedrosantanarosa@gmail.com', 'rua angelo jose moreski', 'pato123', 4, NULL),
(2, 'Joao Pedro Santana Rosa', 'joaopedrosantanarosa@gmail.com', 'rua angelo jose moreski', 'pato123', 4, NULL);

-- --------------------------------------------------------

--
-- Estrutura da tabela `carrinho`
--

DROP TABLE IF EXISTS `carrinho`;
CREATE TABLE `carrinho` (
  `id_carrinho` int(10) NOT NULL,
  `id_produto` int(11) DEFAULT NULL,
  `id_pedido` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `login_e_senha`
--

DROP TABLE IF EXISTS `login_e_senha`;
CREATE TABLE `login_e_senha` (
  `id_login` int(10) NOT NULL,
  `login_cliente` varchar(50) NOT NULL,
  `senha_usuario` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pagamento`
--

DROP TABLE IF EXISTS `pagamento`;
CREATE TABLE `pagamento` (
  `id_pagamento` int(10) NOT NULL,
  `descricao` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pedido`
--

DROP TABLE IF EXISTS `pedido`;
CREATE TABLE `pedido` (
  `id_pedido` int(10) NOT NULL,
  `id_pagamento` int(11) NOT NULL,
  `data_compra` datetime NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estrutura da tabela `produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `id_produto` int(10) NOT NULL,
  `caminho` varchar(60) NOT NULL,
  `nome_produto` varchar(30) NOT NULL,
  `descricao` varchar(80) NOT NULL,
  `peso` decimal(3,2) NOT NULL,
  `valor_produto` decimal(3,2) NOT NULL,
  `validade` datetime NOT NULL,
  `quantidade` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `produto`
--

INSERT INTO `produto` (`id_produto`, `caminho`, `nome_produto`, `descricao`, `peso`, `valor_produto`, `validade`, `quantidade`) VALUES
(1, '', 'Pao', 'pao muito loko', '3.00', '5.00', '2022-11-30 00:00:00', 11),
(2, '', 'pao', 'a', '2.00', '9.99', '2022-11-30 00:00:00', 80),
(3, '', 'pao', 'a', '1.00', '9.99', '2022-11-30 00:00:00', 2);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`id_cadastro`),
  ADD KEY `fk_id_login` (`id_login`);

--
-- Índices para tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD PRIMARY KEY (`id_carrinho`),
  ADD KEY `fk_id_pedido` (`id_pedido`),
  ADD KEY `fk_id_produto` (`id_produto`);

--
-- Índices para tabela `login_e_senha`
--
ALTER TABLE `login_e_senha`
  ADD PRIMARY KEY (`id_login`);

--
-- Índices para tabela `pagamento`
--
ALTER TABLE `pagamento`
  ADD PRIMARY KEY (`id_pagamento`);

--
-- Índices para tabela `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`id_pedido`);

--
-- Índices para tabela `produto`
--
ALTER TABLE `produto`
  ADD PRIMARY KEY (`id_produto`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `cadastro`
--
ALTER TABLE `cadastro`
  MODIFY `id_cadastro` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `carrinho`
--
ALTER TABLE `carrinho`
  MODIFY `id_carrinho` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `login_e_senha`
--
ALTER TABLE `login_e_senha`
  MODIFY `id_login` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pagamento`
--
ALTER TABLE `pagamento`
  MODIFY `id_pagamento` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pedido`
--
ALTER TABLE `pedido`
  MODIFY `id_pedido` int(10) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `produto`
--
ALTER TABLE `produto`
  MODIFY `id_produto` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD CONSTRAINT `fk_id_login` FOREIGN KEY (`id_login`) REFERENCES `login_e_senha` (`id_login`) ON UPDATE CASCADE;

--
-- Limitadores para a tabela `carrinho`
--
ALTER TABLE `carrinho`
  ADD CONSTRAINT `fk_id_pedido` FOREIGN KEY (`id_pedido`) REFERENCES `pedido` (`id_pedido`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_id_produto` FOREIGN KEY (`id_produto`) REFERENCES `produto` (`id_produto`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
