-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 10, 2023 at 08:49 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `scheduling`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `username`, `password`) VALUES
(1, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `option` tinyint(1) NOT NULL,
  `course_id` int(255) NOT NULL,
  `course` varchar(255) NOT NULL,
  `course_description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`option`, `course_id`, `course`, `course_description`) VALUES
(0, 2, 'BSCS', 'Bachelor of Science in Computer Science'),
(0, 4, 'BSHM', 'Bachelor of Science in Human Resources'),
(0, 6, 'BEED', 'Bachelor of Elementary Education ');

-- --------------------------------------------------------

--
-- Table structure for table `instructor`
--

CREATE TABLE `instructor` (
  `option` tinyint(1) NOT NULL,
  `instructor_id` int(255) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `first_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `instructor`
--

INSERT INTO `instructor` (`option`, `instructor_id`, `last_name`, `first_name`, `middle_name`, `gender`) VALUES
(0, 1, 'Federeso', 'Jomel', 'Concepcion', 'Male'),
(0, 2, 'Gallardo ', 'Robert', 'Ofamin', 'Male'),
(0, 3, 'Castillo', 'Jeric', 'Avenido', 'Male');

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `option` tinyint(1) NOT NULL,
  `room_id` int(255) NOT NULL,
  `room` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`option`, `room_id`, `room`) VALUES
(0, 2, 'CB 205'),
(0, 3, 'CB 206'),
(0, 4, 'CB 207');

-- --------------------------------------------------------

--
-- Table structure for table `school_year`
--

