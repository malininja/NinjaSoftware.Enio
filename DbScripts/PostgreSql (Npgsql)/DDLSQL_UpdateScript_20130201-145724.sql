﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v3.5  Build: December 11th, 2012
-- PostgreSql 7.x/8.x/9.x DDL Script generated from project: Enio
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.Enio\Enio.llblgenproj
-- Script generated on: 01-vlj-2013 14:57.25
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

ALTER TABLE "public"."Cjenik" DROP CONSTRAINT "FK_d18803841fba0377240280bf196";

ALTER TABLE "public"."Cjenik" DROP CONSTRAINT "UC_39d17614e3e9be4f4b04b4e8ede";

-- ###############################################################################################################
-- Rename statements
-- ###############################################################################################################

-- ###############################################################################################################
-- DROP statements for elements no longer needed or replaced elements.
-- ###############################################################################################################

-- ###############################################################################################################
-- ADD statements for new elements (except FK/UC)
-- ###############################################################################################################

-- ###############################################################################################################
-- ALTER statements for table fields and ADD statements for new primary key constraints
-- ###############################################################################################################
ALTER TABLE "public"."Cjenik" 
	ALTER COLUMN "PartnerId" SET drop NULL;


-- ###############################################################################################################
-- ADD statements for new foreign key constraints and unique constraints
-- ###############################################################################################################

ALTER TABLE "public"."Cjenik" 
	ADD CONSTRAINT "UC_39d17614e3e9be4f4b04b4e8ede" UNIQUE
	(
		"ArtiklId", "PartnerId" 
	);


ALTER TABLE "public"."Cjenik" 
	ADD CONSTRAINT "FK_d18803841fba0377240280bf196" FOREIGN KEY
	(
		"PartnerId" 
	)
	REFERENCES "public"."Partner"
	(
		"PartnerId" 
	);

