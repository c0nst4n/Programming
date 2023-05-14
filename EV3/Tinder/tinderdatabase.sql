CREATE DATABASE TINDER

CREATE TABLE TUSER(
	iduser		INT IDENTITY (1, 1),
	name		VARCHAR(100) NOT NULL,
	age			INT NOT NULL,
	description VARCHAR(250) NOT NULL,
	gender		VARCHAR(50) NOT NULL,
	rating		INT NOT NULL,
	photo		VARCHAR(MAX) NOT NULL,

	CONSTRAINT PK_USER PRIMARY KEY(iduser),
	CONSTRAINT CK_RATING CHECK(rating > -1 AND  rating < 5)

);


INSERT INTO TUSER
VALUES('globotrogos', 105, 'Humano normal con gustos terricolas', 'macho', 3, 'https://i.kym-cdn.com/photos/images/original/002/575/250/f5d')

CREATE OR ALTER PROCEDURE addUser(@name VARCHAR(100), @age SMALLINT, @description VARCHAR(250), @gender VARCHAR(50), @rating SMALLINT, @photo VARCHAR(MAX))
AS
BEGIN
	BEGIN TRY
		IF @name <> NULL OR @age <> NULL OR @description <> NULL OR @gender <> NULL OR @rating <> NULL OR @rating > -1 OR @photo <> NULL
		BEGIN
			INSERT INTO TUSER(name, age, description, gender, rating, photo)
			VALUES(@name, @age, @description, @gender, @rating, @photo)
		END

	END TRY
	BEGIN CATCH
	PRINT CONCAT('codError =', ERROR_NUMBER(),
						', Descripcion=', ERROR_MESSAGE(),
						', Linea= ', ERROR_LINE(),
						', procedimiento ', ERROR_PROCEDURE())
	END CATCH
END


CREATE OR ALTER PROCEDURE removeUser(@idUser INT)
AS
BEGIN
    BEGIN TRY
        IF(@idUser IS NULL OR @idUser <= 0)
        BEGIN
            PRINT('Invalid ID')
            RETURN -1
        END
        IF NOT EXISTS(SELECT * FROM TUSER WHERE iduser = @idUser)
        BEGIN
            PRINT('User does not exist')
            RETURN -1
        END
        BEGIN TRAN
            DELETE FROM TUSER WHERE iduser = @idUser
        COMMIT
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT CONCAT('codError = ', ERROR_NUMBER(),
                     ', Descripcion = ', ERROR_MESSAGE(),
                     ', linea = ', ERROR_LINE(),
                     ' Procedimiento = ', ERROR_PROCEDURE());
    END CATCH
END


SELECT *
	FROM TUSER

CREATE OR ALTER PROCEDURE updateUser(@iduser INT, 
@name VARCHAR(100), @age SMALLINT, @description VARCHAR(250), @gender VARCHAR(50), @rating SMALLINT, @photo VARCHAR(MAX))
AS
BEGIN
	BEGIN TRY
		UPDATE TUSER
		SET name = @name,
		age = @age,
		description = @description,
		gender = @gender,
		rating = @rating,
		photo = @photo
		WHERE iduser = @iduser
	END TRY
	BEGIN CATCH
		PRINT CONCAT('codError =', ERROR_NUMBER(),
						', Descripcion=', ERROR_MESSAGE(),
						', Linea= ', ERROR_LINE(),
						', procedimiento ', ERROR_PROCEDURE())
	END CATCH
END

CREATE OR ALTER FUNCTION searchPerson(@pattern VARCHAR(80),@offset INT,@limit INT)
RETURNS TABLE AS
	RETURN ( SELECT *
				FROM TUSER
				WHERE name LIKE @pattern + '%'
				ORDER BY name ASC
				OFFSET @offset ROWS
				FETCH NEXT @limit ROWS ONLY);

