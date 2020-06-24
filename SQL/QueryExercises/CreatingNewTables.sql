Create Table Employee2 (
	EmployeeId int not null,
	FirstName varchar(255),
	LastName varchar(255),
	SSN int,
	DeptId int,
	Primary Key(EmployeeId)
 );
Create Table Department (
	DeptId int not null,
	Name varchar(255),
	Location varchar(255),
	Primary Key(DeptId)
);
Create Table EmpDetails (
	ID int not null,
	EmployeeId int not null,
	Salary money,
	Address1 varchar(255),
	Address2 varchar(255),
	City varchar(255),
	St varchar(255),
	Country varchar(255)
	Primary Key(ID)

);
Alter table EmpDetails
Add constraint EmployeeId
	Foreign key (EmployeeId)
	References Employee2 (EmployeeId);

Alter table Employee2
Add constraint DeptId
	Foreign key (DeptId)
	References Department (DeptId);

Insert into Department Values (1, 'dept1' , 'Texas');
Insert into Department Values (2, 'dept2' , 'Florida');
Insert into Department Values (3, 'dept3' , 'Virginia');

Insert into Employee2 Values (1, 'John', 'Johnson', 000000001, 1);
Insert into Employee2 Values (2, 'Mark', 'Markson', 000000002, 2);
Insert into Employee2 Values (3, 'Matthew', 'Matthewson', 000000003, 3);

Insert into EmpDetails Values (1, 1, 45000, '1st street', null, 'Houston', 'Texas', 'US');
Insert into EmpDetails Values (2, 2, 45000, '2nd street', null, 'Miami', 'Florida', 'US');
Insert into EmpDetails Values (3, 3, 45000, '3rd street', null, 'Reston', 'Virginia', 'US');

Select * from Department;
Select * from Employee2;
Select * from EmpDetails;

Insert into Employee2(EmployeeId, FirstName, LastName) Values(4, 'Tina', 'Smith');
Insert into EmpDetails Values (4, 4, 45000, '4th street', null, 'Reston', 'Virginia', 'US');
Insert into Department(DeptId, Name) values (4, 'Marketing');

Update Employee2 Set DeptId = 4 where EmployeeId >1;

Select * from Employee2 
 where Employee2.DeptId = 4;

 Select Sum(Salary) from EmpDetails where EmployeeId in 
	(select EmployeeId from Employee2 where DeptId in 
		(select DeptId from Department where Department.Name = 'Marketing'));

Select Department.Name, Count(*) as numOfEmployees
From Department
	join Employee2 on Department.DeptId = Employee2.DeptId
	Group by Department.Name;

Update EmpDetails Set Salary = 90000 where EmployeeId =
	(select EmployeeId from Employee2 where FirstName = 'Tina' and LastName = 'Smith');