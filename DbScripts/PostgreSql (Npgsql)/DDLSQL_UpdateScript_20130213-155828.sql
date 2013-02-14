﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v3.5  Build: December 11th, 2012
-- PostgreSql 7.x/8.x/9.x DDL Script generated from project: Enio
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.Enio\Enio.llblgenproj
-- Script generated on: 13-vlj-2013 15:58.28
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

-- ###############################################################################################################
-- Rename statements
-- ###############################################################################################################

-- ###############################################################################################################
-- DROP statements for elements no longer needed or replaced elements.
-- ###############################################################################################################

ALTER TABLE "public"."RacunGlava" DROP CONSTRAINT "FK_12e16d34d84949c25167b213d97";

ALTER TABLE "public"."RacunGlava" DROP COLUMN "StatusId";

-- ###############################################################################################################
-- ADD statements for new elements (except FK/UC)
-- ###############################################################################################################

CREATE TABLE "public"."RacunGlavaStatusRo"
(
	"Code" varchar(50) NOT NULL, 
	"Name" varchar(100) NOT NULL, 
	"RacunGlavaStatusId" int8 NOT NULL 
);

ALTER TABLE "public"."RacunGlava" 
	ADD COLUMN "RacunGlavaStatusId" int8 NOT NULL;

-- ###############################################################################################################
-- ALTER statements for table fields and ADD statements for new primary key constraints
-- ###############################################################################################################

ALTER TABLE "public"."RacunGlavaStatusRo"
	ADD CONSTRAINT "PK_64117d745c083f83aae690400cd" PRIMARY KEY
	( 
		"RacunGlavaStatusId" 
	);

-- ###############################################################################################################
-- ADD statements for new foreign key constraints and unique constraints
-- ###############################################################################################################

ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_d5ed2b44707b14f748842cee9ba" FOREIGN KEY
	(
		"RacunGlavaStatusId" 
	)
	REFERENCES "public"."RacunGlavaStatusRo"
	(
		"RacunGlavaStatusId" 
	);
