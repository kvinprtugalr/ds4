USE Northwind;
GO	

SELECT ProductName, CompanyName, ContactName
FROM Products P
FULL JOIN  Suppliers S
ON P.SupplierID=S.SupplierID

SELECT OrderID, P.ProductID, ProductName
FROM Products P
INNER JOIN  [Order Details] OD
ON P.ProductID=OD.ProductID

SELECT OrderID,OrderDate, ShippedDate, ShippedDate + 5 AS RetrasoEnvio
FROM Orders

SELECT CategoryName AS [Nombre de categoria]
FROM Categories 

SELECT TOP 10 PERCENT OrderID, ProductID, Quantity
FROM [Order Details]

SELECT TOP 5 OrderID, ProductID, Quantity
FROM [Order Details]

SELECT DISTINCT OrderID FROM [Order Details]

SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID DESC

SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID ASC

SELECT EmployeeID, LastName
FROM Employees
WHERE LastName NOT LIKE 'D%'

SELECT EmployeeID, LastName, Title
FROM Employees
WHERE Title LIKE '%SALES%'

SELECT EmployeeID, LastName, Title
FROM Employees
WHERE LastName LIKE '%N'

SELECT EmployeeID, LastName
FROM Employees
WHERE LastName LIKE 'D%'

SELECT ProductID, ProductName, UnitPrice 
FROM Products
WHERE ProductID > 15 OR UnitPrice < 15 

SELECT ProductID, ProductName, UnitPrice 
FROM Products
WHERE NOT UnitPrice > 15 

SELECT ProductID, ProductName, UnitPrice 
FROM Products
WHERE UnitPrice BETWEEN 15 AND 50

SELECT ProductID, ProductName, UnitPrice 
FROM Products
WHERE UnitPrice >= 15 AND UnitPrice <= 50

SELECT ProductID, ProductName, UnitPrice 
FROM Products
WHERE UnitPrice > 15

SELECT ProductID, ProductName, UnitPrice FROM Products;


SELECT * FROM Products; 

