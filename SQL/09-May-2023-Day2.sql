Select * from Products

-- Aggregate functions - SUM, AVG, COUNT, MIN, MAX
Select MAX(UnitPrice) from Products

-- String Functions
-- Char function for getting a character based on ASCII value
Select CHAR(65)

Select LEFT('RICHARD',4)

Select LEN('Welcome')

Select REVERSE('Good Morning')

Select * from Customers
Select LEFT(ContactName, 4) from Customers
Select REVERSE(ContactName) from Customers

-- Date functions
Select GETDATE()

Select DATEADD(yyyy, 3, '2023-05-09')

Select DAY('2023-05-09')
Select MONTH('2023-05-09')
Select YEAR('2023-05-09')

Select OrderDate, DATEADD(dd, 3, OrderDate) as DeliveryDate from Orders

Select DATEDIFF(mm, '2023-01-09', '2023-05-09')

-- Math functions
Select POWER(2,3)

Select ROUND(3.567, 0)

Select CEILING(4.2)

Select FLOOR(4.9)

-- Group By Clause
Select SupplierID, SUM(UnitsInStock) as TotalStock from Products group by SupplierID having SupplierID=5

-- Joins
/*
Types of Joins
1. Inner Join
2. Outer Join
	Left Outer Join
	Right Outer Join
	Full Outer Join
3. Self Join
*/

-- Inner Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers inner join Orders on 
Customers.CustomerID=Orders.CustomerID

-- Left Outer Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers left outer join Orders on 
Customers.CustomerID=Orders.CustomerID

-- Right Outer Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers right outer join Orders on 
Customers.CustomerID=Orders.CustomerID

-- Full Outer Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers full outer join Orders on 
Customers.CustomerID=Orders.CustomerID

-- Self Join
Select * from Emp
Select Emp.EmpName, Emp2.EmpName as ReportsTo from Emp inner join Emp as Emp2 on Emp.MgrId = Emp2.EmpId