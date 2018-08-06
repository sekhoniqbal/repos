
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/05/2018 02:23:06
-- Generated from EDMX file: C:\Users\sekho\source\repos\WebApplication4\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [College];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Depts'
CREATE TABLE [dbo].[Depts] (
    [Did] int IDENTITY(1,1) NOT NULL,
    [DName] nvarchar(max)  NOT NULL,
    [HOD] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Emps'
CREATE TABLE [dbo].[Emps] (
    [Eid] int IDENTITY(1,1) NOT NULL,
    [EName] nvarchar(max)  NOT NULL,
    [Salary] nvarchar(max)  NOT NULL,
    [Dob] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [DeptDid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Did] in table 'Depts'
ALTER TABLE [dbo].[Depts]
ADD CONSTRAINT [PK_Depts]
    PRIMARY KEY CLUSTERED ([Did] ASC);
GO

-- Creating primary key on [Eid] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [PK_Emps]
    PRIMARY KEY CLUSTERED ([Eid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptDid] in table 'Emps'
ALTER TABLE [dbo].[Emps]
ADD CONSTRAINT [FK_DeptEmp]
    FOREIGN KEY ([DeptDid])
    REFERENCES [dbo].[Depts]
        ([Did])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeptEmp'
CREATE INDEX [IX_FK_DeptEmp]
ON [dbo].[Emps]
    ([DeptDid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------