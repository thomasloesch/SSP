CREATE TABLE [dbo].[roomTbl] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [RoomNum]  SMALLINT        NOT NULL,
    [RoomType] NCHAR (30)      NOT NULL,
    [Beds]     SMALLINT        NOT NULL,
    [BedType]  NCHAR (30)      NOT NULL,
    [Price]    DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

