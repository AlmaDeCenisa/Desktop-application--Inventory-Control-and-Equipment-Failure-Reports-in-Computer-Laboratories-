-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 11, 2023 at 08:25 PM
-- Server version: 5.7.33
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdcontrolappslab`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `spActualizarAutorizado` (IN `p_estado` VARCHAR(20), IN `p_nrosolicitud` INT, IN `p_fechaejec` DATE, IN `p_horaejec` TIME)   UPDATE solicitud SET estado = p_estado ,fechaejec=p_fechaejec,horaejec=p_horaejec WHERE nrosolicitud = p_nrosolicitud$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spActualizarSoli` (IN `p_estado` VARCHAR(20), IN `p_nrosolicitud` INT)   UPDATE solicitud SET estado = p_estado WHERE nrosolicitud = p_nrosolicitud$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spBuscarEquipoXEstado` (IN `pEstado` VARCHAR(10), IN `pNumequipo` VARCHAR(10), IN `pNumlab` VARCHAR(10))   SELECT nroequipo, estado, nrolab FROM equipo WHERE Estado = pEstado AND nroequipo LIKE pNumequipo and nrolab LIKE pNumlab$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spBuscarNombreSolicitud` (IN `pnombrecompleto` VARCHAR(90), IN `pestado` VARCHAR(20))   SELECT solicitud.nrosolicitud, docente.nombrecompleto, tiposol.descriptiposol, motivo.descripmot, solicitud.fechasol, solicitud.horasol, solicitud.estado, MAX(equipo.nrolab) AS laboratorio
FROM motivo 
INNER JOIN solicitud ON motivo.codmot = solicitud.codmot 
INNER JOIN tiposol ON solicitud.codtiposol = tiposol.codtiposol 
INNER JOIN genera ON solicitud.nrosolicitud = genera.nrosolicitud 
INNER JOIN docente ON genera.codrp = docente.codrp 
INNER JOIN incluye ON solicitud.nrosolicitud = incluye.nrosolicitud 
INNER JOIN equipo ON incluye.nroequipo = equipo.nroequipo 
WHERE docente.nombrecompleto LIKE pnombrecompleto AND solicitud.estado = pestado 
GROUP BY solicitud.nrosolicitud, docente.nombrecompleto, tiposol.descriptiposol, motivo.descripmot, solicitud.fechasol, solicitud.horasol, solicitud.estado$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spBuscarsolicitudXestadoAutorizadoFinalizado` (IN `pestado` VARCHAR(20), IN `pestado1` VARCHAR(20))   SELECT solicitud.nrosolicitud, motivo.descripmot, tiposol.descriptiposol, solicitud.fechasol, solicitud.horasol, solicitud.estado
FROM solicitud
INNER JOIN motivo ON solicitud.codmot = motivo.codmot
INNER JOIN tiposol ON solicitud.codtiposol = tiposol.codtiposol
INNER JOIN incluye ON solicitud.nrosolicitud = incluye.nrosolicitud
WHERE solicitud.estado = pestado OR solicitud.estado = pestado1 
GROUP BY solicitud.nrosolicitud$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spBuscarsolicitudXestadoSolicita` (IN `pestado` VARCHAR(20))   SELECT solicitud.nrosolicitud, motivo.descripmot, tiposol.descriptiposol, solicitud.fechasol, solicitud.horasol, solicitud.estado
FROM solicitud
INNER JOIN motivo ON solicitud.codmot = motivo.codmot
INNER JOIN tiposol ON solicitud.codtiposol = tiposol.codtiposol
INNER JOIN incluye ON solicitud.nrosolicitud = incluye.nrosolicitud
WHERE solicitud.estado LIKE pestado
GROUP BY solicitud.nrosolicitud$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SPINSERTAREQUIPO` (IN `pnroequipo` VARCHAR(10), IN `pestado` VARCHAR(15), IN `pnrolab` VARCHAR(10))   INSERT INTO equipo(nroequipo, estado, nrolab) VALUES (pnroequipo, pestado, pnrolab)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsertarGenera` (IN `pcodrp` INT, IN `pnrosolicitud` INT)   INSERT INTO genera(codrp, nrosolicitud) VALUES (pcodrp,pnrosolicitud)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsertarincluye` (IN `pnrosolicitud` INT, IN `pnroequipo` VARCHAR(10))   INSERT INTO incluye(nrosolicitud, nroequipo) VALUES (pnrosolicitud,pnroequipo)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spinsertarlab` (IN `pnrolab` VARCHAR(10))   INSERT INTO laboratorio(nrolab) VALUES (pnrolab)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsertarMotivo` (IN `pdescripmot` VARCHAR(32))   INSERT INTO motivo(descripmot) VALUES(pdescripmot)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsertarSolicitud` (IN `phorasol` TIME, IN `pfechaejec` DATE, IN `phoraejec` TIME, IN `pcodmot` INT, IN `pcodtiposol` INT)   INSERT INTO solicitud(horasol, fechaejec, horaejec, codmot, codtiposol) VALUES (phorasol, pfechaejec, phoraejec,pcodmot, pcodtiposol)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spInsertarSolicitud1` (IN `phorasol` TIME, IN `pfechaejec` DATE, IN `phoraejec` TIME, IN `pcodmot` INT, IN `pcodtiposol` INT)   INSERT INTO solicitud (horasol, fechaejec, horaejec, codmot, codtiposol)
    VALUES (phorasol, pfechaejec, phoraejec, pcodmot, pcodtiposol)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spListarDocente` ()   (
SELECT codrp, nombrecompleto,telefono, usuario, contrasenia
    FROM docente
)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `splistarequipos` ()   SELECT * FROM equipo$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `splistarequiposparaacutliza` (IN `pnrolab` VARCHAR(10), IN `pestado` VARCHAR(15))   SELECT        equipo.nroequipo, equipo.estado, laboratorio.nrolab
FROM            laboratorio INNER JOIN
                         equipo ON laboratorio.nrolab = equipo.nrolab
