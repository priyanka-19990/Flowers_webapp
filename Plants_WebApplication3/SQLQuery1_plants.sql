CREATE DATABASE Plants;

use [Plants]
Go

CREATE TABLE Flowers(
    S_no int NOT NULL identity(1,1) PRIMARY KEY,
	Name varchar(50) NOT NULL,
	BinomialName varchar(200) UNIQUE,
	State varchar(100),

);

INSERT INTO Flowers values
(1,'Jasmine','Jasminum sambac','Andhra Pradesh'),
(2,'Foxtail Orchid','Rhynchostylis retusa','Arunachal Pradesh'),
(3,'Orchid Tree','Bauhinia variegata','Bihar'),
(4,'Frangipani','Plumeria rubra','Goa'),
(5,'African Marigold','Tagetes erecta','Gujarat'),
(6,'Lotus','Nelumbo nucifera','Haryana'),
(7,'Pink rhododendron','Rhododendron campanulatum','Himachal Pradesh'),
(8,'Palash','Butea monosperma','Jharkhand'),
(9,'Golden shower tree','Cassia fistula','Kerala'),
(10,'Alfalfa','Medicago sativa','Delhi'),
(11,'Brahma Kamal','Saussurea obvallata','Uttarakhand'),
(12,'Neelakurinji','Strobilanthes kunthiana','Lakshadweep');
