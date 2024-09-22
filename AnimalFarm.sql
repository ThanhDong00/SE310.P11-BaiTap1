CREATE DATABASE AnimalFarm;
GO

USE AnimalFarm;
GO

CREATE TABLE Animals (
	Id INT PRIMARY KEY IDENTITY(1,1),
    Cow INT,              
    Sheep INT,               
    Goat INT                  
);