CREATE TABLE [dbo].[Player]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [TeamId] UNIQUEIDENTIFIER NOT NULL, 
    [FirstName] NCHAR(10) NULL, 
    [LastName] NCHAR(10) NULL, 
    [PlayerPosition] TINYINT NULL, 
    [BirthDay] DATETIME NULL, 
    [PlayerNationalityId] TINYINT NOT NULL, 
    [Price] DECIMAL NULL, 
    [IsInTransfer] BIT NULL
)