WHERE        (laboratorio.nrolab = pnrolab) AND (equipo.estado = pestado)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spListarRol` ()   SELECT rol.idrol, rol.roles
FROM  rol$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `splistequipopordocente` (IN `pnombrecompleto` VARCHAR(90), IN `pnrolab` VARCHAR(10), IN `pnrosolicitud` INT)   SELECT        equipo.nroequipo
FROM            equipo INNER JOIN
                         incluye ON equipo.nroequipo = incluye.nroequipo INNER JOIN
                         solicitud ON incluye.nrosolicitud = solicitud.nrosolicitud INNER JOIN
                         genera ON solicitud.nrosolicitud = genera.nrosolicitud INNER JOIN
                         docente ON genera.codrp = docente.codrp
WHERE        (docente.nombrecompleto = pnombrecompleto) ANd equipo.nrolab = pnrolab and solicitud.nrosolicitud=pnrosolicitud$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `splistequipos` (IN `pnrosolicitud` INT)   SELECT incluye.nroequipo
FROM solicitud
INNER JOIN motivo ON solicitud.codmot = motivo.codmot
INNER JOIN tiposol ON solicitud.codtiposol = tiposol.codtiposol
INNER JOIN incluye ON solicitud.nrosolicitud = incluye.nrosolicitud
WHERE solicitud.nrosolicitud = pnrosolicitud$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `spverifcontrasenia` (IN `pusuario` VARCHAR(30), IN `pcontrasenia` VARCHAR(50))   SELECT rol.roles
FROM rol INNER JOIN docente ON rol.idrol = docente.idrol
where docente.usuario=pusuario AND docente.contrasenia=pcontrasenia$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_ComprobantedeSolicitud` (IN `numsol` INT)   SELECT        solicitud.nrosolicitud, solicitud.fechasol, equipo.nroequipo, equipo.estado, docente.nombrecompleto, motivo.descripmot, solicitud.fechaejec
FROM            equipo INNER JOIN
                         incluye ON equipo.nroequipo = incluye.nroequipo INNER JOIN
                         solicitud ON incluye.nrosolicitud = solicitud.nrosolicitud INNER JOIN
                         genera ON solicitud.nrosolicitud = genera.nrosolicitud INNER JOIN
                         docente ON genera.codrp = docente.codrp INNER JOIN
                         motivo ON solicitud.codmot = motivo.codmot
