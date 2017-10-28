select CustomerID, FirstName + ' ' + LastName as FullName, Gender from Customers
order by FullName, CustomerID