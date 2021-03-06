﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using NinjaSoftware.Enio.CoolJ;
using NinjaSoftware.Enio.CoolJ.FactoryClasses;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.Enio.CoolJ.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: RacunGlavaStatusRo. </summary>
	public partial class RacunGlavaStatusRoRelations
	{
		/// <summary>CTor</summary>
		public RacunGlavaStatusRoRelations()
		{
		}

		/// <summary>Gets all relations of the RacunGlavaStatusRoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RacunGlavaEntityUsingRacunGlavaStatusId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RacunGlavaStatusRoEntity and RacunGlavaEntity over the 1:n relation they have, using the relation between the fields:
		/// RacunGlavaStatusRo.RacunGlavaStatusId - RacunGlava.RacunGlavaStatusId
		/// </summary>
		public virtual IEntityRelation RacunGlavaEntityUsingRacunGlavaStatusId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunGlavas" , true);
				relation.AddEntityFieldPair(RacunGlavaStatusRoFields.RacunGlavaStatusId, RacunGlavaFields.RacunGlavaStatusId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RacunGlavaStatusRoEntity", true);
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
	internal static class StaticRacunGlavaStatusRoRelations
	{
		internal static readonly IEntityRelation RacunGlavaEntityUsingRacunGlavaStatusIdStatic = new RacunGlavaStatusRoRelations().RacunGlavaEntityUsingRacunGlavaStatusId;

		/// <summary>CTor</summary>
		static StaticRacunGlavaStatusRoRelations()
		{
		}
	}
}
