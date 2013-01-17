﻿
-- ----------------------------------------------------------------------------------------------------------------
-- Generated by LLBLGen Pro v3.5  Build: December 11th, 2012
-- PostgreSql 7.x/8.x/9.x DDL Script generated from project: Enio
-- Project filename: G:\Documents\Visual Studio 2010\Projects\NinjaSoftware.Enio\Enio.llblgenproj
-- Script generated on: 17-sij-2013 16:47.14
--
-- This is a Create script for creating a NEW data model. If you want DDL SQL for updating an existing model,
-- please create an Update script instead. 
--
-- This script might create schemas, which requires you to assign a proper user to the schema. Adjust the CREATE SCHEMA
-- statements below, if any, to avoid errors at runtime. Schemas aren't dropped in the DROP section.
--
--      >>>>> WARNING <<<<<
--      This is a CREATE script, with DROP statements for the existing tables, foreign keys and other constraints
--      This means that existing tables, data, constraints and other elements in the catalog/schemas addressed
--      are deleted. Use this Create script only to create new schemas with tables/constraints and other elements.
--
-- ----------------------------------------------------------------------------------------------------------------
-- ###############################################################################################################
-- DROP statements for existing elements. 
-- ###############################################################################################################
-- DROP statements for dropping existing elements with the same names as the ones created are commented out below. 
-- If you want to enable these statements for DROPping the existing elements first (which will remove all the data
-- in these existing elements), uncomment these statements by removing the two comment markers /* and */

-- Remove the comment marker on the NEXT line to enable DROP statements to remove existing elements
/* 
-- ----------------------------------------------------------------------------------------------------------------
-- DROP tables for schema 'public' 
-- ----------------------------------------------------------------------------------------------------------------

DROP TABLE "public"."Artikl";

DROP TABLE "public"."Brojac";

DROP TABLE "public"."Cjenik";

DROP TABLE "public"."Config";

DROP TABLE "public"."Korisnik";

DROP TABLE "public"."Partner";

DROP TABLE "public"."RacunGlava";

DROP TABLE "public"."RacunStavka";

DROP TABLE "public"."RoleRo";

DROP TABLE "public"."StatusRo";

DROP TABLE "public"."Tarifa";
-- ----------------------------------------------------------------------------------------------------------------
-- DROP sequences for schema 'public'
-- ----------------------------------------------------------------------------------------------------------------

DROP SEQUENCE "public"."GenericSequence";
*/
-- Remove the comment marker on the PREVIOUS line to enable DROP statements to remove existing elements

-- ###############################################################################################################
-- Create statements for catalogs, schemas, tables and sequences
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'Default'
-- ----------------------------------------------------------------------------------------------------------------

-- ----------------------------------------------------------------------------------------------------------------
-- Schema 'public'
-- ----------------------------------------------------------------------------------------------------------------
CREATE SCHEMA "public" /* AUTHORIZATION username */ ;

-- -------[ Tables ]-----------------------------------------------------------------------------------------------

CREATE TABLE "public"."Artikl"
(
	"ArtiklId" int8 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Jm" varchar(10) NOT NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"Pdv" numeric(4, 2) NOT NULL, 
	"StatusId" int8 NOT NULL 
);

CREATE TABLE "public"."Brojac"
(
	"BrojacId" int8 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Godina" int2 NOT NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"SlijedeciBroj" int4 NOT NULL 
);

CREATE TABLE "public"."Cjenik"
(
	"ArtiklId" int8 NOT NULL, 
	"Cijena" numeric(10, 4) NOT NULL, 
	"CjenikId" int8 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"PartnerId" int8 NOT NULL 
);

CREATE TABLE "public"."Config"
(
	"Adresa" varchar(100) NULL, 
	"AktivnaGodina" int2 NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Mjesto" varchar(100) NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"Oib" varchar(11) NOT NULL, 
	"Zr" varchar(50) NULL 
);

CREATE TABLE "public"."Korisnik"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"KorisnikId" int8 NOT NULL, 
	"Password" varchar(50) NOT NULL, 
	"Username" varchar(20) NOT NULL, 
	"RoleId" int8 NOT NULL 
);

