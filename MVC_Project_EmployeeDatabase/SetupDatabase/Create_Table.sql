use Sample
Create Table tblEmployee(
EmployeeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name varchar(255),
Gender varChar(10),
City varChar(255),
DepartmentId int);