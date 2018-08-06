
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/05/2018 21:56:15
-- Generated from EDMX file: C:\Users\sekho\source\repos\Test\Models\Model1.edmx
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

IF OBJECT_ID(N'[dbo].[FK_DeptEmp]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Emps] DROP CONSTRAINT [FK_DeptEmp];
GO
IF OBJECT_ID(N'[dbo].[FK_EmpUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_EmpUser];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Depts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Depts];
GO
IF OBJECT_ID(N'[dbo].[Emps]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Emps];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

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

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
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

-- Creating primary key on [Username] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Username] ASC);
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