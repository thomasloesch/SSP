CREATE TABLE [dbo].[bookedTbl] (
    [Id]     INT      IDENTITY (1, 1) NOT NULL,
    [RoomId] INT      NOT NULL,
    [UserId] INT      NOT NULL,
    [To]     DATETIME NOT NULL,
    [From]   DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

