
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/07/2014 10:26:55
-- Generated from EDMX file: D:\LGBS\WarsztatyWiedeń\CarsApp\CarsApp.Data\CarsDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarsDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CityCountry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cities] DROP CONSTRAINT [CityCountry];
GO
IF OBJECT_ID(N'[dbo].[FactoryCity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Factories] DROP CONSTRAINT [FactoryCity];
GO
IF OBJECT_ID(N'[dbo].[CarProductCarModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProducts] DROP CONSTRAINT [CarProductCarModel];
GO
IF OBJECT_ID(N'[dbo].[CarProductFactory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProducts] DROP CONSTRAINT [CarProductFactory];
GO
IF OBJECT_ID(N'[dbo].[CarProductCarFeature_CarProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProductCarFeature] DROP CONSTRAINT [CarProductCarFeature_CarProduct];
GO
IF OBJECT_ID(N'[dbo].[CarProductCarFeature_CarFeature]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProductCarFeature] DROP CONSTRAINT [CarProductCarFeature_CarFeature];
GO
IF OBJECT_ID(N'[dbo].[CarFeatureCarModel_CarFeature]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarFeatureCarModel] DROP CONSTRAINT [CarFeatureCarModel_CarFeature];
GO
IF OBJECT_ID(N'[dbo].[CarFeatureCarModel_CarModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarFeatureCarModel] DROP CONSTRAINT [CarFeatureCarModel_CarModel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Factories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Factories];
GO
IF OBJECT_ID(N'[dbo].[CarModels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarModels];
GO
IF OBJECT_ID(N'[dbo].[CarProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarProducts];
GO
IF OBJECT_ID(N'[dbo].[CarFeatures]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarFeatures];
GO
IF OBJECT_ID(N'[dbo].[CarProductCarFeature]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarProductCarFeature];
GO
IF OBJECT_ID(N'[dbo].[CarFeatureCarModel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CarFeatureCarModel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Code] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [CountryId] bigint  NOT NULL
);
GO

-- Creating table 'Factories'
CREATE TABLE [dbo].[Factories] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [CityId] bigint  NOT NULL,
    [ManufactureId] bigint  NOT NULL
);
GO

-- Creating table 'CarModels'
CREATE TABLE [dbo].[CarModels] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [ManufactureId] bigint  NOT NULL
);
GO

-- Creating table 'CarProducts'
CREATE TABLE [dbo].[CarProducts] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Year] smallint  NOT NULL,
    [VIN] nvarchar(255)  NOT NULL,
    [CarModelId] bigint  NOT NULL,
    [FactoryId] bigint  NOT NULL
);
GO

-- Creating table 'CarFeatures'
CREATE TABLE [dbo].[CarFeatures] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(3)  NOT NULL,
    [Name] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'Manufactures'
CREATE TABLE [dbo].[Manufactures] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [CountryId] bigint  NOT NULL
);
GO

-- Creating table 'CarProductCarFeature'
CREATE TABLE [dbo].[CarProductCarFeature] (
    [CarProducts_Id] bigint  NOT NULL,
    [CarFeatures_Id] bigint  NOT NULL
);
GO

-- Creating table 'CarFeatureCarModel'
CREATE TABLE [dbo].[CarFeatureCarModel] (
    [CarFeatures_Id] bigint  NOT NULL,
    [CarModels_Id] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [PK_Factories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarModels'
ALTER TABLE [dbo].[CarModels]
ADD CONSTRAINT [PK_CarModels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarProducts'
ALTER TABLE [dbo].[CarProducts]
ADD CONSTRAINT [PK_CarProducts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CarFeatures'
ALTER TABLE [dbo].[CarFeatures]
ADD CONSTRAINT [PK_CarFeatures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Manufactures'
ALTER TABLE [dbo].[Manufactures]
ADD CONSTRAINT [PK_Manufactures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [CarProducts_Id], [CarFeatures_Id] in table 'CarProductCarFeature'
ALTER TABLE [dbo].[CarProductCarFeature]
ADD CONSTRAINT [PK_CarProductCarFeature]
    PRIMARY KEY NONCLUSTERED ([CarProducts_Id], [CarFeatures_Id] ASC);
GO

-- Creating primary key on [CarFeatures_Id], [CarModels_Id] in table 'CarFeatureCarModel'
ALTER TABLE [dbo].[CarFeatureCarModel]
ADD CONSTRAINT [PK_CarFeatureCarModel]
    PRIMARY KEY NONCLUSTERED ([CarFeatures_Id], [CarModels_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CountryId] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [CityCountry]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'CityCountry'
CREATE INDEX [IX_CityCountry]
ON [dbo].[Cities]
    ([CountryId]);
GO

-- Creating foreign key on [CityId] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [FactoryCity]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FactoryCity'
CREATE INDEX [IX_FactoryCity]
ON [dbo].[Factories]
    ([CityId]);
GO

-- Creating foreign key on [CarModelId] in table 'CarProducts'
ALTER TABLE [dbo].[CarProducts]
ADD CONSTRAINT [CarProductCarModel]
    FOREIGN KEY ([CarModelId])
    REFERENCES [dbo].[CarModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'CarProductCarModel'
CREATE INDEX [IX_CarProductCarModel]
ON [dbo].[CarProducts]
    ([CarModelId]);
GO

-- Creating foreign key on [FactoryId] in table 'CarProducts'
ALTER TABLE [dbo].[CarProducts]
ADD CONSTRAINT [CarProductFactory]
    FOREIGN KEY ([FactoryId])
    REFERENCES [dbo].[Factories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'CarProductFactory'
CREATE INDEX [IX_CarProductFactory]
ON [dbo].[CarProducts]
    ([FactoryId]);
GO

-- Creating foreign key on [CarProducts_Id] in table 'CarProductCarFeature'
ALTER TABLE [dbo].[CarProductCarFeature]
ADD CONSTRAINT [CarProductCarFeature_CarProduct]
    FOREIGN KEY ([CarProducts_Id])
    REFERENCES [dbo].[CarProducts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CarFeatures_Id] in table 'CarProductCarFeature'
ALTER TABLE [dbo].[CarProductCarFeature]
ADD CONSTRAINT [CarProductCarFeature_CarFeature]
    FOREIGN KEY ([CarFeatures_Id])
    REFERENCES [dbo].[CarFeatures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'CarProductCarFeature_CarFeature'
CREATE INDEX [IX_CarProductCarFeature_CarFeature]
ON [dbo].[CarProductCarFeature]
    ([CarFeatures_Id]);
GO

-- Creating foreign key on [CarFeatures_Id] in table 'CarFeatureCarModel'
ALTER TABLE [dbo].[CarFeatureCarModel]
ADD CONSTRAINT [CarFeatureCarModel_CarFeature]
    FOREIGN KEY ([CarFeatures_Id])
    REFERENCES [dbo].[CarFeatures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CarModels_Id] in table 'CarFeatureCarModel'
ALTER TABLE [dbo].[CarFeatureCarModel]
ADD CONSTRAINT [CarFeatureCarModel_CarModel]
    FOREIGN KEY ([CarModels_Id])
    REFERENCES [dbo].[CarModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'CarFeatureCarModel_CarModel'
CREATE INDEX [IX_CarFeatureCarModel_CarModel]
ON [dbo].[CarFeatureCarModel]
    ([CarModels_Id]);
GO

-- Creating foreign key on [CountryId] in table 'Manufactures'
ALTER TABLE [dbo].[Manufactures]
ADD CONSTRAINT [ManufactureCountry]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'ManufactureCountry'
CREATE INDEX [IX_ManufactureCountry]
ON [dbo].[Manufactures]
    ([CountryId]);
GO

-- Creating foreign key on [ManufactureId] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [FactoryManufacture]
    FOREIGN KEY ([ManufactureId])
    REFERENCES [dbo].[Manufactures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FactoryManufacture'
CREATE INDEX [IX_FactoryManufacture]
ON [dbo].[Factories]
    ([ManufactureId]);
GO

-- Creating foreign key on [ManufactureId] in table 'CarModels'
ALTER TABLE [dbo].[CarModels]
ADD CONSTRAINT [CarModelManufacture]
    FOREIGN KEY ([ManufactureId])
    REFERENCES [dbo].[Manufactures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'CarModelManufacture'
CREATE INDEX [IX_CarModelManufacture]
ON [dbo].[CarModels]
    ([ManufactureId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------