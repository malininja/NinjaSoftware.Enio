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
using System.Collections;
using System.Collections.Generic;
using NinjaSoftware.Enio;
using NinjaSoftware.Enio.FactoryClasses;
using NinjaSoftware.Enio.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.Enio.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Cjenik. </summary>
	public partial class CjenikRelations
	{
		/// <summary>CTor</summary>
		public CjenikRelations()
		{
		}

		/// <summary>Gets all relations of the CjenikEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ArtiklEntityUsingArtiklId);
			toReturn.Add(this.PartnerEntityUsingPartnerId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between CjenikEntity and ArtiklEntity over the m:1 relation they have, using the relation between the fields:
		/// Cjenik.ArtiklId - Artikl.ArtiklId
		/// </summary>
		public virtual IEntityRelation ArtiklEntityUsingArtiklId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Artikl", false);
				relation.AddEntityFieldPair(ArtiklFields.ArtiklId, CjenikFields.ArtiklId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CjenikEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CjenikEntity and PartnerEntity over the m:1 relation they have, using the relation between the fields:
		/// Cjenik.PartnerId - Partner.PartnerId
		/// </summary>
		public virtual IEntityRelation PartnerEntityUsingPartnerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Partner", false);
				relation.AddEntityFieldPair(PartnerFields.PartnerId, CjenikFields.PartnerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CjenikEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCjenikRelations
	{
		internal static readonly IEntityRelation ArtiklEntityUsingArtiklIdStatic = new CjenikRelations().ArtiklEntityUsingArtiklId;
		internal static readonly IEntityRelation PartnerEntityUsingPartnerIdStatic = new CjenikRelations().PartnerEntityUsingPartnerId;

		/// <summary>CTor</summary>
		static StaticCjenikRelations()
		{
		}
	}
}
