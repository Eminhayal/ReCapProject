CREATE TABLE [dbo].[Customers] (
    [UserId]      INT        NOT NULL,
	[CustomerId] INT NOT NULL,
    [CompanyName] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC), 
    CONSTRAINT [CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Rentals]([CustomerId])

);

