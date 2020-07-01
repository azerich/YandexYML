USE [Test];
GO
CREATE TABLE [dbo].[Offers](
	[Id] [int] NOT NULL,
	[Items] [nvarchar](max) NOT NULL,
	[ItemsElementName] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Bid] [nchar](10) NOT NULL,
	[CBid] [nchar](10) NOT NULL,
	[Available] [int] NOT NULL);

USE TEST;
GO
CREATE PROCEDURE [InsertOffer]
	  @Items NVARCHAR(MAX)
	, @ItemsElementName NVARCHAR(MAX)
	, @Id INT
	, @Type NCHAR(10)
	, @Bid NCHAR(10)
	, @CBid NCHAR(10) = 0
	, @Available INT = 0
AS
	INSERT INTO Offers(Items, ItemsElementName, Id, Type, Bid, CBid, Available)
	VALUES(@Items, @ItemsElementName, @Id, @Type, @Bid, @CBid, @Available)

	SELECT SCOPE_IDENTITY()
GO

SELECT * FROM Offers;
DELETE FROM Offers;