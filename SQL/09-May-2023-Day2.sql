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

-- Subqueries
Select * from Students

Select StudentName from Students where Marks = (Select Max(Marks) from Students)

Select * from Students where Marks = (Select Max(Marks) from Students where Marks<(Select MAX(Marks) from Students))

Select * from Students order by Marks Desc
Select * from Students order by Marks Desc offset 3 rows fetch next 1 rows only


/*
Write the queries to carry out the below listed operations:

Fetch the row from User table with Id=112233 and Password=’Maya1214’.
Fetch all the rows from Note table with note_creation_date=’01/31/2019’.
Fetch all the Categories created after ‘01/22/2019’.
Fetch all category details which belongs to note with note id=1.
Fetch all the Notes from the Note table with userId=112244.
Fetch all the Notes from the Note table for category_id=1.
Fetch all the reminder details for note id=2.
Write a query to change the note_status to ‘Completed’ with note Id=3.
Write a query to set a reminder of type ‘Personal Reminders’ for Note with note id=1. [Find reminder id based upon reminder_type]
Write a query to remove all reminders from Note with note_id=2.

*/