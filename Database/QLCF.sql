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

CREATE TABLE Coffee_Table --Bàn
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

CREATE TABLE DrinksCategory --Loại đồ uống
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
)
GO 

CREATE TABLE Drinks --Đồ uống
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	ID_DrinksCategory INT NOT NULL,
	Price FLOAT NOT NULL

	FOREIGN KEY (ID_DrinksCategory) REFERENCES DrinksCategory(ID)
)
GO

CREATE TABLE Bill --Hóa đơn
(
	ID INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE ,
	ID_Table INT NOT NULL,
	Status INT NOT NULL --1: Đã thanh toán || 0: Chưa thanh toán
	
	FOREIGN KEY (ID_Table) REFERENCES Coffee_Table(ID)
)
GO

CREATE TABLE BillInfo
(
	ID INT IDENTITY PRIMARY KEY,
	ID_Bill INT NOT NULL,
	ID_Drinks INT NOT NULL,
	Count INT NOT NULL DEFAULT 0

	FOREIGN KEY (ID_Bill) REFERENCES Bill(ID),
	FOREIGN KEY (ID_Drinks) REFERENCES Drinks(ID),
)
GO

INSERT INTO DrinksCategory VALUES (N'Mocha')
INSERT INTO DrinksCategory VALUES (N'Latte')
GO

INSERT INTO Drinks VALUES (N'Đen đá', 1, 10000)
INSERT INTO Drinks VALUES (N'Cafe Latte', 2, 20000)
GO


