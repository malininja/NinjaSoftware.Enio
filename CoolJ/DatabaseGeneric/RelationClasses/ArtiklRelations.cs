﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: Artikl. </summary>
	public partial class ArtiklRelations
	{
		/// <summary>CTor</summary>
		public ArtiklRelations()
		{
		}

		/// <summary>Gets all relations of the ArtiklEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CjenikEntityUsingArtiklId);
			toReturn.Add(this.RacunStavkaEntityUsingArtiklId);
			toReturn.Add(this.StatusRoEntityUsingStatusId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ArtiklEntity and CjenikEntity over the 1:n relation they have, using the relation between the fields:
		/// Artikl.ArtiklId - Cjenik.ArtiklId
		/// </summary>
		public virtual IEntityRelation CjenikEntityUsingArtiklId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CjenikCollection" , true);
				relation.AddEntityFieldPair(ArtiklFields.ArtiklId, CjenikFields.ArtiklId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CjenikEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ArtiklEntity and RacunStavkaEntity over the 1:n relation they have, using the relation between the fields:
		/// Artikl.ArtiklId - RacunStavka.ArtiklId
		/// </summary>
		public virtual IEntityRelation RacunStavkaEntityUsingArtiklId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunStavkaCollection" , true);
				relation.AddEntityFieldPair(ArtiklFields.ArtiklId, RacunStavkaFields.ArtiklId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunStavkaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ArtiklEntity and StatusRoEntity over the m:1 relation they have, using the relation between the fields:
		/// Artikl.StatusId - StatusRo.StatusId
		/// </summary>
		public virtual IEntityRelation StatusRoEntityUsingStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Status", false);
				relation.AddEntityFieldPair(StatusRoFields.StatusId, ArtiklFields.StatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StatusRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ArtiklEntity", true);
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
	internal static class StaticArtiklRelations
	{
		internal static readonly IEntityRelation CjenikEntityUsingArtiklIdStatic = new ArtiklRelations().CjenikEntityUsingArtiklId;
		internal static readonly IEntityRelation RacunStavkaEntityUsingArtiklIdStatic = new ArtiklRelations().RacunStavkaEntityUsingArtiklId;
		internal static readonly IEntityRelation StatusRoEntityUsingStatusIdStatic = new ArtiklRelations().StatusRoEntityUsingStatusId;

		/// <summary>CTor</summary>
		static StaticArtiklRelations()
		{
		}
	}
}