USE DBLibrary

SELECT
	Authors.Name
	,Authors.Surname
	,Books.Name
	,Books.Detalies
FROM Authors
JOIN AuthorsAndBooks ON Authors.ID = AuthorsAndBooks.AutoID
JOIN Books ON Books.Name = AuthorsAndBooks.BookName