CREATE TABLE STUDENT(
	idstudent INT IDENTITY(1,1),
	name		VARCHAR(50),
	age			INT,

	CONSTRAINT PK_student PRIMARY KEY (idstudent)
);

INSERT INTO STUDENT(name, age)
VALUES('pupu', 18)

SELECT *
	FROM STUDENT

CREATE FUNCTION GetUserName(@userId INT) RETURNS VARCHAR(50) AS
BEGIN
DECLARE @result VARCHAR(50)
SELECT @result = name 
	FROM STUDENT 
 WHERE idstudent = @userId
 RETURN @result;
END

SELECT dbo.GetUserName(1);
 
