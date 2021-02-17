CREATE TABLE [dbo].[Users] (
    [UserId]    INT           NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
    [Email]     NVARCHAR (50) NOT NULL,
    [Password]  NCHAR (20)    NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC), 
    
    
	
);

