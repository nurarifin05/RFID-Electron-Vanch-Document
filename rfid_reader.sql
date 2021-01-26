-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 26, 2021 at 09:19 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `rfid_reader`
--

-- --------------------------------------------------------

--
-- Table structure for table `reader`
--

CREATE TABLE `reader` (
  `ID` int(100) NOT NULL,
  `ID_Reader` varchar(255) DEFAULT NULL,
  `Nomor_Tag` varchar(255) DEFAULT NULL,
  `TimeStamp` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `reader`
--

INSERT INTO `reader` (`ID`, `ID_Reader`, `Nomor_Tag`, `TimeStamp`) VALUES
(1, 'AGI001', '300833B2DDD9014000000000', '2021-01-26 13:10:41'),
(2, 'AGI001', '041621000000000000000001', '2021-01-26 13:10:41'),
(3, 'AGI001', '333342324444443930313430', '2021-01-26 13:30:41'),
(4, 'AGI001', '333342324444443930313430', '2021-01-26 13:53:36'),
(5, 'AGI001', '333342324444443930313430', '2021-01-26 13:53:36'),
(6, 'AGI001', '041621000000000000000001', '2021-01-26 14:45:00'),
(7, 'AGI001', '041621000000000000000001', '2021-01-26 14:45:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `reader`
--
ALTER TABLE `reader`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `reader`
--
ALTER TABLE `reader`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
