CREATE TABLE [dbo].[Rentals]
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NULL, 
    [RentDate] DATETIME NULL, 
    [ReturnDate] DATETIME NULL, 

)
