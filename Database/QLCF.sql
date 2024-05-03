CREATE DATABASE QuanLyBanCoffee
GO

USE QuanLyBanCoffee
GO

-- Coffee
-- Loại coffee
-- Bàn
-- Tài khoản
-- Hóa đơn
-- Hóa đơn info

CREATE TABLE CoffeeTable --Bàn
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống' --Trống || có người
)
GO

CREATE TABLE Account --Tài khoản
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	PassWord NVARCHAR(100) NOT NULL,
	Type INT NOT NULL DEFAULT 0 --1: QuanLy || 0: NhanVien
)
GO

CREATE TABLE Category --Loại đồ uống
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO 

CREATE TABLE Drinks --Đồ uống
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	IDCategory INT NOT NULL,
	Price FLOAT NOT NULL

	FOREIGN KEY (IDCategory) REFERENCES Category(ID)
)
GO

CREATE TABLE Bill --Hóa đơn
(
	ID INT IDENTITY PRIMARY KEY,
	CheckIn DATE NOT NULL DEFAULT GETDATE(),
	CheckOut DATE DEFAULT NULL,
	IDTable INT NOT NULL,
	Status INT DEFAULT 0 --1: Đã thanh toán || 0: Chưa thanh toán
	
	FOREIGN KEY (IDTable) REFERENCES CoffeeTable(ID)
)
GO

CREATE TABLE BillInfo
(
	IDBill INT NOT NULL,
	IDDrinks INT NOT NULL,
	Count INT NOT NULL DEFAULT 0

	FOREIGN KEY (IDBill) REFERENCES Bill(ID),
	FOREIGN KEY (IDDrinks) REFERENCES Drinks(ID),
)
GO

INSERT INTO Category VALUES (N'Mocha')
INSERT INTO Category VALUES (N'Latte')
GO

INSERT INTO Drinks VALUES (N'Đen đá', 1, 10000)
INSERT INTO Drinks VALUES (N'Cafe Mocha 1', 1, 15000)
INSERT INTO Drinks VALUES (N'Cafe Mocha 2', 1, 20000)
INSERT INTO Drinks VALUES (N'Cafe Mocha 3', 1, 25000)
INSERT INTO Drinks VALUES (N'Cafe Latte', 2, 20000)
INSERT INTO Drinks VALUES (N'Cafe Latte 2', 2, 40000)
INSERT INTO Drinks VALUES (N'Cafe Latte 3', 2, 50000)
GO

declare @i int = 1
while @i<=10
begin
	insert into CoffeeTable (Name) Values (N'Bàn '+ CAST(@i as nvarchar(100)))
	set @i = @i+1;
end
go

INSERT INTO Bill (CheckIn, CheckOut, IDTable, Status) VALUES 
	(GETDATE(), GETDATE(), 1, 0),
	(GETDATE(), GETDATE(), 2, 0),
	(GETDATE(), GETDATE(), 1, 1)
	
GO

INSERT INTO BillInfo (IDBill, IDDrinks, Count) VALUES
	(1, 2, 2),
	(1, 5, 5),
	(2, 2, 4),
	(2, 3, 3),
	(3, 5, 4),
	(3, 1, 1)
GO

-- Đặt lại giá trị của bảng [YourTableName] về 1
DBCC CHECKIDENT ('Bill', RESEED, 1);
GO

CREATE PROCEDURE USP_INSERTBILLINFO 
@idbill INT, @iddrinks INT, @count INT
AS
BEGIN
	DECLARE @isExistBillInfo INT
	DECLARE @drinksCount INT = 1;

	SELECT @isExistBillInfo = bi.IDBill, @drinksCount = bi.count
	FROM BillInfo AS bi
	WHERE IDBill = @idbill AND IDDrinks = @iddrinks

	IF (@isExistBillInfo > 0)
	BEGIN
		DECLARE @newcount INT = @drinksCount + @count
		IF (@newcount > 0)
			UPDATE BillInfo SET Count = @newcount WHERE IDBill = @idbill AND IDDrinks = @iddrinks
		ELSE
			DELETE FROM BillInfo WHERE IDBill = @idbill AND IDDrinks = @iddrinks
	END
	ELSE
	BEGIN
		INSERT INTO BillInfo VALUES (@idbill, @iddrinks, @count)
	END
END
GO

GO
select * from CoffeeTable
select * from Drinks
select * from Bill
select * from BillInfo