CREATE TABLE "public"."Partner"
(
	"Adresa" varchar(100) NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Mjesto" varchar(20) NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"Oib" varchar(11) NOT NULL, 
	"PartnerId" int8 NOT NULL, 
	"Posta" varchar(10) NULL, 
	"StatusId" int8 NOT NULL, 
	"Valuta" int2 NOT NULL 
);

CREATE TABLE "public"."RacunGlava"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Datum" date NOT NULL, 
	"Godina" int2 NOT NULL, 
	"MjestoRadaAdresa" varchar(100) NULL, 
	"MjestoRadaNaziv" varchar(100) NULL, 
	"PartnerId" int8 NOT NULL, 
	"RacunGlavaId" int8 NOT NULL, 
	"StatusId" int8 NOT NULL, 
	"TarifaId" int8 NOT NULL, 
	"TarifaStopa" numeric(5, 2) NOT NULL, 
	"Valuta" int2 NOT NULL 
);

CREATE TABLE "public"."RacunStavka"
(
	"ArtiklId" int8 NOT NULL, 
	"Cijena" numeric(10, 2) NOT NULL, 
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Iznos" numeric(10, 2) NOT NULL, 
	"Kolicina" numeric(8, 2) NOT NULL, 
	"PdvIznos" numeric(10, 2) NOT NULL, 
	"PdvPosto" numeric(4, 2) NOT NULL, 
	"Pozicija" int2 NOT NULL, 
	"RacunGlavaId" int8 NOT NULL, 
	"RacunStavkaId" int8 NOT NULL, 
	"TarifaIznos" numeric(10, 2) NOT NULL 
);

CREATE TABLE "public"."RoleRo"
(
	"Code" varchar(50) NOT NULL, 
	"Name" varchar(50) NOT NULL, 
	"RoleId" int8 NOT NULL 
);

CREATE TABLE "public"."StatusRo"
(
	"Code" varchar(50) NOT NULL, 
	"Name" varchar(50) NOT NULL, 
	"StatusId" int8 NOT NULL 
);

CREATE TABLE "public"."Tarifa"
(
	"ConcurrencyGuid" varchar(50) NOT NULL, 
	"Naziv" varchar(100) NOT NULL, 
	"StatusId" int8 NOT NULL, 
	"Stopa" numeric(5, 2) NOT NULL, 
	"TarifaId" int8 NOT NULL 
);
-- -------[ Sequences ]--------------------------------------------------------------------------------------------

CREATE SEQUENCE "public"."GenericSequence" INCREMENT BY 1 NO MAXVALUE START WITH 1 NO CYCLE;

-- ###############################################################################################################
-- Create statements for Primary key constraints, Foreign key constraints and Unique constraints
-- ###############################################################################################################
-- ----------------------------------------------------------------------------------------------------------------
-- Catalog 'Default'
-- ----------------------------------------------------------------------------------------------------------------
-- ----------------------------------------------------------------------------------------------------------------
-- Primary Key constraints for schema 'public'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE "public"."Artikl"
	ADD CONSTRAINT "PK_8936853496aa7bc23377b00435f" PRIMARY KEY
	( 
		"ArtiklId" 
	);

ALTER TABLE "public"."Brojac"
	ADD CONSTRAINT "PK_35b0167480796dc7e7f871d25c8" PRIMARY KEY
	( 
		"BrojacId" 
	);

ALTER TABLE "public"."Cjenik"
	ADD CONSTRAINT "PK_19f7ec84559b62994314500461f" PRIMARY KEY
	( 
		"CjenikId" 
	);

ALTER TABLE "public"."Config"
	ADD CONSTRAINT "PK_af1b54743b1a8475f9e3f8a2642" PRIMARY KEY
	( 
		"Oib" 
	);

ALTER TABLE "public"."Korisnik"
	ADD CONSTRAINT "PK_f232d1c4e00ad36363f6b81c847" PRIMARY KEY
	( 
		"KorisnikId" 
	);

