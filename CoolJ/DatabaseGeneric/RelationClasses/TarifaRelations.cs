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
	/// <summary>Implements the relations factory for the entity: Tarifa. </summary>
	public partial class TarifaRelations
	{
		/// <summary>CTor</summary>
		public TarifaRelations()
		{
		}

		/// <summary>Gets all relations of the TarifaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RacunGlavaEntityUsingTarifaId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between TarifaEntity and RacunGlavaEntity over the 1:n relation they have, using the relation between the fields:
		/// Tarifa.TarifaId - RacunGlava.TarifaId
		/// </summary>
		public virtual IEntityRelation RacunGlavaEntityUsingTarifaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "RacunGlavaCollection" , true);
				relation.AddEntityFieldPair(TarifaFields.TarifaId, RacunGlavaFields.TarifaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TarifaEntity", true);
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
	internal static class StaticTarifaRelations
	{
		internal static readonly IEntityRelation RacunGlavaEntityUsingTarifaIdStatic = new TarifaRelations().RacunGlavaEntityUsingTarifaId;

		/// <summary>CTor</summary>
		static StaticTarifaRelations()
		{
		}
	}
}
