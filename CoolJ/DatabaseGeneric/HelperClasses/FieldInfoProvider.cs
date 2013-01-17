///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 17. siječanj 2013. 16:50:11
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.Enio.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (11 + 0));
			InitArtiklEntityInfos();
			InitBrojacEntityInfos();
			InitCjenikEntityInfos();
			InitConfigEntityInfos();
			InitKorisnikEntityInfos();
			InitPartnerEntityInfos();
			InitRacunGlavaEntityInfos();
			InitRacunStavkaEntityInfos();
			InitRoleRoEntityInfos();
			InitStatusRoEntityInfos();
			InitTarifaEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits ArtiklEntity's FieldInfo objects</summary>
		private void InitArtiklEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ArtiklFieldIndex), "ArtiklEntity");
			this.AddElementFieldInfo("ArtiklEntity", "ArtiklId", typeof(System.Int64), true, false, false, false,  (int)ArtiklFieldIndex.ArtiklId, 0, 0, 19);
			this.AddElementFieldInfo("ArtiklEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)ArtiklFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "Jm", typeof(System.String), false, false, false, false,  (int)ArtiklFieldIndex.Jm, 10, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)ArtiklFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("ArtiklEntity", "Pdv", typeof(System.Decimal), false, false, false, false,  (int)ArtiklFieldIndex.Pdv, 0, 2, 4);
			this.AddElementFieldInfo("ArtiklEntity", "StatusId", typeof(System.Int64), false, true, false, false,  (int)ArtiklFieldIndex.StatusId, 0, 0, 19);
		}
		/// <summary>Inits BrojacEntity's FieldInfo objects</summary>
		private void InitBrojacEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BrojacFieldIndex), "BrojacEntity");
			this.AddElementFieldInfo("BrojacEntity", "BrojacId", typeof(System.Int64), true, false, false, false,  (int)BrojacFieldIndex.BrojacId, 0, 0, 19);
			this.AddElementFieldInfo("BrojacEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)BrojacFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("BrojacEntity", "Godina", typeof(System.Int16), false, false, false, false,  (int)BrojacFieldIndex.Godina, 0, 0, 0);
			this.AddElementFieldInfo("BrojacEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)BrojacFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("BrojacEntity", "SlijedeciBroj", typeof(System.Int32), false, false, false, false,  (int)BrojacFieldIndex.SlijedeciBroj, 0, 0, 0);
		}
		/// <summary>Inits CjenikEntity's FieldInfo objects</summary>
		private void InitCjenikEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CjenikFieldIndex), "CjenikEntity");
			this.AddElementFieldInfo("CjenikEntity", "ArtiklId", typeof(System.Int64), false, true, false, false,  (int)CjenikFieldIndex.ArtiklId, 0, 0, 19);
			this.AddElementFieldInfo("CjenikEntity", "Cijena", typeof(System.Decimal), false, false, false, false,  (int)CjenikFieldIndex.Cijena, 0, 4, 10);
			this.AddElementFieldInfo("CjenikEntity", "CjenikId", typeof(System.Int64), true, false, false, false,  (int)CjenikFieldIndex.CjenikId, 0, 0, 19);
			this.AddElementFieldInfo("CjenikEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)CjenikFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("CjenikEntity", "PartnerId", typeof(System.Int64), false, true, false, false,  (int)CjenikFieldIndex.PartnerId, 0, 0, 19);
		}
		/// <summary>Inits ConfigEntity's FieldInfo objects</summary>
		private void InitConfigEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ConfigFieldIndex), "ConfigEntity");
			this.AddElementFieldInfo("ConfigEntity", "Adresa", typeof(System.String), false, false, false, true,  (int)ConfigFieldIndex.Adresa, 100, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "AktivnaGodina", typeof(System.Int16), false, false, false, false,  (int)ConfigFieldIndex.AktivnaGodina, 0, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)ConfigFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Mjesto", typeof(System.String), false, false, false, true,  (int)ConfigFieldIndex.Mjesto, 100, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)ConfigFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Oib", typeof(System.String), true, false, false, false,  (int)ConfigFieldIndex.Oib, 11, 0, 0);
			this.AddElementFieldInfo("ConfigEntity", "Zr", typeof(System.String), false, false, false, true,  (int)ConfigFieldIndex.Zr, 50, 0, 0);
		}
		/// <summary>Inits KorisnikEntity's FieldInfo objects</summary>
		private void InitKorisnikEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(KorisnikFieldIndex), "KorisnikEntity");
			this.AddElementFieldInfo("KorisnikEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)KorisnikFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("KorisnikEntity", "KorisnikId", typeof(System.Int64), true, false, false, false,  (int)KorisnikFieldIndex.KorisnikId, 0, 0, 19);
			this.AddElementFieldInfo("KorisnikEntity", "Password", typeof(System.String), false, false, false, false,  (int)KorisnikFieldIndex.Password, 50, 0, 0);
			this.AddElementFieldInfo("KorisnikEntity", "RoleId", typeof(System.Int64), false, true, false, false,  (int)KorisnikFieldIndex.RoleId, 0, 0, 19);
			this.AddElementFieldInfo("KorisnikEntity", "Username", typeof(System.String), false, false, false, false,  (int)KorisnikFieldIndex.Username, 20, 0, 0);
		}
		/// <summary>Inits PartnerEntity's FieldInfo objects</summary>
		private void InitPartnerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PartnerFieldIndex), "PartnerEntity");
			this.AddElementFieldInfo("PartnerEntity", "Adresa", typeof(System.String), false, false, false, true,  (int)PartnerFieldIndex.Adresa, 100, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)PartnerFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Mjesto", typeof(System.String), false, false, false, true,  (int)PartnerFieldIndex.Mjesto, 20, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)PartnerFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "Oib", typeof(System.String), false, false, false, false,  (int)PartnerFieldIndex.Oib, 11, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "PartnerId", typeof(System.Int64), true, false, false, false,  (int)PartnerFieldIndex.PartnerId, 0, 0, 19);
			this.AddElementFieldInfo("PartnerEntity", "Posta", typeof(System.String), false, false, false, true,  (int)PartnerFieldIndex.Posta, 10, 0, 0);
			this.AddElementFieldInfo("PartnerEntity", "StatusId", typeof(System.Int64), false, true, false, false,  (int)PartnerFieldIndex.StatusId, 0, 0, 19);
			this.AddElementFieldInfo("PartnerEntity", "Valuta", typeof(System.Int16), false, false, false, false,  (int)PartnerFieldIndex.Valuta, 0, 0, 0);
		}
		/// <summary>Inits RacunGlavaEntity's FieldInfo objects</summary>
		private void InitRacunGlavaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RacunGlavaFieldIndex), "RacunGlavaEntity");
			this.AddElementFieldInfo("RacunGlavaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)RacunGlavaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "Datum", typeof(System.DateTime), false, false, false, false,  (int)RacunGlavaFieldIndex.Datum, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "Godina", typeof(System.Int16), false, false, false, false,  (int)RacunGlavaFieldIndex.Godina, 0, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "MjestoRadaAdresa", typeof(System.String), false, false, false, true,  (int)RacunGlavaFieldIndex.MjestoRadaAdresa, 100, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "MjestoRadaNaziv", typeof(System.String), false, false, false, true,  (int)RacunGlavaFieldIndex.MjestoRadaNaziv, 100, 0, 0);
			this.AddElementFieldInfo("RacunGlavaEntity", "PartnerId", typeof(System.Int64), false, true, false, false,  (int)RacunGlavaFieldIndex.PartnerId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "RacunGlavaId", typeof(System.Int64), true, false, false, false,  (int)RacunGlavaFieldIndex.RacunGlavaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "StatusId", typeof(System.Int64), false, true, false, false,  (int)RacunGlavaFieldIndex.StatusId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "TarifaId", typeof(System.Int64), false, true, false, false,  (int)RacunGlavaFieldIndex.TarifaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunGlavaEntity", "TarifaStopa", typeof(System.Decimal), false, false, false, false,  (int)RacunGlavaFieldIndex.TarifaStopa, 0, 2, 5);
			this.AddElementFieldInfo("RacunGlavaEntity", "Valuta", typeof(System.Int16), false, false, false, false,  (int)RacunGlavaFieldIndex.Valuta, 0, 0, 0);
		}
		/// <summary>Inits RacunStavkaEntity's FieldInfo objects</summary>
		private void InitRacunStavkaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RacunStavkaFieldIndex), "RacunStavkaEntity");
			this.AddElementFieldInfo("RacunStavkaEntity", "ArtiklId", typeof(System.Int64), false, true, false, false,  (int)RacunStavkaFieldIndex.ArtiklId, 0, 0, 19);
			this.AddElementFieldInfo("RacunStavkaEntity", "Cijena", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.Cijena, 0, 2, 10);
			this.AddElementFieldInfo("RacunStavkaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)RacunStavkaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("RacunStavkaEntity", "Iznos", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.Iznos, 0, 2, 10);
			this.AddElementFieldInfo("RacunStavkaEntity", "Kolicina", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.Kolicina, 0, 2, 8);
			this.AddElementFieldInfo("RacunStavkaEntity", "PdvIznos", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.PdvIznos, 0, 2, 10);
			this.AddElementFieldInfo("RacunStavkaEntity", "PdvPosto", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.PdvPosto, 0, 2, 4);
			this.AddElementFieldInfo("RacunStavkaEntity", "Pozicija", typeof(System.Int16), false, false, false, false,  (int)RacunStavkaFieldIndex.Pozicija, 0, 0, 0);
			this.AddElementFieldInfo("RacunStavkaEntity", "RacunGlavaId", typeof(System.Int64), false, true, false, false,  (int)RacunStavkaFieldIndex.RacunGlavaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunStavkaEntity", "RacunStavkaId", typeof(System.Int64), true, false, false, false,  (int)RacunStavkaFieldIndex.RacunStavkaId, 0, 0, 19);
			this.AddElementFieldInfo("RacunStavkaEntity", "TarifaIznos", typeof(System.Decimal), false, false, false, false,  (int)RacunStavkaFieldIndex.TarifaIznos, 0, 2, 10);
		}
		/// <summary>Inits RoleRoEntity's FieldInfo objects</summary>
		private void InitRoleRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RoleRoFieldIndex), "RoleRoEntity");
			this.AddElementFieldInfo("RoleRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)RoleRoFieldIndex.Code, 50, 0, 0);
			this.AddElementFieldInfo("RoleRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)RoleRoFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("RoleRoEntity", "RoleId", typeof(System.Int64), true, false, false, false,  (int)RoleRoFieldIndex.RoleId, 0, 0, 19);
		}
		/// <summary>Inits StatusRoEntity's FieldInfo objects</summary>
		private void InitStatusRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StatusRoFieldIndex), "StatusRoEntity");
			this.AddElementFieldInfo("StatusRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)StatusRoFieldIndex.Code, 50, 0, 0);
			this.AddElementFieldInfo("StatusRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)StatusRoFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StatusRoEntity", "StatusId", typeof(System.Int64), true, false, false, false,  (int)StatusRoFieldIndex.StatusId, 0, 0, 19);
		}
		/// <summary>Inits TarifaEntity's FieldInfo objects</summary>
		private void InitTarifaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TarifaFieldIndex), "TarifaEntity");
			this.AddElementFieldInfo("TarifaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)TarifaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("TarifaEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)TarifaFieldIndex.Naziv, 100, 0, 0);
			this.AddElementFieldInfo("TarifaEntity", "StatusId", typeof(System.Int64), false, false, false, false,  (int)TarifaFieldIndex.StatusId, 0, 0, 19);
			this.AddElementFieldInfo("TarifaEntity", "Stopa", typeof(System.Decimal), false, false, false, false,  (int)TarifaFieldIndex.Stopa, 0, 2, 5);
			this.AddElementFieldInfo("TarifaEntity", "TarifaId", typeof(System.Int64), true, false, false, false,  (int)TarifaFieldIndex.TarifaId, 0, 0, 19);
		}
		
	}
}