ALTER TABLE "public"."Partner"
	ADD CONSTRAINT "PK_ec363ca41a09a25ebb6c0283629" PRIMARY KEY
	( 
		"PartnerId" 
	);

ALTER TABLE "public"."RacunGlava"
	ADD CONSTRAINT "PK_2ace6ec4137803379b7e704c868" PRIMARY KEY
	( 
		"RacunGlavaId" 
	);

ALTER TABLE "public"."RacunStavka"
	ADD CONSTRAINT "PK_eea0bcd456c9a21f143257b7cdb" PRIMARY KEY
	( 
		"RacunStavkaId" 
	);

ALTER TABLE "public"."RoleRo"
	ADD CONSTRAINT "PK_eb5df4740fda93e603b4a609eef" PRIMARY KEY
	( 
		"RoleId" 
	);

ALTER TABLE "public"."StatusRo"
	ADD CONSTRAINT "PK_c966b344206835938ce0e1a22cb" PRIMARY KEY
	( 
		"StatusId" 
	);

ALTER TABLE "public"."Tarifa"
	ADD CONSTRAINT "PK_a89a7a34ced81027e34dae234e2" PRIMARY KEY
	( 
		"TarifaId" 
	);
-- ----------------------------------------------------------------------------------------------------------------
-- Unique constraints for schema 'public'
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE "public"."Cjenik" 
	ADD CONSTRAINT "UC_39d17614e3e9be4f4b04b4e8ede" UNIQUE
	(
		"PartnerId", "ArtiklId" 
	);

-- ----------------------------------------------------------------------------------------------------------------
-- All foreign Key constraints
-- ----------------------------------------------------------------------------------------------------------------

ALTER TABLE "public"."Artikl" 
	ADD CONSTRAINT "FK_268540648c29018a1a754786844" FOREIGN KEY
	(
		"StatusId" 
	)
	REFERENCES "public"."StatusRo"
	(
		"StatusId" 
	);

ALTER TABLE "public"."Cjenik" 
	ADD CONSTRAINT "FK_1556ecf466881bc95e2b77cbbc7" FOREIGN KEY
	(
		"ArtiklId" 
	)
	REFERENCES "public"."Artikl"
	(
		"ArtiklId" 
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

ALTER TABLE "public"."Korisnik" 
	ADD CONSTRAINT "FK_15df8b8464f933e1f3cce430182" FOREIGN KEY
	(
		"RoleId" 
	)
	REFERENCES "public"."RoleRo"
	(
		"RoleId" 
	);

ALTER TABLE "public"."Partner" 
	ADD CONSTRAINT "FK_e32220d43c2845753ff91e7e105" FOREIGN KEY
	(
		"StatusId" 
	)
	REFERENCES "public"."StatusRo"
	(
		"StatusId" 
	);

ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_12e16d34d84949c25167b213d97" FOREIGN KEY
	(
		"StatusId" 
	)
	REFERENCES "public"."StatusRo"
	(
		"StatusId" 
	);

ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_432e8c241f98aed846b19115ec5" FOREIGN KEY
	(
		"PartnerId" 
	)
	REFERENCES "public"."Partner"
	(
		"PartnerId" 
	);

ALTER TABLE "public"."RacunGlava" 
	ADD CONSTRAINT "FK_de4ccaf4171b10223250058c83a" FOREIGN KEY
	(
		"TarifaId" 
	)
	REFERENCES "public"."Tarifa"
	(
		"TarifaId" 
	);

ALTER TABLE "public"."RacunStavka" 
	ADD CONSTRAINT "FK_0f87aab433f919d541b07458fb6" FOREIGN KEY
	(
		"ArtiklId" 
	)
	REFERENCES "public"."Artikl"
	(
		"ArtiklId" 
	);

ALTER TABLE "public"."RacunStavka" 
	ADD CONSTRAINT "FK_494c7c54bbc8faa69f07c2ed698" FOREIGN KEY
	(
		"RacunGlavaId" 
	)
	REFERENCES "public"."RacunGlava"
	(
		"RacunGlavaId" 
	);