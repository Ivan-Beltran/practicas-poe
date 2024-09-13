INSERT INTO Loans
VALUES
	('2024-10-15',1,5),
	('2024-10-20',1,6),
	('2024-10-29',2,6),
	('2024-10-31',4,7),
	('2024-11-02',5,8);

SELECT * FROM Loans

UPDATE Loans
SET LoanDate='2024-11-01'
WHERE LoanID=5

DELETE FROM Loans
WHERE LoanID=4