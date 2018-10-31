USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_UpdateUser]    Script Date: 10/31/2018 10:47:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_UpdateUser]
(
@id INT,
@uname VARCHAR(50),
@fname VARCHAR(50),
@lname VARCHAR(50),
@email VARCHAR(50),
@ulevel INT
)

AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

UPDATE [tbl_Users] SET uname = @uname, firstname = @fname, 
lastname = @lname, email = @email, userlevel = @ulevel
WHERE id = @id

END
GO

