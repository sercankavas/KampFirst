SELECT * FROM Customers
WHERE City LIKE 's%';

SELECT * FROM Customers
WHERE City IN ('Paris','London');

INSERT INTO Customers (CustomerID, CompanyName, ContactName, Address, City, PostalCode, Country)
VALUES (92,'Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

Delete from Customers where CompanyName='Cardinal'

Select AVG(UnitPrice) from Products

select * from Customers where ContactName LIKE 'a%'

select * from Products