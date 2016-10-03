CREATE TABLE [dbo].[userTbl] (
    [Id]          INT        IDENTITY (1, 1) NOT NULL,
    [UserName]    NCHAR (50) NOT NULL,
    [RoomBooked1] INT        NULL,
    [RoomBooked2] INT        NULL,
    [RoomBooked3] INT        NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