WHERE solicitud.nrosolicitud=numsol$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_listado_fechaSol` (IN `p_fechasol` DATE)   SELECT solicitud.nrosolicitud, docente.nombrecompleto, DATE(solicitud.fechasol) AS Fecha, solicitud.estado, motivo.descripmot, tiposol.descriptiposol
FROM docente
INNER JOIN genera ON docente.codrp = genera.codrp
INNER JOIN solicitud ON genera.nrosolicitud = solicitud.nrosolicitud
INNER JOIN motivo ON solicitud.codmot = motivo.codmot
INNER JOIN tiposol ON solicitud.codtiposol = tiposol.codtiposol
WHERE DATE(solicitud.fechasol) = p_fechasol$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `docente`
--

CREATE TABLE `docente` (
  `codrp` int(11) NOT NULL,
  `nombrecompleto` varchar(90) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `telefono` varchar(10) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `usuario` varchar(30) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `contrasenia` varchar(50) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `idrol` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `docente`
--

INSERT INTO `docente` (`codrp`, `nombrecompleto`, `telefono`, `usuario`, `contrasenia`, `idrol`) VALUES
(1, 'Monica Rodriguez ', '856756', 'monica', '1234', 1),
(2, 'Ronald Gil', '8456362', 'ronald_doc', '12345', 3),
(3, 'Pedro Canelas', '8888888', '', '', 3),
(4, 'Javier Cornejo', '123456', '', '', 3),
(5, 'Marlen Gutierrez', '555555', '', '', 3),
(6, 'Lucio Ticona', '213232', 'lucio_en', '81dc9bdb52d04dc20036dbd8313ed055', 1),
(7, 'Javier Cornejo', '235654', 'javier_doc', 'e2d9aa481712128f3efbefa174d2143c', 3),
(8, 'Marlene Gutierrez', '5555555', 'marlen_doc', 'bc41999c6ba88f57b4755c7b561cc9cf', 3),
(9, 'Miguel ', '65665', 'Rector', '12345', 1);

-- --------------------------------------------------------

--
-- Table structure for table `equipo`
--

CREATE TABLE `equipo` (
  `nroequipo` varchar(10) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `estado` varchar(15) COLLATE utf8mb4_spanish2_ci DEFAULT NULL,
  `nrolab` varchar(10) COLLATE utf8mb4_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `equipo`
--

INSERT INTO `equipo` (`nroequipo`, `estado`, `nrolab`) VALUES
('', '', ''),
('Lab1-01', 'activo', 'Lab1'),
('Lab1-03', 'activo', 'Lab1'),
('Lab1-04', 'activo', 'Lab1'),
('Lab1-06', 'activo', 'Lab1'),
('Lab2-01', 'activo', 'Lab2'),
('Lab2-02', 'inactivo', 'Lab2'),
('Lab2-03', 'Activo', 'Lab2'),
('Lab2-05', 'activo', 'Lab2'),
('Lab3-01', 'activo', 'Lab3'),
('Lab3-02', 'activo', 'Lab3'),
('Lab7-1', 'Activo', 'Lab7'),
('Lab7-2', 'Activo', 'Lab7'),
('Lab7-4', 'Activo', 'Lab7'),
('Lab8-1', 'Activo', 'Lab8');

-- --------------------------------------------------------

--
-- Table structure for table `genera`
--

CREATE TABLE `genera` (
  `codrp` int(11) NOT NULL,
  `nrosolicitud` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `genera`
--

INSERT INTO `genera` (`codrp`, `nrosolicitud`) VALUES
(1, 1),
(4, 20),
(2, 21),
(2, 22),
(2, 23),
(4, 25),
(3, 26),
(5, 27),
(1, 28),
(1, 29);

-- --------------------------------------------------------

--
-- Table structure for table `incluye`
--

CREATE TABLE `incluye` (
  `nrosolicitud` int(11) NOT NULL,
  `nroequipo` varchar(10) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `incluye`
--

INSERT INTO `incluye` (`nrosolicitud`, `nroequipo`) VALUES
(1, 'Lab1-01'),
(20, 'Lab1-01'),
(22, 'Lab1-01'),
(28, 'Lab1-01'),
(22, 'Lab1-03'),
(29, 'Lab1-03'),
(20, 'Lab1-04'),
(22, 'Lab1-04'),
(29, 'Lab1-04'),
(20, 'Lab1-06'),
(28, 'Lab1-06'),
(21, 'Lab2-01'),
(21, 'Lab2-03'),
(21, 'Lab2-05'),
(23, 'Lab2-05'),
(26, 'Lab3-01'),
(26, 'Lab3-02'),
(27, 'Lab7-1'),
(27, 'Lab7-2'),
(25, 'Lab8-1');

-- --------------------------------------------------------

--
-- Table structure for table `laboratorio`
--

CREATE TABLE `laboratorio` (
  `nrolab` varchar(10) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `laboratorio`
--

INSERT INTO `laboratorio` (`nrolab`) VALUES
(''),
('Lab1'),
('Lab2'),
('Lab3'),
('Lab4'),
('Lab5'),
('Lab7'),
('Lab8');

-- --------------------------------------------------------

--
-- Table structure for table `motivo`
--

CREATE TABLE `motivo` (
  `codmot` int(11) NOT NULL,
  `descripmot` varchar(32) COLLATE utf8mb4_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `motivo`
--

INSERT INTO `motivo` (`codmot`, `descripmot`) VALUES
(1, 'Infeccion de virus'),
(2, 'Actualizacion de windows'),
(3, 'Covid'),
(10, 'Fuente quemada'),
(11, 'Ram Defectuosa'),
(12, ''),
(13, NULL),
(14, 'Disco duro en mal estado'),
(15, 'Malaware'),
(16, 'prueba'),
(17, '');

-- --------------------------------------------------------

--
-- Table structure for table `rol`
--

CREATE TABLE `rol` (
  `idrol` int(11) NOT NULL,
  `roles` varchar(30) COLLATE utf8mb4_spanish2_ci NOT NULL,
  `descripcion` varchar(100) COLLATE utf8mb4_spanish2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `rol`
--

INSERT INTO `rol` (`idrol`, `roles`, `descripcion`) VALUES
(1, 'Rector', 'Principal autoridad del insituto'),
(2, 'Jefelab', 'Encargado del mantenimiento'),
(3, 'Docente', 'El que hace la solicitud de reparación');

-- --------------------------------------------------------

--
-- Table structure for table `solicitud`
--

CREATE TABLE `solicitud` (
  `nrosolicitud` int(11) NOT NULL,
  `fechasol` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `horasol` time DEFAULT NULL,
  `fechaejec` date DEFAULT NULL,
  `horaejec` time DEFAULT NULL,
  `estado` varchar(20) COLLATE utf8mb4_spanish2_ci DEFAULT 'Solicita',
  `codmot` int(11) DEFAULT NULL,
  `codtiposol` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `solicitud`
--

INSERT INTO `solicitud` (`nrosolicitud`, `fechasol`, `horasol`, `fechaejec`, `horaejec`, `estado`, `codmot`, `codtiposol`) VALUES
(1, '2023-03-31 04:00:00', '18:07:45', '2023-04-01', '19:07:45', 'Finalizado', 2, 2),
(2, '2023-04-08 01:59:16', '14:30:00', '2023-04-07', '15:00:00', 'Autorizado', 1, 2),
(3, '2023-04-08 02:00:11', '14:30:00', '2023-04-07', '15:00:00', 'Solicita', 2, 2),
(4, '2023-04-08 02:02:53', NULL, NULL, NULL, 'Solicita', NULL, NULL),
(7, '2023-04-08 02:20:42', '14:00:00', '2023-04-07', '15:00:00', 'Solicita', 10, 2),
(20, '2023-04-11 18:42:56', '14:42:56', '2023-04-12', '15:17:14', 'Finalizado', 1, 1),
(21, '2023-04-11 19:44:53', '15:44:53', '2023-05-27', '20:22:16', 'Solicita', 15, 1),
(22, '2023-04-11 21:13:36', '17:13:36', '2023-04-26', '00:01:27', 'Finalizado', 2, 2),
(23, '2023-04-11 22:40:45', '18:40:45', '2023-04-26', '00:05:09', 'Finalizado', 2, 2),
(24, '2023-04-26 04:04:11', '05:03:33', NULL, NULL, 'Solicita', 2, 1),
(25, '2023-05-27 02:53:13', '22:53:13', NULL, NULL, 'Solicita', 2, 1),
(26, '2023-05-27 02:57:09', '22:57:09', NULL, NULL, 'Solicita', 10, 1),
(27, '2023-05-27 03:38:06', '23:38:07', NULL, NULL, 'Solicita', 11, 1),
(28, '2023-05-27 03:40:25', '23:40:25', NULL, NULL, 'Solicita', 1, 1),
(29, '2023-05-27 03:41:44', '23:41:44', '2023-05-27', '20:27:49', 'Finalizado', 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `tiposol`
--

CREATE TABLE `tiposol` (
  `codtiposol` int(11) NOT NULL,
  `descriptiposol` varchar(32) COLLATE utf8mb4_spanish2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Dumping data for table `tiposol`
--

INSERT INTO `tiposol` (`codtiposol`, `descriptiposol`) VALUES
(1, 'Mantenimiento'),
(2, 'Reinstalacion');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `docente`
--
ALTER TABLE `docente`
  ADD PRIMARY KEY (`codrp`),
  ADD KEY `idrol` (`idrol`);

--
-- Indexes for table `equipo`
--
ALTER TABLE `equipo`
  ADD PRIMARY KEY (`nroequipo`),
  ADD KEY `nrolab` (`nrolab`);

--
-- Indexes for table `genera`
--
ALTER TABLE `genera`
  ADD PRIMARY KEY (`codrp`,`nrosolicitud`),
  ADD KEY `nrosolicitud` (`nrosolicitud`);

--
-- Indexes for table `incluye`
--
ALTER TABLE `incluye`
  ADD PRIMARY KEY (`nrosolicitud`,`nroequipo`),
  ADD KEY `nroequipo` (`nroequipo`);

--
-- Indexes for table `laboratorio`
--
ALTER TABLE `laboratorio`
  ADD PRIMARY KEY (`nrolab`);

--
-- Indexes for table `motivo`
--
ALTER TABLE `motivo`
  ADD PRIMARY KEY (`codmot`);

--
-- Indexes for table `rol`
--
ALTER TABLE `rol`
  ADD PRIMARY KEY (`idrol`);

--
-- Indexes for table `solicitud`
--
ALTER TABLE `solicitud`
  ADD PRIMARY KEY (`nrosolicitud`),
  ADD KEY `codmot` (`codmot`),
  ADD KEY `codtiposol` (`codtiposol`);

--
-- Indexes for table `tiposol`
--
ALTER TABLE `tiposol`
  ADD PRIMARY KEY (`codtiposol`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `docente`
--
ALTER TABLE `docente`
  MODIFY `codrp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `motivo`
