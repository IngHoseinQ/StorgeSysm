
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/26/2023 02:11:01
-- Generated from EDMX file: C:\Users\pc\source\repos\StorgeSysm\StorgeSysm\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SyStorgeData];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[SyStorgeDataModelStoreContainer].[FK__Outgoing__Part_I__6E01572D]', 'F') IS NOT NULL
    ALTER TABLE [SyStorgeDataModelStoreContainer].[Outgoing] DROP CONSTRAINT [FK__Outgoing__Part_I__6E01572D];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Incoming]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Incoming];
GO
IF OBJECT_ID(N'[dbo].[Parts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Parts];
GO
IF OBJECT_ID(N'[dbo].[STORAGE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[STORAGE];
GO
IF OBJECT_ID(N'[dbo].[Workers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Workers];
GO
IF OBJECT_ID(N'[SyStorgeDataModelStoreContainer].[Maintenance]', 'U') IS NOT NULL
    DROP TABLE [SyStorgeDataModelStoreContainer].[Maintenance];
GO
IF OBJECT_ID(N'[SyStorgeDataModelStoreContainer].[Mechanisms]', 'U') IS NOT NULL
    DROP TABLE [SyStorgeDataModelStoreContainer].[Mechanisms];
GO
IF OBJECT_ID(N'[SyStorgeDataModelStoreContainer].[Outgoing]', 'U') IS NOT NULL
    DROP TABLE [SyStorgeDataModelStoreContainer].[Outgoing];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'STORAGE'
CREATE TABLE [dbo].[STORAGE] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StoreName] nvarchar(100)  NOT NULL,
    [KeeperName] nvarchar(100)  NOT NULL,
    [deckTitle] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Incoming'
CREATE TABLE [dbo].[Incoming] (
    [id] int  NOT NULL,
    [Part_Id] int  NULL,
    [Incoming_Date] datetime  NULL,
    [Incoming_Balance] decimal(10,2)  NULL,
    [Delivery_Note_Number] varchar(20)  NULL,
    [Supplier_Name] varchar(50)  NULL,
    [Supplier_Entity] varchar(50)  NULL,
    [Shelf_Number] int  NULL,
    [storag_Id] int  NULL
);
GO

-- Creating table 'Parts'
CREATE TABLE [dbo].[Parts] (
    [id] int  NOT NULL,
    [Part_Name] varchar(50)  NULL,
    [Remaining_Balance] int  NULL
);
GO

-- Creating table 'Workers'
CREATE TABLE [dbo].[Workers] (
    [id] int  NOT NULL,
    [Worker_Name] varchar(50)  NULL,
    [Occupation] varchar(50)  NULL,
    [National_ID] varchar(20)  NULL,
    [Military_ID] varchar(20)  NULL,
    [Received_Amount] int  NULL,
    [Date] datetime  NULL,
    [Achievement_Report] varchar(100)  NULL,
    [Unfinished_Work] varchar(100)  NULL,
    [Under_Construction] varchar(100)  NULL,
    [Supervisor] varchar(50)  NULL
);
GO

-- Creating table 'Maintenance'
CREATE TABLE [dbo].[Maintenance] (
    [id] int  NOT NULL,
    [Plate_Number] varchar(20)  NULL,
    [Engineer_Name] varchar(50)  NULL,
    [Part_Id] int  NULL,
    [Cost] decimal(10,2)  NULL
);
GO

-- Creating table 'Outgoing'
CREATE TABLE [dbo].[Outgoing] (
    [id] int  NOT NULL,
    [Issue_Order_Number] varchar(20)  NULL,
    [Beneficiary_Entity] varchar(50)  NULL,
    [Plate_Number] varchar(20)  NULL,
    [Part_Id] int  NULL,
    [Outgoing_Date] datetime  NULL,
    [Issue_Note_Number] varchar(20)  NULL,
    [Outgoing_Balance] decimal(10,2)  NULL,
    [Issued_Quantity] decimal(10,2)  NULL,
    [storag_Id] int  NOT NULL
);
GO

-- Creating table 'Mechanisms'
CREATE TABLE [dbo].[Mechanisms] (
    [id] int  NOT NULL,
    [Mechanism_Type] varchar(50)  NULL,
    [Model] varchar(50)  NULL,
    [Seat_Number] varchar(50)  NULL,
    [Color] varchar(50)  NULL,
    [Engine_Number] varchar(50)  NULL,
    [Mechanism_Work] varchar(100)  NULL,
    [Driver_Name] varchar(50)  NULL,
    [Affiliated_Entity] varchar(50)  NULL,
    [Plate_Number] varchar(50)  NULL,
    [Fault_Type] varchar(100)  NULL,
    [Entry_Date] datetime  NULL,
    [Exit_Date] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'STORAGE'
ALTER TABLE [dbo].[STORAGE]
ADD CONSTRAINT [PK_STORAGE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'Incoming'
ALTER TABLE [dbo].[Incoming]
ADD CONSTRAINT [PK_Incoming]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Parts'
ALTER TABLE [dbo].[Parts]
ADD CONSTRAINT [PK_Parts]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [PK_Workers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Maintenance'
ALTER TABLE [dbo].[Maintenance]
ADD CONSTRAINT [PK_Maintenance]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Outgoing'
ALTER TABLE [dbo].[Outgoing]
ADD CONSTRAINT [PK_Outgoing]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Mechanisms'
ALTER TABLE [dbo].[Mechanisms]
ADD CONSTRAINT [PK_Mechanisms]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------