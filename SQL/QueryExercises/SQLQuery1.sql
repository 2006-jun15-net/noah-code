-- basic exercises (Chinook database)
-- 1. list all customers (full names, customer ID, and country) who are not in the US
select FirstName, LastName, CustomerId, Country From Customer where not Customer.Country = 'US';  
-- 2. list all customers from brazil
select * from Customer where Country = 'Brazil';
-- 3. list all sales agents
select * from Employee where Title = 'Sales Support Agent';
-- 4. show a list of all countries in billing addresses on invoices.
Select BillingCountry from Invoice where BillingAddress like BillingCountry;
-- 5. how many invoices were there in 2009, and what was the sales total for that year?
Select Count(InvoiceDate)From Invoice where InvoiceDate like '%2009%';
Select Sum(Total) from Invoice where InvoiceDate like '%2009%';
--    (extra challenge: find the invoice count sales total for every year, using one query)
-- 6. how many line items were there for invoice #37?
Select Count(*) from InvoiceLine where InvoiceId = '37';
-- 7. how many invoices per country?
Select BillingCountry, Count(*) from Invoice Group By BillingCountry;
-- 8. show total sales per country, ordered by highest sales first.
select BillingCountry, Sum(Total) as TotalSales From Invoice Group By BillingCountry Order By TotalSales DESC;

-- join exercises (Chinook database)
-- 1. show all invoices of customers from brazil (mailing address not billing)
Select * from Invoice 
left join Customer on Customer.CustomerId = Invoice.CustomerId where Country = 'Brazil';
-- 2. show all invoices together with the name of the sales agent of each one
Select Invoice.*, Customer.CustomerId, Employee.FirstName, Employee.LastName 
from Invoice 
	Left join Customer on Invoice.CustomerId = Customer.CustomerId
	left join Employee on EmployeeId = Customer.SupportRepId; 

-- 3. show all playlists ordered by the total number of tracks they have
Select Playlist.PlaylistId, Playlist.Name, Count(*) as numOfTracks 
from Playlist 
	left join PlaylistTrack on Playlist.PlaylistId = PlaylistTrack.PlaylistId
Group by Playlist.PlaylistId, Playlist.Name;
  
-- 4. which sales agent made the most in sales in 2009?
Select Employee.FirstName as fullname, Sum(Invoice.Total) as total
From Employee
	join Customer on Employee.EmployeeId = Customer.SupportRepId
	join Invoice on Customer.CustomerId = Invoice.CustomerId
Group By Employee.FirstName;
-- 5. how many customers are assigned to each sales agent?
-- 6. which track was purchased the most since 2010?
-- 7. show the top three best-selling artists.
-- 8. which customers have the same initials as at least one other customer?
select Substring(FirstName, 1, 1) + SUBSTRING(LastName,1,1)from Customer 
intersect
select Substring(FirstName, 1, 1) + SUBSTRING(LastName,1,1)from Customer; 
