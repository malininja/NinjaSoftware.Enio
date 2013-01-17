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
	/// <summary>Implements the relations factory for the entity: Korisnik. </summary>
	public partial class KorisnikRelations
	{
		/// <summary>CTor</summary>
		public KorisnikRelations()
		{
		}

		/// <summary>Gets all relations of the KorisnikEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RoleRoEntityUsingRoleId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between KorisnikEntity and RoleRoEntity over the m:1 relation they have, using the relation between the fields:
		/// Korisnik.RoleId - RoleRo.RoleId
		/// </summary>
		public virtual IEntityRelation RoleRoEntityUsingRoleId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Role", false);
				relation.AddEntityFieldPair(RoleRoFields.RoleId, KorisnikFields.RoleId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RoleRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("KorisnikEntity", true);
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
	internal static class StaticKorisnikRelations
	{
		internal static readonly IEntityRelation RoleRoEntityUsingRoleIdStatic = new KorisnikRelations().RoleRoEntityUsingRoleId;

		/// <summary>CTor</summary>
		static StaticKorisnikRelations()
		{
		}
	}
}
