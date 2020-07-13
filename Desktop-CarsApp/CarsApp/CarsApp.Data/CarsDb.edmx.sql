
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

IF OBJECT_ID(N'[dbo].[FK_CityCountry]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cities] DROP CONSTRAINT [FK_CityCountry];
GO
IF OBJECT_ID(N'[dbo].[FK_FactoryCity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Factories] DROP CONSTRAINT [FK_FactoryCity];
GO
IF OBJECT_ID(N'[dbo].[FK_CarProductCarModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProducts] DROP CONSTRAINT [FK_CarProductCarModel];
GO
IF OBJECT_ID(N'[dbo].[FK_CarProductFactory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProducts] DROP CONSTRAINT [FK_CarProductFactory];
GO
IF OBJECT_ID(N'[dbo].[FK_CarProductCarFeature_CarProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProductCarFeature] DROP CONSTRAINT [FK_CarProductCarFeature_CarProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_CarProductCarFeature_CarFeature]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarProductCarFeature] DROP CONSTRAINT [FK_CarProductCarFeature_CarFeature];
GO
IF OBJECT_ID(N'[dbo].[FK_CarFeatureCarModel_CarFeature]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarFeatureCarModel] DROP CONSTRAINT [FK_CarFeatureCarModel_CarFeature];
GO
IF OBJECT_ID(N'[dbo].[FK_CarFeatureCarModel_CarModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CarFeatureCarModel] DROP CONSTRAINT [FK_CarFeatureCarModel_CarModel];
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
ADD CONSTRAINT [FK_CityCountry]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CityCountry'
CREATE INDEX [IX_FK_CityCountry]
ON [dbo].[Cities]
    ([CountryId]);
GO

-- Creating foreign key on [CityId] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [FK_FactoryCity]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FactoryCity'
CREATE INDEX [IX_FK_FactoryCity]
ON [dbo].[Factories]
    ([CityId]);
GO

-- Creating foreign key on [CarModelId] in table 'CarProducts'
ALTER TABLE [dbo].[CarProducts]
ADD CONSTRAINT [FK_CarProductCarModel]
    FOREIGN KEY ([CarModelId])
    REFERENCES [dbo].[CarModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarProductCarModel'
CREATE INDEX [IX_FK_CarProductCarModel]
ON [dbo].[CarProducts]
    ([CarModelId]);
GO

-- Creating foreign key on [FactoryId] in table 'CarProducts'
ALTER TABLE [dbo].[CarProducts]
ADD CONSTRAINT [FK_CarProductFactory]
    FOREIGN KEY ([FactoryId])
    REFERENCES [dbo].[Factories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarProductFactory'
CREATE INDEX [IX_FK_CarProductFactory]
ON [dbo].[CarProducts]
    ([FactoryId]);
GO

-- Creating foreign key on [CarProducts_Id] in table 'CarProductCarFeature'
ALTER TABLE [dbo].[CarProductCarFeature]
ADD CONSTRAINT [FK_CarProductCarFeature_CarProduct]
    FOREIGN KEY ([CarProducts_Id])
    REFERENCES [dbo].[CarProducts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CarFeatures_Id] in table 'CarProductCarFeature'
ALTER TABLE [dbo].[CarProductCarFeature]
ADD CONSTRAINT [FK_CarProductCarFeature_CarFeature]
    FOREIGN KEY ([CarFeatures_Id])
    REFERENCES [dbo].[CarFeatures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarProductCarFeature_CarFeature'
CREATE INDEX [IX_FK_CarProductCarFeature_CarFeature]
ON [dbo].[CarProductCarFeature]
    ([CarFeatures_Id]);
GO

-- Creating foreign key on [CarFeatures_Id] in table 'CarFeatureCarModel'
ALTER TABLE [dbo].[CarFeatureCarModel]
ADD CONSTRAINT [FK_CarFeatureCarModel_CarFeature]
    FOREIGN KEY ([CarFeatures_Id])
    REFERENCES [dbo].[CarFeatures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CarModels_Id] in table 'CarFeatureCarModel'
ALTER TABLE [dbo].[CarFeatureCarModel]
ADD CONSTRAINT [FK_CarFeatureCarModel_CarModel]
    FOREIGN KEY ([CarModels_Id])
    REFERENCES [dbo].[CarModels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarFeatureCarModel_CarModel'
CREATE INDEX [IX_FK_CarFeatureCarModel_CarModel]
ON [dbo].[CarFeatureCarModel]
    ([CarModels_Id]);
GO

-- Creating foreign key on [CountryId] in table 'Manufactures'
ALTER TABLE [dbo].[Manufactures]
ADD CONSTRAINT [FK_ManufactureCountry]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufactureCountry'
CREATE INDEX [IX_FK_ManufactureCountry]
ON [dbo].[Manufactures]
    ([CountryId]);
GO

-- Creating foreign key on [ManufactureId] in table 'Factories'
ALTER TABLE [dbo].[Factories]
ADD CONSTRAINT [FK_FactoryManufacture]
    FOREIGN KEY ([ManufactureId])
    REFERENCES [dbo].[Manufactures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FactoryManufacture'
CREATE INDEX [IX_FK_FactoryManufacture]
ON [dbo].[Factories]
    ([ManufactureId]);
GO

-- Creating foreign key on [ManufactureId] in table 'CarModels'
ALTER TABLE [dbo].[CarModels]
ADD CONSTRAINT [FK_CarModelManufacture]
    FOREIGN KEY ([ManufactureId])
    REFERENCES [dbo].[Manufactures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CarModelManufacture'
CREATE INDEX [IX_FK_CarModelManufacture]
ON [dbo].[CarModels]
    ([ManufactureId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------