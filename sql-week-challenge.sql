

CREATE TABLE Customers (
	CustomerId INT IDENTITY(1,1) NOT NULL,
	FirstName NVARCHAR(255) NOT NULL,
	LastName NVARCHAR(255) NOT NULL,
	PRIMARY KEY(CustomerId)
);

CREATE TABLE Products(
	ProductId INT IDENTITY(1,1) NOT NULL,
	ProductName NVARCHAR(255) NOT NULL,
	Price MONEY NOT NULL CHECK(Price > 0),
	PRIMARY KEY(ProductId)
);

CREATE TABLE Orders(
	OrderId INT IDENTITY(1,1) NOT NULL,
	ProductId INT NOT NULL,
	CustomerId INT NOT NULL,
	PRIMARY KEY(OrderId),
	CONSTRAINT FK_Orders_Products_ProductId FOREIGN KEY(ProductId) REFERENCES Products(ProductId),
	CONSTRAINT FK_Orders_Customers_CustomerId FOREIGN KEY(CustomerId) REFERENCES Customers(CustomerId)
);

INSERT INTO Customers (FirstName, LastName) VALUES('John', 'Johnson'), ('Mark','Markson'), ('Matt', 'Mattson');
INSERT INTO Products(ProductName, Price) VALUES ('guitar', 100), ('piano', 2000), ('drum kit', 1500);
INSERT INTO Orders(ProductId, CustomerId) VALUES (1,1),(2,2),(3,3);

INSERT INTO Products(ProductName, Price) VALUES('iphone', 200);

INSERT INTO Customers(FirstName,LastName) VALUES('Tina', 'Smith');

INSERT INTO Orders(ProductId, CustomerId) VALUES(
	(SELECT ProductId From Products WHERE ProductName = 'iphone'),
	(SELECT CustomerId From Customers WHERE FirstName = 'Tina' and LastName = 'Smith'));

SELECT * FROM Orders WHERE CustomerId = (
		SELECT CustomerId FROM Customers WHERE FirstName = 'Tina' and LastName = 'Smith');


SELECT SUM(Price)
FROM Products
inner join Orders ON Orders.ProductId = (
	SELECT ProductId FROM Products WHERE ProductName = 'iphone');



UPDATE Products SET Price = 250 WHERE ProductName = 'iphone';

