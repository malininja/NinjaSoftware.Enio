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
	/// <summary>Implements the relations factory for the entity: StatusRo. </summary>
	public partial class StatusRoRelations
	{
		/// <summary>CTor</summary>
		public StatusRoRelations()
		{
		}

		/// <summary>Gets all relations of the StatusRoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ArtiklEntityUsingStatusId);
			toReturn.Add(this.PartnerEntityUsingStatusId);
			toReturn.Add(this.RacunGlavaEntityUsingStatusId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StatusRoEntity and ArtiklEntity over the 1:n relation they have, using the relation between the fields:
		/// StatusRo.StatusId - Artikl.StatusId
		/// </summary>
		public virtual IEntityRelation ArtiklEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ArtiklCollection" , true);
				relation.AddEntityFieldPair(StatusRoFields.StatusId, ArtiklFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusRoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StatusRoEntity and PartnerEntity over the 1:n relation they have, using the relation between the fields:
		/// StatusRo.StatusId - Partner.StatusId
		/// </summary>
		public virtual IEntityRelation PartnerEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PartnerCollection" , true);
				relation.AddEntityFieldPair(StatusRoFields.StatusId, PartnerFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusRoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PartnerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StatusRoEntity and RacunGlavaEntity over the 1:n relation they have, using the relation between the fields:
		/// StatusRo.StatusId - RacunGlava.StatusId
		/// </summary>
		public virtual IEntityRelation RacunGlavaEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunGlavaCollection" , true);
				relation.AddEntityFieldPair(StatusRoFields.StatusId, RacunGlavaFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusRoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaEntity", false);
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
	internal static class StaticStatusRoRelations
	{
		internal static readonly IEntityRelation ArtiklEntityUsingStatusIdStatic = new StatusRoRelations().ArtiklEntityUsingStatusId;
		internal static readonly IEntityRelation PartnerEntityUsingStatusIdStatic = new StatusRoRelations().PartnerEntityUsingStatusId;
		internal static readonly IEntityRelation RacunGlavaEntityUsingStatusIdStatic = new StatusRoRelations().RacunGlavaEntityUsingStatusId;

		/// <summary>CTor</summary>
		static StaticStatusRoRelations()
		{
		}
	}
}
