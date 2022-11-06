# Yachts
demo

CREATE TABLE Invoice (
IdInvoice int PRIMARY KEY NOT NULL,
IdContract int NOT NULL,
Settled bit NOT NULL,
[Sum] int NOT NULL,
SumIncludeVAT int NOT NULL,
[Date] datetime NOT NULL
)

GO

CREATE TABLE [Partner] (
IdPartner int PRIMARY KEY NOT NULL,
[Name] NVARCHAR(100) NOT NULL,
[Address] NVARCHAR(100) NOT NULL,
City NVARCHAR(100) NOT NULL
)

GO

CREATE TABLE SalesPerson (
IdSalesPerson int PRIMARY KEY NOT NULL,
FirstName NVARCHAR(100) NOT NULL,
FamilyName NVARCHAR(100) NOT NULL
)

GO

CREATE TABLE Boat (
IdBoat int PRIMARY KEY NOT NULL,
Model NVARCHAR(100) NOT NULL,
BoatType NVARCHAR(100) NOT NULL,
NumberOfRowers int NOT NULL,
Mast bit NOT NULL,
Colour NVARCHAR(100) NOT NULL,
Wood NVARCHAR(100) NOT NULL,
BasePrice int NOT NULL,
VAT int NOT NULL
)

GO

CREATE TABLE OrderDetail (
IdDetail int PRIMARY KEY NOT NULL,
IdAccessory int NOT NULL,
IdOrder int NOT NULL
)

GO

CREATE TABLE Customer (
IdCustomer int PRIMARY KEY NOT NULL,
FirstName NVARCHAR(100) NOT NULL,
FamilyName NVARCHAR(100) NOT NULL,
DateOfBirth datetime NOT NULL,
OrganisationName NVARCHAR(100) NULL,
[Address] NVARCHAR(100) NOT NULL,
City NVARCHAR(100) NOT NULL,
email NVARCHAR(100) NOT NULL,
Phone NVARCHAR(50) NOT NULL,
IdNumber NVARCHAR(100) NOT NULL,
IdDocumentName NVARCHAR(100) NOT NULL
)

GO

CREATE TABLE [Contract] (
IdContract int PRIMARY KEY NOT NULL,
[Date] datetime NOT NULL,
DepositPayed int NOT NULL,
IdOrder int NOT NULL,
ContractTotalPrice int NOT NULL,
ContracTotalPriceIncludeVAT int NOT NULL,
ProductionProcess NVARCHAR(100) NOT NULL
)

GO

CREATE TABLE [Order] ( 
IdOrder int PRIMARY KEY IDENTITY(1,1) NOT NULL,
Date datetime,
IdSalesperson int NOT NULL,
IdCustomer int NOT NULL,
IdBoat int NOT NULL,
DeliveryAddress NVARCHAR(100) NOT NULL,
City NVARCHAR(100) NOT NULL
)

GO

CREATE TABLE Accessory ( 
IdAccessory int PRIMARY KEY IDENTITY(1,1) NOT NULL,
AccName NVARCHAR(100) NOT NULL,
DescriptionOfAccessory NVARCHAR(100) NOT NULL,
Price int NOT NULL,
VAT int NOT NULL,
Inventory int NOT NULL,
OrderLevel int NOT NULL,
OrderBatch int NOT NULL,
IdPartner int NOT NULL
)

GO

CREATE TABLE AccessoriesToBoat ( 
IdAccessoriesToBoat int PRIMARY KEY IDENTITY(1,1) NOT NULL,
IdAccessory int NOT NULL,
IdBoat int NOT NULL
)
