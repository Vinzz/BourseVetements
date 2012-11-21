



-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 11/21/2012 23:22:30
-- Generated from EDMX file: C:\Documents and Settings\Fanny\Mes documents\GitHub\BourseVetements\WebApp\DAO\Entities\BourseEntities.edmx
-- Target version: 2.0.0.0
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

--    ALTER TABLE `ArticleSet` DROP CONSTRAINT `FK_ArticleList`;
--    ALTER TABLE `Sell_ListSet` DROP CONSTRAINT `FK_ListSeller`;

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `SellerSet`;
    DROP TABLE IF EXISTS `ArticleSet`;
    DROP TABLE IF EXISTS `Sell_ListSet`;
    DROP TABLE IF EXISTS `BrandsSet`;
    DROP TABLE IF EXISTS `ArticlesSet`;
    DROP TABLE IF EXISTS `DetailsSet`;
    DROP TABLE IF EXISTS `SizesSet`;
    DROP TABLE IF EXISTS `PricesSet`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SellerSet'

CREATE TABLE `SellerSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL,
    `City` longtext  NULL,
    `Phone` longtext  NULL,
    `Mail` longtext  NULL
);

-- Creating table 'ArticleSet'

CREATE TABLE `ArticleSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL,
    `Details` longtext  NULL,
    `Brand` longtext  NULL,
    `Size` longtext  NULL,
    `Price` double  NOT NULL,
    `isToy` bool  NOT NULL,
    `List_Id` int  NOT NULL
);

-- Creating table 'Sell_ListSet'

CREATE TABLE `Sell_ListSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Creator` longtext  NOT NULL,
    `Remarks` longtext  NOT NULL,
    `NumberClothes` int  NOT NULL,
    `NumberToys` int  NOT NULL,
    `Seller_Id` int  NOT NULL
);

-- Creating table 'BrandsSet'

CREATE TABLE `BrandsSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL
);

-- Creating table 'ArticlesSet'

CREATE TABLE `ArticlesSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL
);

-- Creating table 'DetailsSet'

CREATE TABLE `DetailsSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL
);

-- Creating table 'SizesSet'

CREATE TABLE `SizesSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL
);

-- Creating table 'PricesSet'

CREATE TABLE `PricesSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL
);



-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------



-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `List_Id` in table 'ArticleSet'

ALTER TABLE `ArticleSet`
ADD CONSTRAINT `FK_ArticleList`
    FOREIGN KEY (`List_Id`)
    REFERENCES `Sell_ListSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticleList'

CREATE INDEX `IX_FK_ArticleList` 
    ON `ArticleSet`
    (`List_Id`);

-- Creating foreign key on `Seller_Id` in table 'Sell_ListSet'

ALTER TABLE `Sell_ListSet`
ADD CONSTRAINT `FK_ListSeller`
    FOREIGN KEY (`Seller_Id`)
    REFERENCES `SellerSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ListSeller'

CREATE INDEX `IX_FK_ListSeller` 
    ON `Sell_ListSet`
    (`Seller_Id`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
