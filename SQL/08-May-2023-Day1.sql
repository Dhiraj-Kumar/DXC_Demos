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

/*
Parts of SQL

1. DDL - Data Definition Language
	Create, Alter, Drop
2. DML - Data Manipulation Language
	Insert, Update, Delete
3. DCL - Data Control Language
	Grant, Revoke
4. DQL - Data Query Language
	Select
*/

-- DML Statements
-- Inserting data into customers table
Insert into Customers values (1, 'John', 'John@gmail.com', 'New Delhi', 25)
Insert into Customers (CustomerId, Email, CustomerName, Age, City) values (2, 'James@gmail.com', 'James', 30, 'Mumbai')

-- Partial Insert
Insert into Customers (CustomerId, CustomerName, Email, Age) values (3, 'Peter', 'Peter@gmail.com', 28)

-- Inserting multiple records
Insert into Customers values (4, 'Steve', 'Steve@gmail.com', 'Chennai', 27),(5, 'Maria', 'Maria@gmail.com', 'Kolkata', 25)

-- Modifying record using Update statement
Update Customers set City='Pune' where CustomerId=3
Update Customers set City='Hyderabad', Email='Maria@hotmail.com' where CustomerId=5

-- Delete row from a table
Delete from Customers where CustomerId=3

Select * from Customers


Use Northwind

Select * from Customers

Select CustomerId, ContactName, City, Country from Customers

Select * from Customers where CustomerID='BERGS'

Select * from Customers where City='London'

Select CustomerId, ContactName, City, Country from Customers where ContactTitle='Owner'

Select * from Products where UnitPrice>35

Select * from Customers where City='London' or City='Madrid'

Select * from Customers where Country='Brazil' and City='Sao Paulo'

Select * from Customers where Region is not null

Select * from Customers where not Region is null

Select * from Customers where not Country='Mexico'

Select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount, (UnitPrice*UnitsInStock)*10/100
as Discount from Products

Select * from Products where ProductID not between 11 and 20

Select * from Customers where City='London' or City='Madrid' or City='Paris' or City='Berlin'

Select * from Customers where City in ('London', 'Madrid', 'Paris', 'Berlin')

Select * from Customers where ContactName like 'A%'

Select * from Customers where ContactName like 'A_____________'

Select * from Customers where ContactName like '[^ASJ]%'

Select * from Customers where ContactName like 'A%S'

Select top 10 * from Customers

Select * from Customers Order By ContactName Desc

Select * from Customers

Select * from Customers Order By CustomerID offset 10 rows fetch next 5 rows only

Select distinct ContactTitle from Customers