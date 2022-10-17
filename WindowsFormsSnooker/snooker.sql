-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Okt 17. 16:32
-- Kiszolgáló verziója: 10.4.24-MariaDB
-- PHP verzió: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `egytablasok`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `snooker`
--

CREATE TABLE `snooker` (
  `Helyezes` int(3) DEFAULT NULL,
  `Nev` varchar(21) DEFAULT NULL,
  `Orszag` varchar(14) DEFAULT NULL,
  `Nyeremeny` int(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COMMENT='Snooker világranglista';

--
-- A tábla adatainak kiíratása `snooker`
--

INSERT INTO `snooker` (`Helyezes`, `Nev`, `Orszag`, `Nyeremeny`) VALUES
(52, 'Akani Sunny', 'Thaiföld', 118500),
(7, 'Allen Mark', 'Észak-Írország', 681000),
(72, 'Anda Zhang', 'Kína', 44750),
(76, 'Astley John', 'Anglia', 40000),
(73, 'Baird Sam', 'Anglia', 44750),
(13, 'Bingham Stuart', 'Anglia', 345500),
(97, 'Bingyu Chang', 'Kína', 6750),
(28, 'Brecel Luca', 'Belgium', 179000),
(79, 'Brown Jordan', 'Észak-Írország', 29000),
(78, 'Burden Alfred', 'Anglia', 32000),
(50, 'Carrington Stuart', 'Anglia', 121750),
(16, 'Carter Ali', 'Anglia', 289000),
(81, 'Carty Ashley', 'Anglia', 22750),
(86, 'Chandler Harvey', 'Anglia', 14475),
(83, 'Chuan Leong Thor', 'Malajzia', 16500),
(84, 'Clarke Jamie Rhys', 'Wales', 15500),
(63, 'Craigie Sam', 'Anglia', 78500),
(94, 'Dale Dominic', 'Wales', 8750),
(41, 'Davis Mark', 'Anglia', 145725),
(20, 'Day Ryan', 'Wales', 244250),
(18, 'Ding Junhui', 'Kína', 270250),
(64, 'Doherty Ken', 'Írország', 77250),
(29, 'Donaldson Scott', 'Skócia', 176750),
(21, 'Dott Graeme', 'Skócia', 237750),
(66, 'Dunn Mike', 'Anglia', 74750),
(53, 'Ebdon Peter', 'Anglia', 111750),
(88, 'Feilong Chen', 'Kína', 13500),
(22, 'Ford Tom', 'Anglia', 212250),
(57, 'Fu Marco', 'Hong Kong', 104250),
(51, 'Georgiou Michael', 'Ciprus', 119600),
(11, 'Gilbert David', 'Anglia', 412000),
(33, 'Gould Martin', 'Anglia', 160250),
(99, 'Grace David', 'Anglia', 6750),
(24, 'Guodong Xiao', 'Kína', 211600),
(61, 'Hamilton Anthony', 'Anglia', 92250),
(25, 'Haotian Lyu', 'Kína', 191750),
(10, 'Hawkins Barry', 'Anglia', 427250),
(91, 'Heathcote Louis', 'Anglia', 10750),
(6, 'Higgins John', 'Skócia', 743000),
(59, 'Higginson Andrew', 'Anglia', 96250),
(60, 'Highfield Liam', 'Anglia', 96000),
(89, 'Hirani Kishan', 'Wales', 13350),
(44, 'Holt Michael', 'Anglia', 133500),
(70, 'Honghao Luo', 'Kína', 65000),
(95, 'Jiahui Si', 'Kína', 7500),
(87, 'Jiankang Zhang', 'Kína', 13600),
(71, 'Jones Jak', 'Wales', 54250),
(48, 'Joyce Mark', 'Anglia', 125750),
(30, 'King Mark', 'Anglia', 166500),
(100, 'Langning Bai', 'Kína', 5000),
(92, 'Lee Andy', 'Anglia', 9500),
(43, 'Li Hang', 'Kína', 138000),
(36, 'Liang Wenbo', 'Kína', 154500),
(80, 'Lines Oliver', 'Anglia', 28000),
(12, 'Lisowski Jack', 'Anglia', 392250),
(34, 'Maflin Kurt', 'Norvégia', 158600),
(14, 'Maguire Stephen', 'Skócia', 316000),
(96, 'Mann Mitchell', 'Anglia', 7500),
(32, 'McGill Anthony', 'Skócia', 160500),
(54, 'McManus Alan', 'Skócia', 111250),
(85, 'Miah Hammad', 'Anglia', 15475),
(39, 'Milkins Robert', 'Anglia', 149600),
(8, 'Murphy Shaun', 'Anglia', 506500),
(62, 'Ning Lu', 'Kína', 87250),
(67, 'O\'Brien Fergal', 'Írország', 70600),
(68, 'O\'Connor Joe', 'Anglia', 69750),
(42, 'O\'Donnell Martin', 'Anglia', 145250),
(2, 'O\'Sullivan Ronnie', 'Anglia', 1116000),
(65, 'Pengfei Tian', 'Kína', 75750),
(15, 'Perry Joe', 'Anglia', 292500),
(23, 'Robertson Jimmy', 'Anglia', 211725),
(5, 'Robertson Neil', 'Ausztrália', 834500),
(35, 'Saengkham Noppon', 'Thaiföld', 157000),
(4, 'Selby Mark', 'Anglia', 863000),
(27, 'Selt Matthew', 'Anglia', 180350),
(49, 'Sijun Yuan', 'Kína', 123000),
(74, 'Slessor Elliot', 'Anglia', 43500),
(75, 'Steadman Craig', 'Anglia', 40500),
(90, 'Stefanow Adam', 'Lengyelország', 12500),
(46, 'Stevens Matthew', 'Wales', 129750),
(1, 'Trump Judd', 'Anglia', 1270500),
(37, 'Un-Nooh Thepchaiya', 'Thaiföld', 151225),
(98, 'Ursenbacher Alexander', 'Svájc', 6750),
(31, 'Vafaei Hossein', 'Irán', 161500),
(45, 'Wakelin Chris', 'Anglia', 129975),
(26, 'Walden Ricky', 'Anglia', 182750),
(77, 'Walker Lee', 'Wales', 33000),
(82, 'Wattana James', 'Thaiföld', 17500),
(56, 'Wells Daniel', 'Wales', 104250),
(58, 'White Michael', 'Wales', 98250),
(3, 'Williams Mark', 'Wales', 1048250),
(55, 'Williams Robbie', 'Anglia', 107500),
(19, 'Wilson Gary', 'Anglia', 261100),
(9, 'Wilson Kyren', 'Anglia', 470500),
(40, 'Woollaston Ben', 'Anglia', 146350),
(47, 'Xintong Zhao', 'Kína', 125750),
(69, 'Xiwen Mei', 'Kína', 68000),
(17, 'Yan Bingtao', 'Kína', 285000),
(93, 'Zhengyi Fan', 'Kína', 9500),
(38, 'Zhou Yuelong', 'Kína', 150250);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
