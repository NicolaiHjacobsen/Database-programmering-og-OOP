CREATE TABLE staffLogin
(
	loginID int IDENTITY (1,1) PRIMARY KEY,
	username varchar (255) NOT NULL,
	firstName varchar(255) NOT NULL,
	lastName varchar (255) NOT NULL,
	mail varchar(255) NOT NULL,
	pwd varchar(255) NOT NULL
);