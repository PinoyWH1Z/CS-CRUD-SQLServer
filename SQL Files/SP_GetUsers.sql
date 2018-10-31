USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetUsers]    Script Date: 10/31/2018 10:47:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetUsers]

AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

DECLARE @userLevel INT

SELECT id AS ID, uname AS Username, firstname AS Firstname, lastname AS Lastname, email AS Email, userlevel AS Userlevel FROM [dbo].[tbl_Users]

END
GO

