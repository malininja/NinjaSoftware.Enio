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
	/// <summary>Implements the relations factory for the entity: Partner. </summary>
	public partial class PartnerRelations
	{
		/// <summary>CTor</summary>
		public PartnerRelations()
		{
		}

		/// <summary>Gets all relations of the PartnerEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CjenikEntityUsingPartnerId);
			toReturn.Add(this.RacunGlavaEntityUsingPartnerId);
			toReturn.Add(this.StatusRoEntityUsingStatusId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PartnerEntity and CjenikEntity over the 1:n relation they have, using the relation between the fields:
		/// Partner.PartnerId - Cjenik.PartnerId
		/// </summary>
		public virtual IEntityRelation CjenikEntityUsingPartnerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CjenikCollection" , true);
				relation.AddEntityFieldPair(PartnerFields.PartnerId, CjenikFields.PartnerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CjenikEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PartnerEntity and RacunGlavaEntity over the 1:n relation they have, using the relation between the fields:
		/// Partner.PartnerId - RacunGlava.PartnerId
		/// </summary>
		public virtual IEntityRelation RacunGlavaEntityUsingPartnerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunGlavaCollection" , true);
				relation.AddEntityFieldPair(PartnerFields.PartnerId, RacunGlavaFields.PartnerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PartnerEntity and StatusRoEntity over the m:1 relation they have, using the relation between the fields:
		/// Partner.StatusId - StatusRo.StatusId
		/// </summary>
		public virtual IEntityRelation StatusRoEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Status", false);
				relation.AddEntityFieldPair(StatusRoFields.StatusId, PartnerFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", true);
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
	internal static class StaticPartnerRelations
	{
		internal static readonly IEntityRelation CjenikEntityUsingPartnerIdStatic = new PartnerRelations().CjenikEntityUsingPartnerId;
		internal static readonly IEntityRelation RacunGlavaEntityUsingPartnerIdStatic = new PartnerRelations().RacunGlavaEntityUsingPartnerId;
		internal static readonly IEntityRelation StatusRoEntityUsingStatusIdStatic = new PartnerRelations().StatusRoEntityUsingStatusId;

		/// <summary>CTor</summary>
		static StaticPartnerRelations()
		{
		}
	}
}
