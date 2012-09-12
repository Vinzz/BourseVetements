



-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 09/12/2012 20:56:59
-- Generated from EDMX file: C:\Documents and Settings\Fanny\Mes documents\GitHub\BourseVetements\WebApp\DAO\BourseEntities.edmx
-- Target version: 2.0.0.0
-- --------------------------------------------------

DROP DATABASE IF EXISTS `bourse`;
CREATE DATABASE `bourse`;
USE `bourse`;

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

--    ALTER TABLE `ArticleSet` DROP CONSTRAINT `FK_ArticleList`;
--    ALTER TABLE `ListSet` DROP CONSTRAINT `FK_ListSeller`;

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `SellerSet`;
    DROP TABLE IF EXISTS `ArticleSet`;
    DROP TABLE IF EXISTS `ListSet`;
    DROP TABLE IF EXISTS `BrandsSet`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'SellerSet'

CREATE TABLE `SellerSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL,
    `City` longtext  NOT NULL,
    `Phone` longtext  NOT NULL,
    `Mail` longtext  NOT NULL
);

-- Creating table 'ArticleSet'

CREATE TABLE `ArticleSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Name` longtext  NOT NULL,
    `Details` longtext  NOT NULL,
    `Brand` longtext  NOT NULL,
    `Size` longtext  NOT NULL,
    `Price` double  NOT NULL,
    `isToy` bool  NOT NULL,
    `List_Id` int  NOT NULL
);

-- Creating table 'ListSet'

CREATE TABLE `ListSet` (
    `Id` int AUTO_INCREMENT PRIMARY KEY NOT NULL,
    `Creator` longtext  NOT NULL,
    `Remarks` longtext  NOT NULL,
    `Seller_Id` int  NOT NULL
);

-- Creating table 'BrandsSet'

CREATE TABLE `BrandsSet` (
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
    REFERENCES `ListSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticleList'

CREATE INDEX `IX_FK_ArticleList` 
    ON `ArticleSet`
    (`List_Id`);

-- Creating foreign key on `Seller_Id` in table 'ListSet'

ALTER TABLE `ListSet`
ADD CONSTRAINT `FK_ListSeller`
    FOREIGN KEY (`Seller_Id`)
    REFERENCES `SellerSet`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ListSeller'

CREATE INDEX `IX_FK_ListSeller` 
    ON `ListSet`
    (`Seller_Id`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
