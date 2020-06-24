--Examples:
        Select * from Employee;
        Select '9' + Convert(VARCHAR, 4 + 5);
          
        Select FirstName, LastName from Employee 
		Where Substring(LastName, 1,1) = 'p';
		--Where LastName >= 'p' and LastName <= 'q';
		--where LastName Between 'p' and 'q'; -- not exactly right - inclusive of both ends
		--Where LastName like 'p%'
		--in SQL, indexes start at 1
		-- text comparison is case-insensitvie by default
		-- the like operator takes a special template string to compare with
		-- _ means any one character
		-- % means any character
		-- [abc] means one of a, b, or c
		-- builtin functions to extract parts of a date e.g. YEAR()

		--Cross Joins
			Select * From Employee as e2
			Cross join Employee as e1;

		--if it's not cross join, you must have a condition to join on
		-- display every track name with its genre
		Select Track.Name, Genre.Name as Genre
		From Track inner join Genre on Track.GenreId = Genre.GenreId;

		-- all rock songs, shown in the format "artist - song"
		-- Coalasce function will provide an alternate value in case of NULL
		Select Coalesce(ar.Name, 'N/A') + ' - ' + t.Name
		From Track as t
			left join Genre as g on t.GenreId = g.GenreId
			left join Album as al on t.AlbumId = al.AlbumId
			left join Artist as ar on al.AlbumId = ar.ArtistId
		where g.Name = 'rock';