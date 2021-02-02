-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Feb 02, 2021 at 06:32 AM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `id15158086_edume`
--

-- --------------------------------------------------------

--
-- Table structure for table `class`
--

CREATE TABLE `class` (
  `class_id` int(11) NOT NULL,
  `class_name` varchar(15) NOT NULL,
  `teacher_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `class`
--

INSERT INTO `class` (`class_id`, `class_name`, `teacher_id`) VALUES
(10, 'Manel', 20);

-- --------------------------------------------------------

--
-- Table structure for table `levels`
--

CREATE TABLE `levels` (
  `level_id` int(11) NOT NULL,
  `level_name` varchar(15) NOT NULL,
  `level_desc` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `levels`
--

INSERT INTO `levels` (`level_id`, `level_name`, `level_desc`) VALUES
(1, 'Level 1', 'Simple. Player should collect 1000 score to unlock next level.'),
(2, 'Level 2', 'Intermediate. Player should collect 2000 score to unlock next level.'),
(3, 'Level 3', 'Hard. Player should collect 3000 score to unlock next level.'),
(4, 'Level 4', 'Final and Hardest level. Player should collect 4000 score to win this level.');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `login_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `username` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`login_id`, `player_id`, `username`) VALUES
(18, 117, 'CA002'),
(19, 118, 'CA003');

-- --------------------------------------------------------

--
-- Table structure for table `players`
--

