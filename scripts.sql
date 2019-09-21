USE [RestaurantDB]
GO

--INSERT INTO [dbo].[Customers] ([Name]) VALUES ('Sridevi')
--INSERT INTO [dbo].[Customers] ([Name]) VALUES ('Nitya')

select * from Customers


--delete  from Items
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Roti','10')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Naans','30')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Kadai Paneer','200.00')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Chicken Tikka Masala','150')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Aloo Kurma','70')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Butter milk','15')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Fish curry','300')
--INSERT INTO [dbo].[Items]([ItemName],[price]) VALUES ('Jeera rice','100')

select * from items

--INSERT INTO [dbo].[Orders]([OrderNo] ,[PaymentMethod] ,[GrandTotal] ,[CustomerId])
--     VALUES ('ORD123','Cash','2000',1)

select * from Orders

SELECT 
    [Extent1].[OrderId] AS [OrderId], 
    [Extent1].[OrderNo] AS [OrderNo], 
    [Extent1].[PaymentMethod] AS [PaymentMethod], 
    [Extent1].[GrandTotal] AS [GrandTotal], 
    [Extent1].[CustomerId] AS [CustomerId]
    FROM [dbo].[Orders] AS [Extent1]
