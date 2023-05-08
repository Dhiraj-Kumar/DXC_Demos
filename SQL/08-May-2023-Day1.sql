Create Database TestDB

Use TestDB

Create Table Customers 
(
CustomerId int primary key, 
CustomerName varchar(20),
Email varchar(20),
City varchar(10),
Age int
)

Drop Table Customers

Create Table Orders
(
OrderId int primary key,
OrderDate datetime,
Amount int,
CustomerId int references Customers(CustomerId)
)

Drop Table Orders

Create Table Products
(
ProductId int,
ProductName varchar(50),
Brand varchar(20),
Quantity int,
Price int
)

-- Adding new column in products table
Alter Table Products add ProductDescription varchar(50)

-- Removing column from products table
Alter Table Products drop column ProductDescription

-- Constraints
-- Check Constraint to restrict the value of Quantity column
Alter Table Products add constraint check_qty check(Quantity>0)

-- Adding primary key in existing table
Alter Table Products alter column ProductId int not null
Alter Table Products add constraint pk1 primary key(ProductId)

-- Removing check constraint from products table
Alter Table Products drop constraint check_qty

-- Dropping foriegn key from Orders table
Alter Table Orders drop constraint FK__Orders__Customer__3B75D760

-- Adding foriegn key on orders table using alter statement
Alter Table Orders add constraint fk1 foreign key(CustomerId) references Customers(CustomerId)