CREATE TABLE `players` (
  `id` int(10) NOT NULL,
  `username` varchar(15) NOT NULL,
  `sname` varchar(15) NOT NULL,
  `health` int(11) NOT NULL DEFAULT 3,
  `health2` int(11) NOT NULL DEFAULT 3,
  `health3` int(11) NOT NULL DEFAULT 3,
  `health4` int(11) NOT NULL DEFAULT 3,
  `time` float NOT NULL DEFAULT 3600,
  `time1` float NOT NULL DEFAULT 4200,
  `time2` float NOT NULL DEFAULT 4800,
  `time3` float NOT NULL DEFAULT 5400,
  `x_pos1` int(100) NOT NULL DEFAULT 0,
  `y_pos1` int(100) NOT NULL DEFAULT 0,
  `z_pos1` int(100) NOT NULL DEFAULT 0,
  `x_pos2` int(100) NOT NULL DEFAULT 0,
  `y_pos2` int(100) NOT NULL DEFAULT 0,
  `z_pos2` int(100) NOT NULL DEFAULT 0,
  `x_pos3` int(100) NOT NULL DEFAULT 0,
  `y_pos3` int(100) NOT NULL DEFAULT 0,
  `z_pos3` int(100) NOT NULL DEFAULT 0,
  `x_pos4` int(100) NOT NULL DEFAULT 0,
  `y_pos4` int(100) NOT NULL DEFAULT 0,
  `z_pos4` int(100) NOT NULL DEFAULT 0,
  `level_id` int(11) NOT NULL DEFAULT 1,
  `the_level` int(11) NOT NULL DEFAULT 1,
  `additionright` int(11) NOT NULL DEFAULT 0,
  `substractionright` int(11) NOT NULL DEFAULT 0,
  `multiplicationright` int(11) NOT NULL DEFAULT 0,
  `divisionright` int(11) NOT NULL DEFAULT 0,
  `additionwrong` int(11) NOT NULL DEFAULT 0,
  `substractionwrong` int(11) NOT NULL DEFAULT 0,
  `multiplicationwrong` int(11) NOT NULL DEFAULT 0,
  `divisionwrong` int(11) NOT NULL DEFAULT 0,
  `class_id` varchar(20) NOT NULL,
  `language` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `players`
--

INSERT INTO `players` (`id`, `username`, `sname`, `health`, `health2`, `health3`, `health4`, `time`, `time1`, `time2`, `time3`, `x_pos1`, `y_pos1`, `z_pos1`, `x_pos2`, `y_pos2`, `z_pos2`, `x_pos3`, `y_pos3`, `z_pos3`, `x_pos4`, `y_pos4`, `z_pos4`, `level_id`, `the_level`, `additionright`, `substractionright`, `multiplicationright`, `divisionright`, `additionwrong`, `substractionwrong`, `multiplicationwrong`, `divisionwrong`, `class_id`, `language`) VALUES
(117, 'CA002', 'Tharaka', 3, 3, 3, 3, 3600, 4200, 4800, 5400, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 'Manel', '2 '),
(118, 'CA003', 'Amara', 3, 3, 3, 3, 3600, 4200, 4800, 5400, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 'Manel', '2 ');

-- --------------------------------------------------------

--
-- Table structure for table `score_board`
--

CREATE TABLE `score_board` (
  `score_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `score` int(100) NOT NULL DEFAULT 0,
  `score1` int(100) NOT NULL DEFAULT 0,
  `score2` int(100) NOT NULL DEFAULT 0,
  `score3` int(100) NOT NULL DEFAULT 0,
  `score4` int(100) NOT NULL DEFAULT 0,
  `coins` int(100) NOT NULL DEFAULT 0,
  `diamands` int(100) NOT NULL DEFAULT 0,
  `coins2` int(100) NOT NULL DEFAULT 0,
  `diamands2` int(100) NOT NULL DEFAULT 0,
  `stars2` int(100) NOT NULL DEFAULT 0,
  `coins3` int(100) NOT NULL DEFAULT 0,
  `diamands3` int(100) NOT NULL DEFAULT 0,
  `stars3` int(100) NOT NULL DEFAULT 0,
  `coins4` int(100) NOT NULL DEFAULT 0,
  `diamands4` int(100) NOT NULL DEFAULT 0,
  `stars4` int(100) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `score_board`
--

INSERT INTO `score_board` (`score_id`, `player_id`, `score`, `score1`, `score2`, `score3`, `score4`, `coins`, `diamands`, `coins2`, `diamands2`, `stars2`, `coins3`, `diamands3`, `stars3`, `coins4`, `diamands4`, `stars4`) VALUES
(105, 117, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
(106, 118, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `teacher`
--

CREATE TABLE `teacher` (
  `teacher_id` int(11) NOT NULL,
  `name` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `hash` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `salt` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `class_name` varchar(15) COLLATE utf8_unicode_ci NOT NULL,
  `language` varchar(20) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `teacher`
--

INSERT INTO `teacher` (`teacher_id`, `name`, `hash`, `salt`, `class_name`, `language`) VALUES
(20, 'teacher', '$5$rounds=5000$steamedhamsteach$y/Hy6ASdL1S.pRHBJ2JShEvF7XmSdT12l/Bh.9gDuP2', '$5$rounds=5000$steamedhamsteacher$', 'Manel', '2');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `class`
--
ALTER TABLE `class`
  ADD PRIMARY KEY (`class_id`),
  ADD KEY `abc1` (`teacher_id`);

--
-- Indexes for table `levels`
--
ALTER TABLE `levels`
  ADD PRIMARY KEY (`level_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`login_id`),
  ADD KEY `test2` (`player_id`);

--
-- Indexes for table `players`
--
ALTER TABLE `players`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `score_board`
--
ALTER TABLE `score_board`
  ADD PRIMARY KEY (`score_id`),
  ADD KEY `test` (`player_id`);

--
-- Indexes for table `teacher`
--
ALTER TABLE `teacher`
  ADD PRIMARY KEY (`teacher_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `class`
--
ALTER TABLE `class`
  MODIFY `class_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `levels`
--
ALTER TABLE `levels`
  MODIFY `level_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `login_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `players`
--
ALTER TABLE `players`
  MODIFY `id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=119;

--
-- AUTO_INCREMENT for table `score_board`
--
ALTER TABLE `score_board`
  MODIFY `score_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=107;

--
-- AUTO_INCREMENT for table `teacher`
--
ALTER TABLE `teacher`
  MODIFY `teacher_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `class`
--
ALTER TABLE `class`
  ADD CONSTRAINT `abc1` FOREIGN KEY (`teacher_id`) REFERENCES `teacher` (`teacher_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `test2` FOREIGN KEY (`player_id`) REFERENCES `players` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `score_board`
--
ALTER TABLE `score_board`
  ADD CONSTRAINT `test` FOREIGN KEY (`player_id`) REFERENCES `players` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
