USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_DeleteUser]    Script Date: 10/31/2018 10:46:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteUser]
(
@id INT
)

AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

DELETE FROM [tbl_Users] WHERE id = @id

END

GO

