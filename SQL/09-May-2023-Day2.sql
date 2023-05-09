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
Problem Statement
Note management app (similar to Google Keep) is used to take notes, add notes into categories and set reminders for a note. Create the necessary DB schema (SQL Server) including tables, relationships and add sample data into each table.

Expected Solution
Create the tables for Note, Category, Reminder, User, NoteReminder and NoteCategory.
User table fields: user_id, user_name, user_added_date, user_password, user_mobile
Note table fields: note_id, note_title, note_content, note_status, note_creation_date
Category table fields : category_id, category_name, category_descr, category_creation_date, category_creator
Reminder table fields : reminder_id, reminder_name, reminder_descr, reminder_type, reminder_creation_date, reminder_creator
Insert the rows into the created tables (Note, Category, Reminder, User, NoteReminder and NoteCategory) as per attached snapshot.
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

-- Creating Views
Alter View ProductDetailsView
as
Select ProductId, ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount, (UnitPrice*UnitsInStock)*10/100 as Discount from Products

Select * from ProductDetailsView

-- Creating Functions (UDF - User Defined Function)
-- Scalar function returns single value
Create Function Cube(@num int)
returns int
as
begin
	RETURN POWER(@num, 3)
end

Select dbo.Cube(5)

-- Table Valued Function (Inline)
Create Function GetCustomer(@city varchar(10))
returns table
as
return (Select * from Customers where City=@city)

Select * from GetCustomer('Paris')

-- Stored Procedures

Create Proc ShowCustomers
as
Select * from Customers

Exec ShowCustomers

Create Procedure SearchCustomer
@customerid varchar(5)
as
Select * from Customers where CustomerID=@customerid

Exec SearchCustomer 'BERGS'

Select * from Students

Alter Proc AddNewStudent
@rollno int,
@name varchar(10),
@marks int
as
begin
if(@marks>100)
begin
	print 'Marks cannot be greater than 100'
	rollback tran
end
else
	begin
		insert into Students values(@rollno, @name, @marks)
	end
end

Exec AddNewStudent 12, 'Jessabel', 98

