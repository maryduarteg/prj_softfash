-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 30-Nov-2021 às 02:11
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 8.0.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `softfash`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `cidades`
--

CREATE TABLE `cidades` (
  `cid_id` int(11) NOT NULL,
  `cid_nome` varchar(45) DEFAULT NULL,
  `cid_codigoibge` varchar(45) DEFAULT NULL,
  `cid_estado` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `cidades`
--

INSERT INTO `cidades` (`cid_id`, `cid_nome`, `cid_codigoibge`, `cid_estado`) VALUES
(1, 'Narandiba', '1', 'SP'),
(2, 'Tarabai', '52', 'SP'),
(3, 'Sandovalina', '59', 'SP'),
(4, 'Martinopólis', '1475', 'SP'),
(26, 'Pirapozinho', '1589', 'SP');

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `cli_id` int(11) NOT NULL,
  `cli_cpf` varchar(20) DEFAULT NULL,
  `cli_rg` varchar(20) DEFAULT NULL,
  `cli_nome` varchar(70) DEFAULT NULL,
  `cli_endereco` varchar(70) DEFAULT NULL,
  `cid_id` int(11) NOT NULL,
  `cli_telefone` varchar(14) DEFAULT NULL,
  `cli_email` varchar(14) DEFAULT NULL,
  `cli_datacad` datetime DEFAULT NULL,
  `cli_datanasci` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`cli_id`, `cli_cpf`, `cli_rg`, `cli_nome`, `cli_endereco`, `cid_id`, `cli_telefone`, `cli_email`, `cli_datacad`, `cli_datanasci`) VALUES
