CREATE TABLE [dbo].[Table]
(
	[CustomeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(20) NULL, 
    [Zip] NCHAR(10) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [CreditLimit] SMALLMONEY NOT NULL, 
    [CustomerSince] SMALLDATETIME NOT NULL
)
