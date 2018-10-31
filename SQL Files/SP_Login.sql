USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 10/31/2018 10:47:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Login]
(
	@uname VARCHAR(50),  @pass VARCHAR(50)
)
AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

DECLARE @userLevel INT

SET @userLevel = (SELECT userlevel
FROM [dbo].[tbl_Users]
WHERE [uname] = @uname AND [pword] = @pass)

IF @userLevel > 0
BEGIN
SELECT @userLevel
END

ELSE
BEGIN
SELECT 0;
END

END


GO