(1, '248.989.632-56', '24.896.489-6', 'Maria Eula', 'Rua Sábia #456', 1, '(32) 58935-893', 'asdfghjkl', '2021-11-11 00:00:00', '1994-02-13 00:00:00'),
(2, '178.949.623-55', '14.789.256-9', 'Maria Lana', 'zxcvbnm,', 1, '(18) 96489-621', 'qwertyu', '2021-11-10 00:00:00', '1998-03-14 00:00:00'),
(3, '478.962.563-45', '14.789.621-4', 'Ana Raposa', 'qwertyuuuu', 3, '(14) 78964-586', 'qwertyui', '2021-11-10 00:00:00', '2021-10-10 00:00:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

CREATE TABLE `fornecedores` (
  `forn_id` int(11) NOT NULL,
  `forn_cnpj` varchar(20) NOT NULL,
  `forn_nome` varchar(70) DEFAULT NULL,
  `forn_categoria` varchar(45) DEFAULT NULL,
  `forn_telefone` varchar(14) DEFAULT NULL,
  `forn_email` varchar(30) DEFAULT NULL,
  `forn_datacadas` varchar(15) DEFAULT NULL,
  `forn_endereco` varchar(50) DEFAULT NULL,
  `cid_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fornecedores`
--

INSERT INTO `fornecedores` (`forn_id`, `forn_cnpj`, `forn_nome`, `forn_categoria`, `forn_telefone`, `forn_email`, `forn_datacadas`, `forn_endereco`, `cid_id`) VALUES
(1, '89.646.321/2462-45', 'Maria', 'Cosméticos', '(14) 59656-325', 'maria@hotmail.com', '2021-11-11 00:0', 'rua alves 456', 1),
(2, '45.789.656/3212-23', 'dfghj', 'nada', '(18) 99645-879', 'ghjklç', '2021-11-11 00:0', 'asdfgh', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `func_id` int(11) NOT NULL,
  `func_cpf` varchar(20) NOT NULL,
  `func_rg` varchar(20) DEFAULT NULL,
  `func_nome` varchar(70) DEFAULT NULL,
  `func_endereco` varchar(70) DEFAULT NULL,
  `cid_id` int(11) NOT NULL,
  `func_celular` varchar(14) DEFAULT NULL,
  `func_dataadms` datetime DEFAULT NULL,
  `func_datanasci` datetime DEFAULT NULL,
  `func_email` varchar(30) DEFAULT NULL,
  `func_funcao` varchar(30) DEFAULT NULL,
  `func_salario` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`func_id`, `func_cpf`, `func_rg`, `func_nome`, `func_endereco`, `cid_id`, `func_celular`, `func_dataadms`, `func_datanasci`, `func_email`, `func_funcao`, `func_salario`) VALUES
(1, '505.090.428-56', '58.106.470-7', 'qwerty', 'qwerty', 1, '(74) 14786-546', '2004-10-10 00:00:00', '1984-10-20 00:00:00', 'asdfghjk', 'qwertyui', '300'),
(2, '505.090.428-57', '58.106.470-6', 'Mary Duarte', 'Alves de Almeida', 1, '(18) 99692-075', '2020-06-20 00:00:00', '2004-01-29 00:00:00', 'qwertyu', 'Atendente', 'R$300,00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itens`
--

CREATE TABLE `itens` (
  `itens_id` int(11) NOT NULL,
  `Produtos_prod_id` int(11) NOT NULL,
  `Produtos_prod_nome` varchar(90) DEFAULT NULL,
  `Venda_ven_id` int(11) NOT NULL,
  `itens_quanti` int(11) DEFAULT NULL,
  `itens_prec` double DEFAULT NULL,
  `itens_subtotal` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `itens`
--

INSERT INTO `itens` (`itens_id`, `Produtos_prod_id`, `Produtos_prod_nome`, `Venda_ven_id`, `itens_quanti`, `itens_prec`, `itens_subtotal`) VALUES
(56, 3, 'vestido flor', 45, 4, 98.9000015258789, 395.6000061035156),
(57, 3, 'vestido flor', 46, 4, 98.9000015258789, 395.6000061035156),
(58, 1, 'blusa diana', 46, 1, 28.899999618530273, 28.899999618530273),
(59, 19, 'vestido amora', 46, 4, 109.9000015258789, 439.6000061035156),
(60, 5, 'Blusa Mi Amore', 47, 4, 30.25, 121),
(61, 3, 'vestido flor', 48, 3, 98.9000015258789, 296.7000045776367),
(62, 1, 'blusa diana', 49, 1, 28.899999618530273, 28.899999618530273),
(63, 5, 'Blusa Mi Amore', 49, 7, 30.25, 211.75),
(64, 1, 'blusa diana', 50, 1, 28.899999618530273, 28.899999618530273),
(65, 1, 'blusa diana', 51, 1, 28.899999618530273, 28.899999618530273),
(67, 3, 'vestido flor', 52, 8, 98.9000015258789, 791.2000122070312),
(69, 1, 'blusa diana', 53, 2, 28.899999618530273, 57.79999923706055),
(70, 1, 'blusa diana', 54, 1, 28.899999618530273, 28.899999618530273),
(71, 5, 'Blusa Mi Amore', 55, 4, 30.25, 121),
(72, 5, 'Blusa Mi Amore', 56, 4, 30.25, 121);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `prod_id` int(11) NOT NULL,
  `prod_nome` varchar(45) DEFAULT NULL,
  `prod_tecido` varchar(45) DEFAULT NULL,
  `prod_quantidade` int(11) DEFAULT NULL,
  `prod_prec` float DEFAULT NULL,
  `forn_id` int(11) NOT NULL,
  `prod_categoria` varchar(45) DEFAULT NULL,
  `prod_estacao` varchar(45) DEFAULT NULL,
  `prod_tamanho` varchar(45) DEFAULT NULL,
  `prod_descricao` varchar(45) DEFAULT NULL,
  `prod_cor` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`prod_id`, `prod_nome`, `prod_tecido`, `prod_quantidade`, `prod_prec`, `forn_id`, `prod_categoria`, `prod_estacao`, `prod_tamanho`, `prod_descricao`, `prod_cor`) VALUES
(1, 'blusa diana', 'viscolinho', 10, 28.9, 1, 'Feminino', 'Inverno', 'P, M, G', 'Leve e bonita', 'Rosa'),
(2, 'blusa flor', 'viscolinho', 50, 98.9, 1, 'Feminino', 'Inverno', 'P, M, G', 'Leve e bonita', 'Rosa'),
(3, 'vestido flor', 'viscolinho', 37, 98.9, 1, 'Feminino', 'Inverno', 'P, M, G', 'Leve e bonita', 'Rosa'),
(5, 'Blusa Mi Amore', 'Suede', 36, 30.25, 2, 'Infantil feminino', 'Inverno', 'G, GG', 'Elegante, fofa', 'Rosa, branca'),
(19, 'vestido amora', 'viscose', 8, 109.9, 2, 'Adulto feminino', 'Inverno', 'pp, m', 'fofinho', 'roxo'),
(75, 'Vestido', 'Viscolinho', 50, 89.9, 1, 'Adulto feminino', 'Primavera', 'P, M, G', 'Meigo e confortável', 'Preto');

-- --------------------------------------------------------

--
-- Estrutura da tabela `promissoria`
--

CREATE TABLE `promissoria` (
  `prom_id` int(11) NOT NULL,
  `Venda_ven_id` int(11) NOT NULL,
  `Venda_Clientes_cli_id` int(11) NOT NULL,
  `Venda_ven_data` varchar(90) NOT NULL,
  `Venda_ven_hora` varchar(90) NOT NULL,
  `prom_totalrestante` double DEFAULT NULL,
  `prom_ultimopagamento` varchar(900) DEFAULT NULL,
  `prom_total` double DEFAULT NULL,
  `Clientes_cli_nome` varchar(90) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `promissoria`
--

INSERT INTO `promissoria` (`prom_id`, `Venda_ven_id`, `Venda_Clientes_cli_id`, `Venda_ven_data`, `Venda_ven_hora`, `prom_totalrestante`, `prom_ultimopagamento`, `prom_total`, `Clientes_cli_nome`) VALUES
(9, 52, 1, '18/05/2021', '12:50', 0, '0', 912.2000122070312, NULL),
(10, 53, 2, '28/11/2021', '10:23', 0, '0', 57.79999923706055, 'Maria Lana'),
(11, 54, 1, '11/12/2021', '10:20', 0, '0', 28.899999618530273, 'Maria Eula'),
(12, 56, 3, '12/12/2021', '15:25', 0, '0', 121, 'Ana Raposa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `user_id` int(11) NOT NULL,
  `user_login` varchar(70) DEFAULT NULL,
  `user_senha` varchar(70) DEFAULT NULL,
  `user_categoria` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`user_id`, `user_login`, `user_senha`, `user_categoria`) VALUES
(1, 'Dona Maria Izabel', 'carlotta', 'Gerente');

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `ven_id` int(11) NOT NULL,
  `Clientes_cli_id` int(11) NOT NULL,
  `Clientes_cli_nome` varchar(120) DEFAULT NULL,
  `ven_dia` varchar(90) DEFAULT NULL,
  `ven_hora` varchar(90) DEFAULT NULL,
  `ven_total` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`ven_id`, `Clientes_cli_id`, `Clientes_cli_nome`, `ven_dia`, `ven_hora`, `ven_total`) VALUES
(44, 3, 'Ana Raposa', '11/11/2021', '10:20', 0),
(45, 3, 'Ana Raposa', '11/11/2021', '10:20', 0),
(46, 1, 'Maria Eula', '12/12/2021', '10:20', 864.1000118255615),
(47, 1, 'Maria Eula', '15/12/2021', '11:23', 121),
(48, 1, 'Maria Eula', '13/12/2021', '13:23', 296.7000045776367),
(49, 1, 'Maria Eula', '12/09/2021', '10:32', 240.64999961853027),
(50, 1, 'Maria Eula', '12/01/2020', '12:58', 0),
(51, 1, 'Maria Eula', '12/12/2021', '12:13', 240.64999961853027),
(52, 1, 'Maria Eula', '18/05/2021', '12:50', 912.2000122070312),
(53, 2, 'Maria Lana', '28/11/2021', '10:23', 57.79999923706055),
(54, 1, 'Maria Eula', '11/12/2021', '10:20', 28.899999618530273),
(55, 3, 'Ana Raposa', '10/01/2021', '11:56', 0),
(56, 3, 'Ana Raposa', '12/12/2021', '15:25', 121);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `cidades`
--
ALTER TABLE `cidades`
  ADD PRIMARY KEY (`cid_id`);

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`cli_id`),
  ADD KEY `cid_id` (`cid_id`);

--
-- Índices para tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD PRIMARY KEY (`forn_id`),
  ADD KEY `cid_id` (`cid_id`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`func_id`),
  ADD KEY `cid_id` (`cid_id`);

--
-- Índices para tabela `itens`
--
ALTER TABLE `itens`
  ADD PRIMARY KEY (`itens_id`),
  ADD KEY `itens_ibfk_1` (`Produtos_prod_id`),
  ADD KEY `itens_ibfk_2` (`Venda_ven_id`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`prod_id`),
  ADD KEY `forn_id` (`forn_id`);

--
-- Índices para tabela `promissoria`
--
ALTER TABLE `promissoria`
  ADD PRIMARY KEY (`prom_id`),
  ADD KEY `Venda_ven_id` (`Venda_ven_id`),
  ADD KEY `promissoria_ibfk_2` (`Venda_Clientes_cli_id`);

--
-- Índices para tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`user_id`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`ven_id`),
  ADD KEY `Clientes_cli_id` (`Clientes_cli_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `cli_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `itens`
--
ALTER TABLE `itens`
  MODIFY `itens_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT de tabela `promissoria`
--
ALTER TABLE `promissoria`
  MODIFY `prom_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `ven_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=57;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`cid_id`) REFERENCES `cidades` (`cid_id`);

--
-- Limitadores para a tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD CONSTRAINT `fornecedores_ibfk_1` FOREIGN KEY (`cid_id`) REFERENCES `cidades` (`cid_id`);

--
-- Limitadores para a tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD CONSTRAINT `funcionarios_ibfk_1` FOREIGN KEY (`cid_id`) REFERENCES `cidades` (`cid_id`);

--
-- Limitadores para a tabela `itens`
--
ALTER TABLE `itens`
  ADD CONSTRAINT `itens_ibfk_1` FOREIGN KEY (`Produtos_prod_id`) REFERENCES `produtos` (`prod_id`),
  ADD CONSTRAINT `itens_ibfk_2` FOREIGN KEY (`Venda_ven_id`) REFERENCES `venda` (`ven_id`);

--
-- Limitadores para a tabela `produtos`
--
ALTER TABLE `produtos`
  ADD CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`forn_id`) REFERENCES `fornecedores` (`forn_id`);

--
-- Limitadores para a tabela `promissoria`
--
ALTER TABLE `promissoria`
  ADD CONSTRAINT `promissoria_ibfk_1` FOREIGN KEY (`Venda_ven_id`) REFERENCES `venda` (`ven_id`),
  ADD CONSTRAINT `promissoria_ibfk_2` FOREIGN KEY (`Venda_Clientes_cli_id`) REFERENCES `venda` (`Clientes_cli_id`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `venda_ibfk_1` FOREIGN KEY (`Clientes_cli_id`) REFERENCES `clientes` (`cli_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
