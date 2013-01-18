///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.Enio.CoolJ.SqlServer.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((11 + 0));
			InitArtiklEntityMappings();
			InitBrojacEntityMappings();
			InitCjenikEntityMappings();
			InitConfigEntityMappings();
			InitKorisnikEntityMappings();
			InitPartnerEntityMappings();
			InitRacunGlavaEntityMappings();
			InitRacunStavkaEntityMappings();
			InitRoleRoEntityMappings();
			InitStatusRoEntityMappings();
			InitTarifaEntityMappings();

		}


		/// <summary>Inits ArtiklEntity's mappings</summary>
		private void InitArtiklEntityMappings()
		{
			this.AddElementMapping( "ArtiklEntity", @"Enio", @"dbo", "Artikl", 6 );
			this.AddElementFieldMapping( "ArtiklEntity", "ArtiklId", "ArtiklId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "ArtiklEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ArtiklEntity", "Jm", "Jm", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ArtiklEntity", "Naziv", "Naziv", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ArtiklEntity", "Pdv", "Pdv", false, "Decimal", 0, 2, 4, false, "", null, typeof(System.Decimal), 4 );
			this.AddElementFieldMapping( "ArtiklEntity", "StatusId", "StatusId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 5 );
		}
		/// <summary>Inits BrojacEntity's mappings</summary>
		private void InitBrojacEntityMappings()
		{
			this.AddElementMapping( "BrojacEntity", @"Enio", @"dbo", "Brojac", 5 );
			this.AddElementFieldMapping( "BrojacEntity", "BrojacId", "BrojacId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "BrojacEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "BrojacEntity", "Godina", "Godina", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "BrojacEntity", "Naziv", "Naziv", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "BrojacEntity", "SlijedeciBroj", "SlijedeciBroj", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 4 );
		}
		/// <summary>Inits CjenikEntity's mappings</summary>
		private void InitCjenikEntityMappings()
		{
			this.AddElementMapping( "CjenikEntity", @"Enio", @"dbo", "Cjenik", 5 );
			this.AddElementFieldMapping( "CjenikEntity", "ArtiklId", "ArtiklId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "CjenikEntity", "Cijena", "Cijena", false, "Decimal", 0, 4, 10, false, "", null, typeof(System.Decimal), 1 );
			this.AddElementFieldMapping( "CjenikEntity", "CjenikId", "CjenikId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "CjenikEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CjenikEntity", "PartnerId", "PartnerId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
		}
		/// <summary>Inits ConfigEntity's mappings</summary>
		private void InitConfigEntityMappings()
		{
			this.AddElementMapping( "ConfigEntity", @"Enio", @"dbo", "Config", 7 );
			this.AddElementFieldMapping( "ConfigEntity", "Adresa", "Adresa", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ConfigEntity", "AktivnaGodina", "AktivnaGodina", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 1 );
			this.AddElementFieldMapping( "ConfigEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ConfigEntity", "Mjesto", "Mjesto", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ConfigEntity", "Naziv", "Naziv", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ConfigEntity", "Oib", "Oib", false, "NVarChar", 11, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "ConfigEntity", "Zr", "Zr", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 6 );
		}
		/// <summary>Inits KorisnikEntity's mappings</summary>
		private void InitKorisnikEntityMappings()
		{
			this.AddElementMapping( "KorisnikEntity", @"Enio", @"dbo", "Korisnik", 5 );
			this.AddElementFieldMapping( "KorisnikEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "KorisnikEntity", "KorisnikId", "KorisnikId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "KorisnikEntity", "Password", "Password", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "KorisnikEntity", "RoleId", "RoleId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "KorisnikEntity", "Username", "Username", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits PartnerEntity's mappings</summary>
		private void InitPartnerEntityMappings()
		{
			this.AddElementMapping( "PartnerEntity", @"Enio", @"dbo", "Partner", 9 );
			this.AddElementFieldMapping( "PartnerEntity", "Adresa", "Adresa", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "PartnerEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "PartnerEntity", "Mjesto", "Mjesto", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "PartnerEntity", "Naziv", "Naziv", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PartnerEntity", "Oib", "Oib", false, "NVarChar", 11, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "PartnerEntity", "PartnerId", "PartnerId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "PartnerEntity", "Posta", "Posta", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "PartnerEntity", "StatusId", "StatusId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 7 );
			this.AddElementFieldMapping( "PartnerEntity", "Valuta", "Valuta", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
		}
		/// <summary>Inits RacunGlavaEntity's mappings</summary>
		private void InitRacunGlavaEntityMappings()
		{
			this.AddElementMapping( "RacunGlavaEntity", @"Enio", @"dbo", "RacunGlava", 11 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "Datum", "Datum", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "Godina", "Godina", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 2 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "MjestoRadaAdresa", "MjestoRadaAdresa", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "MjestoRadaNaziv", "MjestoRadaNaziv", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "PartnerId", "PartnerId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 5 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "RacunGlavaId", "RacunGlavaId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 6 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "StatusId", "StatusId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 7 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "TarifaId", "TarifaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 8 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "TarifaStopa", "TarifaStopa", false, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 9 );
			this.AddElementFieldMapping( "RacunGlavaEntity", "Valuta", "Valuta", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 10 );
		}
		/// <summary>Inits RacunStavkaEntity's mappings</summary>
		private void InitRacunStavkaEntityMappings()
		{
			this.AddElementMapping( "RacunStavkaEntity", @"Enio", @"dbo", "RacunStavka", 11 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "ArtiklId", "ArtiklId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "Cijena", "Cijena", false, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 1 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "Iznos", "Iznos", false, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 3 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "Kolicina", "Kolicina", false, "Decimal", 0, 2, 8, false, "", null, typeof(System.Decimal), 4 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "PdvIznos", "PdvIznos", false, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 5 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "PdvPosto", "PdvPosto", false, "Decimal", 0, 2, 4, false, "", null, typeof(System.Decimal), 6 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "Pozicija", "Pozicija", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 7 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "RacunGlavaId", "RacunGlavaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 8 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "RacunStavkaId", "RacunStavkaId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 9 );
			this.AddElementFieldMapping( "RacunStavkaEntity", "TarifaIznos", "TarifaIznos", false, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 10 );
		}
		/// <summary>Inits RoleRoEntity's mappings</summary>
		private void InitRoleRoEntityMappings()
		{
			this.AddElementMapping( "RoleRoEntity", @"Enio", @"dbo", "RoleRo", 3 );
			this.AddElementFieldMapping( "RoleRoEntity", "Code", "Code", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RoleRoEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "RoleRoEntity", "RoleId", "RoleId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 2 );
		}
		/// <summary>Inits StatusRoEntity's mappings</summary>
		private void InitStatusRoEntityMappings()
		{
			this.AddElementMapping( "StatusRoEntity", @"Enio", @"dbo", "StatusRo", 3 );
			this.AddElementFieldMapping( "StatusRoEntity", "Code", "Code", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "StatusRoEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "StatusRoEntity", "StatusId", "StatusId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 2 );
		}
		/// <summary>Inits TarifaEntity's mappings</summary>
		private void InitTarifaEntityMappings()
		{
			this.AddElementMapping( "TarifaEntity", @"Enio", @"dbo", "Tarifa", 5 );
			this.AddElementFieldMapping( "TarifaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "TarifaEntity", "Naziv", "Naziv", false, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TarifaEntity", "StatusId", "StatusId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "TarifaEntity", "Stopa", "Stopa", false, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 3 );
			this.AddElementFieldMapping( "TarifaEntity", "TarifaId", "TarifaId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 4 );
		}

	}
}