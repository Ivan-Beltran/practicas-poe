INSERT INTO Members
VALUES
    ('josue ivan', '2024-08-05', 'ivanbeltran18@gamil.com'),
    ('juan jose', '2024-08-06', 'jose@gmail.com'),
    ('pedro antonio', '2024-09-09', 'pedro@gmail.com'),
    ('carlos daniel', '2024-09-14', 'carlos@gmail.com'),
    ('mario luis', '2024-10-20', 'mario@gmail.com');

SELECT * FROM Members

UPDATE Members 
SET FullName='juan gabriel'
WHERE FullName='juan jose';

DELETE FROM Members
WHERE MemberID=9