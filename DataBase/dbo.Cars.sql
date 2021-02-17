CREATE TABLE [dbo].[Cars] (
    [CarId]          INT           NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [ModelYear]   INT           NOT NULL,
    [DailyPrice]  DECIMAL (18)  NOT NULL,
    [Description] VARCHAR (50)  NULL,
    [CarName]     NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([CarId] ASC),
    CONSTRAINT [BrandId] FOREIGN KEY ([BrandId]) REFERENCES [dbo].[Brands] ([BrandId]),
    CONSTRAINT [ColorId] FOREIGN KEY ([ColorId]) REFERENCES [dbo].[Colors] ([ColorId]), 
    CONSTRAINT [CarId] FOREIGN KEY ([CarId]) REFERENCES [Rentals]([CarId])
);

