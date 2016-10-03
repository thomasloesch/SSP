CREATE TABLE [dbo].[passTbl] (
    [Usr_Id] INT          NOT NULL,
    [Hash]   VARCHAR (50) NOT NULL,
    [Salt]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Usr_Id] ASC)
);