--
ALTER TABLE `motivo`
  MODIFY `codmot` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `rol`
--
ALTER TABLE `rol`
  MODIFY `idrol` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `solicitud`
--
ALTER TABLE `solicitud`
  MODIFY `nrosolicitud` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `tiposol`
--
ALTER TABLE `tiposol`
  MODIFY `codtiposol` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `docente`
--
ALTER TABLE `docente`
  ADD CONSTRAINT `FKidrol` FOREIGN KEY (`idrol`) REFERENCES `rol` (`idrol`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `equipo`
--
ALTER TABLE `equipo`
  ADD CONSTRAINT `equipo_ibfk_1` FOREIGN KEY (`nrolab`) REFERENCES `laboratorio` (`nrolab`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `genera`
--
ALTER TABLE `genera`
  ADD CONSTRAINT `genera_ibfk_1` FOREIGN KEY (`codrp`) REFERENCES `docente` (`codrp`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `genera_ibfk_2` FOREIGN KEY (`nrosolicitud`) REFERENCES `solicitud` (`nrosolicitud`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `incluye`
--
ALTER TABLE `incluye`
  ADD CONSTRAINT `incluye_ibfk_1` FOREIGN KEY (`nrosolicitud`) REFERENCES `solicitud` (`nrosolicitud`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `incluye_ibfk_2` FOREIGN KEY (`nroequipo`) REFERENCES `equipo` (`nroequipo`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `solicitud`
--
ALTER TABLE `solicitud`
  ADD CONSTRAINT `solicitud_ibfk_1` FOREIGN KEY (`codmot`) REFERENCES `motivo` (`codmot`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `solicitud_ibfk_2` FOREIGN KEY (`codtiposol`) REFERENCES `tiposol` (`codtiposol`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
