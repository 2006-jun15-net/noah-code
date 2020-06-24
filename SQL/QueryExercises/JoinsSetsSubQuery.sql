-- exercises
-- solve these with a mixture of joins, subqueries, CTE, and set operators.
-- solve at least one of them in two different ways, and see if the execution
-- plan for them is the same, or different.
-- 1. which artists did not make any albums at all?
Select Artist.*
From Artist
	left join Album on Artist.ArtistId = Album.ArtistId
	where Album.ArtistId is null;

Select ArtistId From Artist
except
Select ArtistId From Album;

Select *
From Artist where ArtistId Not in
	(Select ArtistId from Album);

-- 2. which artists did not record any tracks of the Latin genre?
-- join version
Select * from Artist
Except
Select ar.*
From Artist as ar
	join Album as al on ar.ArtistId = al.ArtistId
	join Track as t on al.AlbumId = t.AlbumId
	join Genre as g on t.GenreId = g.GenreId where g.Name = 'latin';

Select *
From Artist Where ArtistId NOT IN
	(Select ArtistId From Album where AlbumId IN
		(select AlbumId from Track where GenreId IN
			(Select GenreId from Genre where Genre.Name = 'latin')));
	
-- 3. which video track has the longest length? (use media type table)
-- 4. find the names of the customers who live in the same city as the
--    boss employee (the one who reports to nobody)
-- 5. how many audio tracks were bought by German customers, and what was
--    the total price paid for them?
-- 6. list the names and countries of the customers supported by an employee
--    who was hired younger than 35.