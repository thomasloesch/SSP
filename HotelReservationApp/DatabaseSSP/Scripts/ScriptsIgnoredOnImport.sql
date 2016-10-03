
SET IDENTITY_INSERT [dbo].[roomTbl] ON
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (1, 1, N'Standard                      ', 1, N'Twin                          ', CAST(50.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (2, 2, N'Standard                      ', 1, N'Full                          ', CAST(60.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (3, 3, N'Standard                      ', 1, N'Queen                         ', CAST(65.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (4, 4, N'Standard                      ', 1, N'King                          ', CAST(70.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (5, 5, N'Standard                      ', 2, N'Twin                          ', CAST(75.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (7, 11, N'Suite                         ', 4, N'Twin                          ', CAST(150.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (8, 13, N'Suite                         ', 2, N'Queen                         ', CAST(160.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (9, 15, N'Standard                      ', 1, N'Full                          ', CAST(60.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (10, 21, N'Suite                         ', 2, N'King                          ', CAST(180.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (11, 23, N'Standard                      ', 1, N'Queen                         ', CAST(65.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (12, 24, N'Standard                      ', 2, N'Twin                          ', CAST(75.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (13, 25, N'Standard                      ', 1, N'Full                          ', CAST(60.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (14, 31, N'Suite                         ', 3, N'Full                          ', CAST(200.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (15, 33, N'Standard                      ', 2, N'Twin                          ', CAST(75.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (16, 34, N'Standard                      ', 1, N'Queen                         ', CAST(65.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (17, 35, N'Standard                      ', 1, N'King                          ', CAST(70.00 AS Decimal(10, 2)))
GO

INSERT INTO [dbo].[roomTbl] ([Id], [RoomNum], [RoomType], [Beds], [BedType], [Price]) VALUES (18, 41, N'Penthouse                     ', 3, N'King                          ', CAST(400.00 AS Decimal(10, 2)))
GO

SET IDENTITY_INSERT [dbo].[roomTbl] OFF
GO
