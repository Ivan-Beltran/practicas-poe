INSERT INTO Books
VALUES
	('cien a�os de soledad','gabriel garcia marquez',1967),
	('don quijote de la mancha','miguel de cervantes',1605),
	('el nido','alfredo espino',1990),
	('matar a un ruise�or','harper lee',1960),
	('orgullo y prejuicio','jane austen',1813);

SELECT * FROM Books

UPDATE Books
SET PublishedYear=1615
WHERE Title='don quijote de la mancha';

DELETE Books
WHERE Title='el nido'