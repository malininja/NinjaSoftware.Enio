﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v3.5  Build: December 11th, 2012
-- SQL Server 2000/2005/2008/2008R2/2012/Express DDL Script generated from project: Enio
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.Enio\Enio.llblgenproj
-- Script generated on: 13-vlj-2013 16:02.33
--
-- This is an Update script for updating an existing data model to a newer version. If you want DDL SQL for a new model,
-- please create a Create script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime.
--
-- Please run the scripts in the right order, use the timestamp in the filename and inside this script for that.
-- This script might need adjustment in some statements. You should consider this script as a starting point for
-- upgrading the existing data model.
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- Drop constraints referring to elements which are changed in this script (constraints are recreated later on)
-- ###############################################################################################################

USE [Enio]
GO

-- ###############################################################################################################
-- Rename statements
-- ###############################################################################################################

USE [Enio]
GO

-- ###############################################################################################################
-- DROP statements for elements no longer needed or replaced elements.
-- ###############################################################################################################

USE [Enio]
GO

ALTER TABLE [dbo].[RacunGlava] DROP CONSTRAINT [FK_256837c43f1b0e24c0f679ffa96]
GO

ALTER TABLE [dbo].[RacunGlava] DROP COLUMN [RacunGlavaStatusId]
GO

DROP TABLE [dbo].[RacunGlavaStatusRo]
GO

-- ###############################################################################################################
-- ADD statements for new elements (except FK/UC)
-- ###############################################################################################################

USE [Enio]
GO

ALTER TABLE [dbo].[RacunGlava] 
	ADD [StatusId] [bigint] NOT NULL
GO

-- ###############################################################################################################
-- ALTER statements for table fields and ADD statements for new primary key constraints
-- ###############################################################################################################

USE [Enio]
GO

-- ###############################################################################################################
-- ADD statements for new foreign key constraints and unique constraints
-- ###############################################################################################################

USE [Enio]
GO

ALTER TABLE [dbo].[RacunGlava] 
	ADD CONSTRAINT [FK_934c51f42758de9ac3b0686d460] FOREIGN KEY
	(
		[StatusId] 
	)
	REFERENCES [dbo].[StatusRo]
	(
		[StatusId] 
	)
GO

