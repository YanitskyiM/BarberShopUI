CREATE TABLE Hairdressers (
ID INT NOT NULL IDENTITY, 
Hairdressers_FName VARCHAR(25) NOT NULL, 
Hairdressers_LName VARCHAR(25) ,
Gender VARCHAR (6),
Phone CHAR (13)  
)

INSERT INTO Hairdressers 
(Hairdressers_FName, Hairdressers_LName, Gender, Phone)
VALUES 
('George','Hroshev','Male','0957826485'),
('Nina','Sokolova','Female','0957826498'),
('Andriy','Pavliuk','Male','0457826463'),
('Valeriy','Nukolushun','Male','0657826435'),
('Anna','Samoshod','Female','0997826499'),
('Irina','Yanovska','Female','0897826332'),
('Angelika','Rulska','Female','0957826444')

SELECT top 20 Hairdressers_FName, Hairdressers_LName, Gender, Phone FROM Hairdressers
