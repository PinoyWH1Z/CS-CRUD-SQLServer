USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_AddUser2]    Script Date: 10/31/2018 10:46:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AddUser2]
@uname VARCHAR(50),
@pword VARCHAR(50),
@fname VARCHAR(50),
@lname VARCHAR(50),
@email VARCHAR(50),
@ulevel VARCHAR(50)

AS

SET NOCOUNT ON

INSERT INTO [dbo].[tbl_Users]
           (uname
           ,pword
           ,firstname
           ,lastname
           ,email
           ,userlevel)
     VALUES
           (@uname
           ,@pword
           ,@fname
           ,@lname
           ,@email
           ,@ulevel)
GO

