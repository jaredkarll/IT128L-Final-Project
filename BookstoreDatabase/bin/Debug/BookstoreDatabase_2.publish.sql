﻿/*
Deployment script for BookShelfStoreDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "BookShelfStoreDatabase"
:setvar DefaultFilePrefix "BookShelfStoreDatabase"
:setvar DefaultDataPath "C:\Users\LEGIONRED\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\LEGIONRED\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Starting rebuilding table [dbo].[Items]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Items] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (50) NOT NULL,
    [Code]  INT           NOT NULL,
    [Brand] NVARCHAR (50) NOT NULL,
    [Price] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Items])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Items] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Items] ([Id], [Name], [Code], [Brand], [Price])
        SELECT   [Id],
                 [Name],
                 [Code],
                 [Brand],
                 [Price]
        FROM     [dbo].[Items]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Items] OFF;
    END

DROP TABLE [dbo].[Items];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Items]', N'Items';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Update complete.';


GO
