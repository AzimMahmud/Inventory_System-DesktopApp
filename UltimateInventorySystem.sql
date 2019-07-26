
/***	Object:  UltimateInventory Database      ***/

--Create database with customize location 
USE MASTER
IF DB_ID('UltimateInventory') IS NOT NULL
DROP DATABASE UltimateInventory
GO

CREATE DATABASE UltimateInventory
GO
--Show Database Properties
--EXEC sp_helpdb UltimateInventory
--GO

/***	 Create Schema name	***/
USE UltimateInventory
GO
CREATE SCHEMA store
GO


/***	Object:  Table Users		***/
USE UltimateInventory
CREATE TABLE store.Users
(
	UserID INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR (20) NOT NULL,
	LastName VARCHAR (20) NOT NULL,
	Contact VARCHAR (15) NOT NULL,
	Email VARCHAR(40) NOT NULL,
	UserName VARCHAR (20) NOT NULL,
	[Password] VARCHAR (20) NOT NULL,
	RoleName VARCHAR(12),
	UserImage VARCHAR(100) NULL,
	IsActive BIT DEFAULT 0,
	CHECK (Contact LIKE '[+][8][8][0][1][1-9][0-9][0-9][-][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

/***	Object:  Table Supplier		***/
Use UltimateInventory
CREATE TABLE store.Supplier
(
	SupplierID INT PRIMARY KEY IDENTITY,
	BusinessName VARCHAR (50) NOT NULL,
	ContactPersonName VARCHAR (30) NOT NULL,
	Email VARCHAR(40) NULL,
	Contact VARCHAR (15) NOT NULL,
	City VARCHAR (20) NULL,
	[State] VARCHAR (20) NULL,
	Country VARCHAR (20) NULL,
	IsActive BIT DEFAULT 0,
	CHECK (Contact LIKE '[+][8][8][0][1][1-9][0-9][0-9][-][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

/***	Object:  Table Customers		***/
Use UltimateInventory
CREATE TABLE store.Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	CustomerName VARCHAR (50) NOT NULL,
	Email VARCHAR(40) NULL,
	Contact VARCHAR (15) NOT NULL,
	City VARCHAR (20) NULL,
	[State] VARCHAR (20) NULL,
	Country VARCHAR (20) NULL,
	IsActive BIT DEFAULT 0,
	CHECK (Contact LIKE '[+][8][8][0][1][1-9][0-9][0-9][-][0-9][0-9][0-9][0-9][0-9][0-9]')
)
GO

/***	Object:  Table Category		***/
Use UltimateInventory
CREATE TABLE store.Category
(
	CategoryID INT PRIMARY KEY IDENTITY,
	CategoryName VARCHAR (40) NOT NULL,
	IsActive BIT DEFAULT 0
)
GO

/***	Object:  Table SubCategory		***/

USE UltimateInventory
CREATE TABLE store.SubCategory
(
	SubCategoryID INT PRIMARY KEY IDENTITY,
	SubCategoryName VARCHAR (40) NOT NULL,
	CategoryID INT FOREIGN KEY REFERENCES store.Category(CategoryID),
	IsActive BIT DEFAULT 0
)
GO

/***	Object:  Table Unit		***/
USE UltimateInventory
CREATE TABLE store.Unit
(
	UnitID INT IDENTITY PRIMARY KEY,
	UnitName VARCHAR (20) NOT NULL,
	ShortName VARCHAR (10) NULL,
	IsActive BIT DEFAULT 0
)
GO
/***	Object:  Table Products		***/
Use UltimateInventory
CREATE TABLE store.Products
(
	ProductID INT PRIMARY KEY IDENTITY,
	ProductName VARCHAR (40) NOT NULL,
	SubCategoryID INT FOREIGN KEY REFERENCES store.SubCategory(SubCategoryID),
	[Description] VARCHAR (200) NULL,
	UnitID INT FOREIGN KEY REFERENCES store.Unit(UnitID),
	UnitRate MONEY NULL,
	SalesMarginRate INT NOT NULL,
	SalesVatRate INT NOT NULL,
	ProductImage VARCHAR(100) NULL,
	IsActive BIT DEFAULT 0
)
GO

/***	Object:  Table Stock  ***/
USE UltimateInventory
CREATE TABLE store.Stock
(
	StockID INT PRIMARY KEY IDENTITY,
	ProductID INT FOREIGN KEY REFERENCES store.Products(ProductID),
	OpeningStock INT NOT NULL,
	CurrentStock INT NOT NULL
)
GO

/***	Object:  Table Transaction	  --for Purchase,Sales,PurchaseReturn,SalesReturn	***/

USE UltimateInventory
CREATE TABLE store.[Transaction]
(
	TransactionID INT IDENTITY PRIMARY KEY,
	TransactionTypeID VARCHAR (7) NOT NULL,
	TransactionType VARCHAR (30) NOT NULL,
	[Date] DATE DEFAULT (GETDATE()),
	ClientID INT NULL,
	ProductID INT FOREIGN KEY REFERENCES store.Products(ProductID),
	Rate MONEY NOT NULL,
	Quantity INT NOT NULL,
	GrossAmount AS (Rate*Quantity),
	--Computed Column
	Discount MONEY NULL,
	Vat MONEY NULL,
	NetAmount AS (((Rate*Quantity)-Discount)+Vat),
	--Computed Column
	UserID INT FOREIGN KEY REFERENCES store.Users(UserID)
)
GO


/* Object: View for Generate Sales Report */
CREATE VIEW store.vw_SalesReport
AS
	SELECT T.TransactionTypeID, T.[Date], P.ProductName, T.Quantity, T.Rate, T.NetAmount, T.GrossAmount, T.Discount, C.CustomerID, C.CustomerName
	FROM store.[Transaction] AS T JOIN store.Products AS P ON T.ProductID = P.ProductID JOIN store.Customers AS C ON T.ClientID = C.CustomerID
	WHERE C.CustomerID = T.ClientID
GO

/* Object: View for Generate Purchase Report */
CREATE VIEW store.vw_PurchaseReport
AS
	SELECT T.TransactionTypeID, T.[Date], P.ProductName, T.Quantity, T.Rate, T.NetAmount, T.GrossAmount, T.Discount, S.SupplierID, S.BusinessName
	FROM store.[Transaction] AS T JOIN store.Products AS P ON T.ProductID = P.ProductID JOIN store.Supplier AS S ON T.ClientID = S.SupplierID
	WHERE S.SupplierID = T.ClientID
GO


/***	 Object:  Table Invoice		***/
USE UltimateInventory
CREATE TABLE store.Invoice
(
	InvoiceID INT PRIMARY KEY IDENTITY,
	InvoiceDate DATE DEFAULT (GETDATE()),
	TransactionID INT FOREIGN KEY REFERENCES store.[Transaction](TransactionID),
	ReferenceInvoiceID INT NULL,
	--Previous InvoiceID used When Update
	Remarks VARCHAR (250) NULL
)
GO

/***	Object: Audit_Transaction  --Table for Firing Trigger		***/

USE UltimateInventory
CREATE TABLE store.Audit_Transaction
(
	AuditTranID INT IDENTITY PRIMARY KEY,
	TransactionID INT NOT NULL,
	TransactionTypeID INT NOT NULL,
	TransactionType VARCHAR (30) NOT NULL,
	[Date] DATE,
	ClientID INT NULL,
	ProductID INT NOT NULL,
	Rate MONEY NOT NULL,
	Quantity INT NOT NULL,
	GrossAmount MONEY,
	Discount MONEY NULL,
	Vat MONEY NULL,
	NetAmount MONEY NOT NULL,
	UserID INT NOT NULL,
	Activity VARCHAR (50) NOT NULL,
	ActionTime DATETIME NOT NULL
)
GO

/***	Object: Audit_Invoice Table for Firing Trigger		***/
USE UltimateInventory
CREATE TABLE store.Audit_Invoice
(
	AuditInvoiceID INT IDENTITY PRIMARY KEY,
	InvoiceID INT NOT NULL,
	InvoiceDate DATE NOT NULL,
	TransactionID INT NOT NULL,
	ReferenceInvoiceID INT NULL,
	Remarks VARCHAR (250) NULL ,
	Activity VARCHAR (50) NOT NULL,
	ActionTime DATETIME NOT NULL
)
GO

/***	Object: trg_InvoiceAfterUpdate   --Firing Trigger if any update occurs		***/
CREATE TRIGGER store.trg_InvoiceAfterUpdate ON store.Invoice
FOR UPDATE
AS
DECLARE 
@invoiceid INT, 
@invoicedate DATE, 
@transid INT, 
@refinvoiceid INT, 
@remarks VARCHAR(30), 
@activity VARCHAR(30)
BEGIN
	SELECT @invoiceid=i.InvoiceID
	FROM inserted i;
	SELECT @invoicedate=i.InvoiceDate
	FROM inserted i;
	SELECT @transid = i.TransactionID
	FROM inserted i;
	SELECT @refinvoiceid=i.ReferenceInvoiceID
	FROM inserted i;
	SELECT @remarks= i.Remarks
	FROM inserted i;
	SET @activity= 'DATA UPDATED!';
	IF UPDATE(TransactionID) 			
		SELECT @transid = i.TransactionID
	FROM inserted i;
	IF UPDATE(ReferenceInvoiceID) 
		SELECT @refinvoiceid=i.ReferenceInvoiceID
	FROM inserted i;
	IF UPDATE(InvoiceDate) 	
		SELECT @invoicedate=i.InvoiceDate
	FROM inserted i;
	IF UPDATE(Remarks) 
		SELECT @remarks= i.Remarks
	FROM inserted i;
	BEGIN
		INSERT INTO store.Audit_Invoice
			(InvoiceID,InvoiceDate,TransactionID,ReferenceInvoiceID,Remarks,Activity,ActionTime)
		VALUES
			(@invoiceid, @invoicedate, @transid, @refinvoiceid, @remarks, @activity, GETDATE())
	END
END
GO

/***	Object: trg_TransactionAfterUpdate   --Firing Trigger if any row updated		***/
CREATE TRIGGER store.trg_TransactionAfterUpdate ON store.[Transaction]
FOR UPDATE
AS
DECLARE
@transid INT, 
@trantypeid INT, 
@trantype VARCHAR(30), 
@clientid INT,
@productid INT,
@date DATE,
@rate MONEY,
@quantity INT,
@gross MONEY,
@discount MONEY,
@vat MONEY,
@netamount MONEY,
@userid INT,
@activity VARCHAR(30)
BEGIN
	SELECT @transid=a.TransactionID
	FROM inserted a;
	SELECT @trantypeid=a.TransactionTypeID
	FROM inserted a;
	SELECT @trantype = a.TransactionType
	FROM inserted a;
	SELECT @date= a.[Date]
	FROM inserted a;
	SELECT @clientid=a.ClientID
	FROM inserted a;
	SELECT @productid= a.ProductID
	FROM inserted a;
	SELECT @rate= a.Rate
	FROM inserted a;
	SELECT @quantity= a.Quantity
	FROM inserted a;
	SELECT @gross= a.GrossAmount
	FROM inserted a;
	SELECT @discount= a.Discount
	FROM inserted a;
	SELECT @vat= a.Vat
	FROM inserted a;
	SELECT @netamount= a.NetAmount
	FROM inserted a;
	SELECT @userid= a.UserID
	FROM inserted a;
	SET @activity= 'DATA UPDATED!';

	IF UPDATE(TransactionTypeID) 			
	SELECT @trantypeid=a.TransactionTypeID
	FROM inserted a;
	IF UPDATE(TransactionType) 			
	SELECT @trantype = a.TransactionType
	FROM inserted a;
	IF UPDATE([Date]) 			
	SELECT @date= a.[Date]
	FROM inserted a;
	IF UPDATE(ClientID) 			
	SELECT @clientid=a.ClientID
	FROM inserted a;
	IF UPDATE(ProductID) 			
	SELECT @productid= a.ProductID
	FROM inserted a;
	IF UPDATE(Rate) 			
	SELECT @rate= a.Rate
	FROM inserted a;
	IF UPDATE(Quantity) 			
	SELECT @quantity= a.Quantity
	FROM inserted a;
	IF UPDATE(Discount) 			
	SELECT @discount= a.Discount
	FROM inserted a;
	IF UPDATE(Vat) 			
	SELECT @vat= a.Vat
	FROM inserted a;
	IF UPDATE(UserID) 			
	SELECT @userid= a.UserID
	FROM inserted a;

	BEGIN
		INSERT INTO store.Audit_Transaction
			(TransactionID,TransactionTypeID,TransactionType,[Date],ClientID,ProductID,Rate,Quantity,GrossAmount,Discount,Vat,NetAmount,UserID,Activity,ActionTime)
		VALUES
			( @transid, @trantypeid, @trantype, @date, @clientid, @productid, @rate, @quantity, @gross, @discount, @vat, @netamount, @userid, @activity, GETDATE())
	END
END
GO


/*** Object: View vw_ProductstockInfo  --For check the Products Details    ***/

CREATE VIEW store.vw_ProductStockInfo
AS
	SELECT p.ProductName, c.SubCategoryName, u.UnitName, p.UnitRate, p.ProductImage, s.OpeningStock, s.CurrentStock
	FROM store.Products p
		JOIN store.Stock s
		ON p.ProductID=s.ProductID
		JOIN store.Unit u
		ON p.UnitID=u.UnitID
		JOIN store.SubCategory c
		ON p.SubCategoryID=c.SubCategoryID

GO
/***	Object: Sclar Valued Fuction	***/

/*create function for formatting a Contact number in Employee,Supplier and Customer table. This function will allow
only bangladeshi Contact numbers.  */


CREATE FUNCTION store.fn_Contact
(
	@cell VARCHAR (15)
)
RETURNS VARCHAR (15)
AS
BEGIN
	DECLARE @format VARCHAR(15)
	IF LEN(@cell)=11
	BEGIN
		SET @format='+88'+SUBSTRING(@cell,1,5)+'-'+SUBSTRING(@cell,6,6)
	END
	ELSE SET @format = @cell
	RETURN @format
END
GO
/***	Object:	Table Valued Function	***/
/*Create a Table Valued Function for Search by Customer Name	*/

-- CREATE FUNCTION store.fn_CustomerSearch
-- (
-- 	@Customer VARCHAR (50)
-- )
-- RETURNS TABLE 
-- AS
-- RETURN
-- 	SELECT * 
-- 	FROM store.Customers
-- 	WHERE CustomerName LIKE @Customer+'%'
-- GO

--select * from  store.fn_CustomerSearch ('b')


/***    Inserting Table Values     ***/

INSERT INTO store.Category
	(CategoryName,IsActive)
VALUES
	('Food', 1),
	('Baby Care', 1),
	('Home Appliances', 1),
	('Home and Clening', 1),
	('Office Products', 1)
GO

------------------------
INSERT INTO store.SubCategory
	(SubCategoryName,CategoryID,IsActive)
VALUES
	('Fruits and Vegetables', 1, 1),
	('Beverages', 1, 1),
	('Baby Accessories', 2, 1),
	('Diapers and Wipes', 2, 1),
	('Beverages', 1, 1),
	('Kitchen Appliance', 3, 1),
	('Tools and Hardware', 3, 1),
	('Kitchen Accessories', 4, 1),
	('Pest Control', 4, 1),
	('Printing', 5, 1),
	('Writing and Drawing', 5, 1)
GO
------------------------
INSERT INTO store.Unit
	(UnitName,ShortName,IsActive)
VALUES
	('Piece', 'pc', 1),
	('Kilogram', 'kg', 1),
	('Litre', 'ltr', 1),
	('Packets', 'pkt', 1),
	('Grams', 'g', 1)
GO

select sb.SubCategoryID, sb.SubCategoryName, c.CategoryName
from store.SubCategory sb join store.Category c on sb.CategoryID=sb.SubCategoryID
Where sb.IsActive=1 and c.CategoryName='Food'
select *
from store.Unit
------------------------
-----------------------
INSERT INTO store.Users
	(FirstName,LastName,Contact,Email,UserName,[Password],RoleName,UserImage,IsActive)
VALUES
	('Md', 'Ibrahim', store.fn_Contact('01822989685'), 'ibrahim@gmail.com', 'admin', '1234', 'admin', ' ', 1)
GO
--------------------
INSERT INTO store.Supplier
	(BusinessName,ContactPersonName,Email,Contact,City,State,Country,IsActive)
VALUES
	('Abul Khair', 'Nasir Ahmed', 'chemicalsupply@gmail.com', store.fn_Contact('01742853654'), 'Chittagong', 'Chittagong', 'Bangladesh', 1)
GO
-------------------------
INSERT INTO store.Customers
	(CustomerName,Email,Contact,City,State,Country,IsActive)
VALUES
	('Riduan Ahmed', 'bergerpaint@gmail.com', store.fn_Contact('01965321485'), 'Chittagong', 'Chittagong', 'Bangladesh', 1)
GO
select SubCategoryName
from store.SubCategory
where SubCategoryID=5
select *
from store.Products
select *
from store.Customers
select *
from store.Supplier
---------------------
INSERT INTO store.Products
	(ProductName,SubCategoryID,[Description],UnitID,UnitRate,SalesMarginRate,SalesVatRate,ProductImage,IsActive)
VALUES
	('Apple', 1, 'Importedn', 2, 120, 20, 0, NULL, 1)
GO
----------------------
CREATE FUNCTION store.fn_PID()
RETURNS VARCHAR (7)
AS
BEGIN
	DECLARE @lastval VARCHAR(7)
	SET @lastval=(SELECT MAX(CAST(RIGHT(TransactionTypeID,4) AS INT))
	FROM store.[Transaction]
	WHERE TransactionType='Purchase')
	IF @lastval IS NULL SET @lastval=0
	RETURN 'P-'+RIGHT('0000'+CONVERT(VARCHAR(10),(@lastval+1)),4)
END
GO

CREATE FUNCTION store.fn_SID()
RETURNS VARCHAR (7)
AS
BEGIN
	DECLARE @lastval VARCHAR(7)
	SET @lastval=(SELECT MAX(CAST(RIGHT(TransactionTypeID,4) AS INT))
	FROM store.[Transaction]
	WHERE TransactionType='Sales')
	IF @lastval IS NULL SET @lastval=0
	RETURN 'S-'+RIGHT('0000'+CONVERT(VARCHAR(10),(@lastval+1)),4)
END
GO

CREATE FUNCTION store.fn_PRID()
RETURNS VARCHAR (7)
AS
BEGIN
	DECLARE @lastval VARCHAR(7)
	SET @lastval=(SELECT MAX(CAST(RIGHT(TransactionTypeID,4) AS INT))
	FROM store.[Transaction]
	WHERE TransactionType='Purchase Return')
	IF @lastval IS NULL SET @lastval=0
	RETURN 'PR-'+RIGHT('0000'+CONVERT(VARCHAR(10),(@lastval+1)),4)
END
GO

CREATE FUNCTION store.fn_SRID()
RETURNS VARCHAR (7)
AS
BEGIN
	DECLARE @lastval VARCHAR(7)
	SET @lastval=(SELECT MAX(CAST(RIGHT(TransactionTypeID,4) AS INT))
	FROM store.[Transaction]
	WHERE TransactionType='Sales Return')
	IF @lastval IS NULL SET @lastval=0
	RETURN 'SR-'+RIGHT('0000'+CONVERT(VARCHAR(10),(@lastval+1)),4)
END
GO

CREATE PROC store.sp_Transaction
	(
	@transactionid INT,
	@operation VARCHAR(30),
	@transactiontype VARCHAR(30),
	@date DATE,
	@trasactiontypeid VARCHAR (7),
	@clientid INT,
	@productid INT,
	@rate MONEY,
	@quantity MONEY,
	@discountamount MONEY,
	@vatamount MONEY,
	@userid INT
)
AS
BEGIN
	IF(@transactiontype = 'Purchase')
		BEGIN
		SET @trasactiontypeid=store.fn_PID()
		IF(@operation = 'Insert')
				BEGIN
			INSERT INTO store.[Transaction]
				(TransactionTypeID,TransactionType,[Date],ClientID,ProductID,Rate,Quantity,Discount,Vat,UserID)
			VALUES
				(@trasactiontypeid, @transactiontype, @date, @clientid, @productid, @rate, @quantity, @discountamount, @vatamount, @userid);
		END
			ELSE IF (@operation = 'Update')
				BEGIN
			UPDATE store.[Transaction]  SET TransactionTypeID = @trasactiontypeid,TransactionType = @transactiontype,ClientID = @clientid,ProductID = @productid ,[Date] = @date,Rate = @rate,Quantity = @quantity,Discount = @discountamount,Vat =@vatamount,UserID = @userid WHERE TransactionID = @transactionid;
		END
			ELSE IF (@operation = 'Delete')
				BEGIN
			DELETE FROM store.[Transaction] WHERE TransactionID = @transactionid;
		END
	END
	ELSE if(@transactiontype = 'Sales')
		BEGIN
		SET @trasactiontypeid=store.fn_SID()
		if(@operation = 'Insert')
				BEGIN
			INSERT INTO store.[Transaction]
				(TransactionTypeID,TransactionType,[Date],ClientID,ProductID,Rate,Quantity,Discount,Vat,UserID)
			VALUES
				(@trasactiontypeid, @transactiontype, @date, @clientid, @productid, @rate, @quantity, @discountamount, @vatamount, @userid);
		END
			ELSE IF (@operation = 'Update')
				BEGIN
			UPDATE store.[Transaction]  SET TransactionTypeID = @trasactiontypeid,TransactionType = @transactiontype,ClientID = @clientid,ProductID = @productid ,[Date] = @date,Rate = @rate,Quantity = @quantity,Discount = @discountamount,Vat =@vatamount,UserID = @userid WHERE TransactionID = @transactionid;
		END
			ELSE IF (@operation = 'Delete')
				BEGIN
			DELETE FROM store.[Transaction] WHERE TransactionID = @transactionid;
		END
	END

	ELSE IF(@transactiontype = 'Purchase Return')
		BEGIN
		SET @trasactiontypeid=store.fn_PRID()
		IF(@operation = 'Insert')
				BEGIN
			INSERT INTO store.[Transaction]
				(TransactionTypeID,TransactionType,[Date],ClientID,ProductID,Rate,Quantity,Discount,Vat,UserID)
			VALUES
				(@trasactiontypeid, @transactiontype, @date, @clientid, @productid, @rate, @quantity, @discountamount, @vatamount, @userid);
		END
			ELSE IF (@operation = 'Update')
				BEGIN
			UPDATE store.[Transaction]  SET TransactionTypeID = @trasactiontypeid,TransactionType = @transactiontype,ClientID = @clientid,ProductID = @productid ,[Date] = @date,Rate = @rate,Quantity = @quantity,Discount = @discountamount,Vat =@vatamount,UserID = @userid WHERE TransactionID = @transactionid;
		END
			ELSE IF (@operation = 'Delete')
				BEGIN
			DELETE FROM store.[Transaction] WHERE TransactionID = @transactionid;
		END
	END

	ELSE IF(@transactiontype = 'Sales Return')
		BEGIN
		SET @trasactiontypeid=store.fn_SRID()
		IF(@operation = 'Insert')
				BEGIN
			INSERT INTO store.[Transaction]
				(TransactionTypeID,TransactionType,[Date],ClientID,ProductID,Rate,Quantity,Discount,Vat,UserID)
			VALUES
				(@trasactiontypeid, @transactiontype, @date, @clientid, @productid, @rate, @quantity, @discountamount, @vatamount, @userid);
		END
			ELSE IF (@operation = 'Update')
				BEGIN
			UPDATE store.[Transaction]  SET TransactionTypeID = @trasactiontypeid,TransactionType = @transactiontype,ClientID = @clientid,ProductID = @productid ,[Date] = @date,Rate = @rate,Quantity = @quantity,Discount = @discountamount,Vat =@vatamount,UserID = @userid WHERE TransactionID = @transactionid;
		END
			ELSE IF (@operation = 'Delete')
				BEGIN
			DELETE FROM store.[Transaction] WHERE TransactionID = @transactionid;
		END
	END
END
GO

--EXEC store.sp_Transaction 1, 'Insert', 'Sales', '10/02/2019', 1, 1, 1, 5, 200, 100, 20, 1
--GO
--select COUNT(TransactionID) AS TotalSale from store.[Transaction] WHERE TransactionTypeID Like 'S-%' group by TransactionID 
--select SUM(NetAmount) from store.[Transaction]  WHERE TransactionTypeID Like 'P-%'
select *
from store.Users
select *
from store.Unit

select *
from store.[Transaction]