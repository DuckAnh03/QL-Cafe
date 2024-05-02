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
	status NVARCHAR(100) --Trống || có người
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
	CheckOut DATE ,
	IDTable INT NOT NULL,
	Status INT NOT NULL --1: Đã thanh toán || 0: Chưa thanh toán
	
	FOREIGN KEY (IDTable) REFERENCES CoffeeTable(ID)
)
GO

CREATE TABLE BillInfo
(
	ID INT IDENTITY PRIMARY KEY,
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
INSERT INTO Drinks VALUES (N'Cafe Latte', 2, 20000)
GO