CREATE TABLE `school_year` (
  `school_year_id` int(255) NOT NULL,
  `school_year` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `school_year`
--

INSERT INTO `school_year` (`school_year_id`, `school_year`) VALUES
(1, '2023-2024');

-- --------------------------------------------------------

--
-- Table structure for table `semester`
--

CREATE TABLE `semester` (
  `semester_id` int(255) NOT NULL,
  `semester` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE `subject` (
  `option` varchar(1) NOT NULL,
  `course` varchar(100) NOT NULL,
  `subject_id` int(255) NOT NULL,
  `subject_code` varchar(255) NOT NULL,
  `subject_description` varchar(255) NOT NULL,
  `units` varchar(255) NOT NULL,
  `academicYr` varchar(100) NOT NULL,
  `yrLvl` varchar(100) NOT NULL,
  `semester` varchar(100) NOT NULL,
  `section` varchar(100) NOT NULL,
  `day` varchar(100) NOT NULL,
  `time` varchar(100) NOT NULL,
  `room` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`option`, `course`, `subject_id`, `subject_code`, `subject_description`, `units`, `academicYr`, `yrLvl`, `semester`, `section`, `day`, `time`, `room`) VALUES
('0', 'BSCS', 1, 'IT REVIEW', 'Information Technology Review', '3', '2023-2024', '1', '1st Semester', 'B', 'Monday', '8:00 - 9:00', 'CB 205'),
('0', 'BSHM', 2, 'EM', 'Event Management', '3', '2023-2024', '1', '1st Semester', 'A', 'Tuesday', '8:00 - 10:00', 'CB 205'),
('0', 'BEED', 3, 'Math', 'Mathematics', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '11:00 - 12:00', 'CB 207'),
('', 'BSCS', 6, 'NLP', 'Natural Language Processing', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 207'),
('', 'BSCS', 8, 'NLP', 'nadasdaw', '3', '2023-2024', '1', '2nd Semester', 'D', 'Thursday', '11:30 - 2:30', 'CB 207'),
('', 'BSCS', 9, 'COMP1 ', 'Introduction to Computing', '3', '2023-2024', '1', '1st Semester', 'A', 'Saturday	', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 10, 'PROG1', 'Computer Programming', '3', '2023-2024', '1', '1st Semester', 'A', 'Saturday	', '11:30 - 2:30', 'CB 206'),
('', 'BSCS', 11, 'UTS', 'Understanding the Self', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 105'),
('', 'BSCS', 12, 'RPH', 'Readings in Philippine History', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '2:30 - 5:30', 'CB 105'),
('', 'BSCS', 13, 'MMW', 'Mathematics in the Modern World', '3', '2023-2024', '1', '1st Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 105'),
('', 'BSCS', 14, 'PE1', 'Physical  Fitness', '2', '2023-2024', '1', '1st Semester', 'A', 'Thursday', '8:00 - 11:00', 'SHS 105'),
('', 'BSCS', 15, 'FIL1', 'Ugnayan ng Wika, Kultura at Lipunan', '3', '2023-2024', '1', '1st Semester', 'A', 'Thursday', '11:30 - 2:30', 'SHS 105'),
('', 'BSCS', 16, 'NSTP 1', 'Civic Welfare Training Service', '3', '2023-2024', '1', '1st Semester', 'A', 'Thursday', '2:30 - 5:30', 'SHS 106'),
('', 'BSCS', 17, 'DISCRETE 1', 'Discrete Structures 1', '3', '2023-2024', '1', '2nd Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 205'),
('', 'BSCS', 18, 'PROG2', 'Computer Programming 2', '3', '2023-2024', '1', '2nd Semester', 'A', 'Monday', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 19, 'DASTRUC', 'Data Structures and Algorithms', '3', '2023-2024', '1', '2nd Semester', 'A', 'Saturday	', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 20, ' STS', ' Science, Technology and Society', '3', '2023-2024', '1', '2nd Semester', 'A', 'Tuesday', '8:00 - 11:00', 'CB 104'),
('', 'BSCS', 21, 'PCO', 'Purposive Communication', '3', '2023-2024', '1', '2nd Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 104'),
('', 'BSCS', 22, 'PE 2', 'Rhythmic Activities', '2', '2023-2024', '1', '2nd Semester', 'A', 'Monday', '8:00 - 10:00', 'CB 106'),
('', 'BSCS', 23, 'FIL 2', 'Panitikan ng Pilipinas ', '3', '2023-2024', '1', '2nd Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 106'),
('', 'BSCS', 24, 'NSTP 2', 'Literacy Training Service', '3', '2023-2024', '1', '2nd Semester', 'A', 'Wednesday', '11:30 - 2:30', 'CB 106'),
('', 'BSCS', 25, 'OOP', 'Object Oriented Programming', '3', '2023-2024', '2', '1st Semester', 'A', 'Saturday	', '8:00 - 11:00', 'CB 206'),
('', 'BSCS', 26, 'DISCRETE 2', 'Discrete Structures 2', '3', '2023-2024', '2', '1st Semester', 'A', 'Saturday	', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 28, 'HUMCOIN', 'Human Computer Interaction', '3', '2023-2024', '2', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 29, 'HUMCOIN', '', '3', '2023-2024', '2', '1st Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 30, 'TCW', 'The Contemporary World', '3', '2023-2024', '2', '1st Semester', 'A', 'Tuesday', '2:30 - 5:30', 'SHS 104'),
('', 'BSCS', 31, 'AAP', 'Art Appreciation', '3', '2023-2024', '2', '1st Semester', 'A', 'Tuesday', '11:30 - 2:30', 'SHS 104'),
('', 'BSCS', 32, 'FIL 3', 'Malikhaing  Pagsulat', '3', '2023-2024', '2', '1st Semester', 'A', 'Tuesday', '8:00 - 11:00', 'SHS 104'),
('', 'BSCS', 33, 'AccigFund', 'Fundamentals of Accounting', '3', '2023-2024', '2', '1st Semester', 'A', 'Wednesday', '8:00 - 11:00', 'SHS 104'),
('', 'BSCS', 34, 'PE 3', 'Individual/Dual Sports/Games', '3', '2023-2024', '2', '1st Semester', 'A', 'Thursday', '8:00 - 11:00', 'SHS 104'),
('', 'BSCS', 35, 'INFOMGT ', 'Information Management', '3', '2023-2024', '2', '2nd Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 207'),
('', 'BSCS', 36, 'CSO ', 'Computer Architecture and Organization', '3', '2023-2024', '2', '2nd Semester', 'A', 'Monday', '11:30 - 2:30', 'SHS 101'),
('', 'BSCS', 37, 'ETHICS', 'Ethics', '3', '2023-2024', '2', '2nd Semester', 'A', 'Monday', '2:30 - 5:30', 'SHS 101'),
('', 'BSCS', 38, 'RIZAL ', 'Life, Works and Writings of Dr. Jose Rizal', '3', '2023-2024', '2', '2nd Semester', 'A', 'Wednesday', '2:30 - 5:30', 'SHS 101'),
('', 'BSCS', 39, 'PE  4 ', 'Team Sports/Games', '3', '2023-2024', '2', '2nd Semester', 'A', 'Wednesday', '11:30 - 2:30', 'SHS 102'),
('', 'BSCS', 40, 'SOCISSPP', 'Social Issues and Professional Practice', '3', '2023-2024', '2', '2nd Semester', 'A', 'Wednesday', '8:00 - 11:00', 'SHS 103'),
('', 'BSCS', 41, 'ANALGOR', 'Analysis and Design of Algorithms ', '3', '2023-2024', '2', '2nd Semester', 'A', 'Thursday', '8:00 - 11:00', 'SHS 103'),
('', 'BSCS', 42, 'AUTOMATA 1 ', 'Automata Theory and Formal Languages', '3', '2023-2024', '3', '1st Semester', 'A', 'Friday', '8:00 - 11:00', 'CB 205'),
('', 'BSCS', 43, 'DATACOM', 'Data Communications and Networking 3', '3', '2023-2024', '3', '1st Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 206'),
('', 'BSCS', 44, 'CS ELEC 1', 'Intelligent Systems', '3', '2023-2024', '3', '1st Semester', 'A', 'Saturday	', '8:00 - 11:00', 'CB 206'),
('', 'BSCS', 45, 'SOFTENG 1', 'Software Engineering 1', '3', '2023-2024', '3', '1st Semester', 'A', 'Wednesday', '11:30 - 2:30', 'CB 206'),
('', 'BSCS', 46, 'APPSDEV 1', 'Applications Development  and Emerging Technology', '3', '2023-2024', '3', '1st Semester', 'A', 'Saturday	', '11:30 - 2:30', 'CB 206'),
('', 'BSCS', 47, 'CS PROF  EL 1', 'Computational Science', '3', '2023-2024', '3', '1st Semester', 'A', 'Friday', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 48, 'CS PROF  EL 2', 'System Fundamentals', '3', '2023-2024', '3', '1st Semester', 'A', 'Thursday', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 49, 'PL1', 'Programming Languages', '3', '2023-2024', '3', '2nd Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 50, 'RESEARCH 1', 'Methods of Research in Computing', '3', '2023-2024', '3', '2nd Semester', 'A', 'Saturday	', '2:30 - 5:30', 'SHS 102'),
('', 'BSCS', 51, 'CS ELEC 2', 'Graphics and Visual Computing', '3', '2023-2024', '3', '2nd Semester', 'A', 'Wednesday', '8:00 - 11:00', 'CB 206'),
('', 'BSCS', 52, 'SOFTENG  2', 'Software Engineering 2', '3', '2023-2024', '3', '2nd Semester', 'A', 'Wednesday', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 53, 'CS PROF EL 3', 'Parallel and Distributed Computing', '3', '2023-2024', '3', '2nd Semester', 'A', 'Saturday	', '2:30 - 5:30', 'CB 206'),
('', 'BSCS', 54, 'QUANMET ', 'Quantitative Methods', '3', '2023-2024', '3', '2nd Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 205'),
('', 'BSCS', 55, 'OS ', 'Operating Systems', '3', '2023-2024', '3', '2nd Semester', 'A', 'Monday', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 56, 'NLP', 'Natural Language Procesing ', '3', '2023-2024', '4', '1st Semester', 'A', 'Monday', '8:00 - 11:00', 'CB 205'),
('', 'BSCS', 57, 'CS THESIS 1 ', 'Thesis Writing 1', '3', '2023-2024', '4', '1st Semester', 'A', 'Monday', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 58, 'ITREVIEW', 'Certification Exam Review', '3', '2023-2024', '4', '1st Semester', 'A', 'Tuesday', '8:00 - 11:00', 'CB 206'),
('', 'BSCS', 59, 'BUSINTEG', 'Integration of Computing Technologies in Business Management', '3', '2023-2024', '4', '1st Semester', 'A', 'Monday', '2:30 - 5:30', 'CB 205'),
('', 'BSCS', 60, 'IAS 1', 'Information Assurance and Security', '3', '2023-2024', '4', '2nd Semester', 'A', 'Tuesday', '8:00 - 11:00', 'CB 205'),
('', 'BSCS', 61, 'CS THESIS 2', 'Thesis Writing 2', '3', '2023-2024', '4', '2nd Semester', 'A', 'Tuesday', '11:30 - 2:30', 'CB 205'),
('', 'BSCS', 62, 'MODTECH ', 'Modern Technologies in Software Development ', '3', '2023-2024', '4', '2nd Semester', 'A', 'Tuesday', '2:30 - 5:30', 'CB 205');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`);

--
-- Indexes for table `instructor`
--
ALTER TABLE `instructor`
  ADD PRIMARY KEY (`instructor_id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_id`);

--
-- Indexes for table `school_year`
--
ALTER TABLE `school_year`
  ADD PRIMARY KEY (`school_year_id`);

--
-- Indexes for table `semester`
--
ALTER TABLE `semester`
  ADD PRIMARY KEY (`semester_id`);

--
-- Indexes for table `subject`
--
ALTER TABLE `subject`
  ADD PRIMARY KEY (`subject_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `instructor`
--
ALTER TABLE `instructor`
  MODIFY `instructor_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `room_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `school_year`
--
ALTER TABLE `school_year`
  MODIFY `school_year_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `semester`
--
ALTER TABLE `semester`
  MODIFY `semester_id` int(255) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subject`
--
ALTER TABLE `subject`
  MODIFY `subject_id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
