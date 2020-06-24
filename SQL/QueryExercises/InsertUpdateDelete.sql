-- 1. insert two new records into the employee table.
Select * from Employee;
Insert into Employee(EmployeeId, LastName, FirstName) Values (9,'Funtanilla', 'Noah');
Insert into Employee(EmployeeId, LastName, FirstName) Values (10,'Hello', 'World');

-- 2. insert two new records into the tracks table.
Select * From Track;
Select * From MediaType;
Insert into Track(TrackId, Name, UnitPrice, MediaTypeId, Milliseconds) Values (3504,'The Mountaineer', 1, 1, 300000);
Insert into Track(TrackId, Name, UnitPrice, MediaTypeId, Milliseconds) Values (3505,'Someone Out There', 1, 1, 300000);
-- 3. update customer Aaron Mitchell's name to Robert Walter
Select * From Customer where CustomerId = 32;
Update Customer Set FirstName = 'Robert', LastName = 'Walter' 
where CustomerId = 32;
-- 4. delete one of the employees you inserted.
Delete from Employee where Employee.FirstName = 'Hello';
-- 5. delete customer Robert Walter.
