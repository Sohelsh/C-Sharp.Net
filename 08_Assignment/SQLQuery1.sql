CREATE DATABASE User_ManageAssEight;
USE User_ManageAssEight;

CREATE TABLE Login_Details(
 UserId int IDENTITY(1,1) PRIMARY KEY,
 UserRole varchar(40),
 UserName varchar(40),
 UserPwd varchar(10)
);

SELECT * FROM Login_Details; 


INSERT INTO Login_Details(UserRole,UserName,UserPwd) VALUES(
'Manager','Raj','Raj1234'); 
INSERT INTO Login_Details VALUES
('Manager','Kran','Kran1234'),
('Manager','Manoj','Manoj1234'),
('Admin','Arjun','Arjun1234'),
('Manager','Salman','Salman1234')
; 

SELECT DISTINCT (UserName) FROM Login_Details WHERE UserRole = 'Manager';