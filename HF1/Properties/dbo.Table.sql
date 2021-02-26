CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NULL, 
    [Company] NVARCHAR(50) NULL, 
    [Telephone] NVARCHAR(50) NULL, 
    [E-Mail] NVARCHAR(50) NULL, 
    [Client] BIT NULL, 
    [LastCall] DATETIME2 NULL
)
