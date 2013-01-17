///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 17. siječanj 2013. 16:50:12
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using NinjaSoftware.Enio.EntityClasses;
using NinjaSoftware.Enio.HelperClasses;
using NinjaSoftware.Enio.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.Enio.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly NinjaSoftware.Enio.EntityType _typeOfEntity;
		private readonly bool _isInHierarchy;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, NinjaSoftware.Enio.EntityType typeOfEntity, bool isInHierarchy) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
			_isInHierarchy = isInHierarchy;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((NinjaSoftware.Enio.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
						
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity which this factory belongs to.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TEntity>(this);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), InheritanceInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
	}

	/// <summary>Factory to create new, empty ArtiklEntity objects.</summary>
	[Serializable]
	public partial class ArtiklEntityFactory : EntityFactoryBase2<ArtiklEntity> {
		/// <summary>CTor</summary>
		public ArtiklEntityFactory() : base("ArtiklEntity", NinjaSoftware.Enio.EntityType.ArtiklEntity, false) { }
		
		/// <summary>Creates a new ArtiklEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ArtiklEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewArtiklUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BrojacEntity objects.</summary>
	[Serializable]
	public partial class BrojacEntityFactory : EntityFactoryBase2<BrojacEntity> {
		/// <summary>CTor</summary>
		public BrojacEntityFactory() : base("BrojacEntity", NinjaSoftware.Enio.EntityType.BrojacEntity, false) { }
		
		/// <summary>Creates a new BrojacEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BrojacEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBrojacUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CjenikEntity objects.</summary>
	[Serializable]
	public partial class CjenikEntityFactory : EntityFactoryBase2<CjenikEntity> {
		/// <summary>CTor</summary>
		public CjenikEntityFactory() : base("CjenikEntity", NinjaSoftware.Enio.EntityType.CjenikEntity, false) { }
		
		/// <summary>Creates a new CjenikEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CjenikEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCjenikUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ConfigEntity objects.</summary>
	[Serializable]
	public partial class ConfigEntityFactory : EntityFactoryBase2<ConfigEntity> {
		/// <summary>CTor</summary>
		public ConfigEntityFactory() : base("ConfigEntity", NinjaSoftware.Enio.EntityType.ConfigEntity, false) { }
		
		/// <summary>Creates a new ConfigEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ConfigEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewConfigUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty KorisnikEntity objects.</summary>
	[Serializable]
	public partial class KorisnikEntityFactory : EntityFactoryBase2<KorisnikEntity> {
		/// <summary>CTor</summary>
		public KorisnikEntityFactory() : base("KorisnikEntity", NinjaSoftware.Enio.EntityType.KorisnikEntity, false) { }
		
		/// <summary>Creates a new KorisnikEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new KorisnikEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewKorisnikUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PartnerEntity objects.</summary>
	[Serializable]
	public partial class PartnerEntityFactory : EntityFactoryBase2<PartnerEntity> {
		/// <summary>CTor</summary>
		public PartnerEntityFactory() : base("PartnerEntity", NinjaSoftware.Enio.EntityType.PartnerEntity, false) { }
		
		/// <summary>Creates a new PartnerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PartnerEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPartnerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty RacunGlavaEntity objects.</summary>
	[Serializable]
	public partial class RacunGlavaEntityFactory : EntityFactoryBase2<RacunGlavaEntity> {
		/// <summary>CTor</summary>
		public RacunGlavaEntityFactory() : base("RacunGlavaEntity", NinjaSoftware.Enio.EntityType.RacunGlavaEntity, false) { }
		
		/// <summary>Creates a new RacunGlavaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RacunGlavaEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRacunGlavaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty RacunStavkaEntity objects.</summary>
	[Serializable]
	public partial class RacunStavkaEntityFactory : EntityFactoryBase2<RacunStavkaEntity> {
		/// <summary>CTor</summary>
		public RacunStavkaEntityFactory() : base("RacunStavkaEntity", NinjaSoftware.Enio.EntityType.RacunStavkaEntity, false) { }
		
		/// <summary>Creates a new RacunStavkaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RacunStavkaEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRacunStavkaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty RoleRoEntity objects.</summary>
	[Serializable]
	public partial class RoleRoEntityFactory : EntityFactoryBase2<RoleRoEntity> {
		/// <summary>CTor</summary>
		public RoleRoEntityFactory() : base("RoleRoEntity", NinjaSoftware.Enio.EntityType.RoleRoEntity, false) { }
		
		/// <summary>Creates a new RoleRoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new RoleRoEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewRoleRoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty StatusRoEntity objects.</summary>
	[Serializable]
	public partial class StatusRoEntityFactory : EntityFactoryBase2<StatusRoEntity> {
		/// <summary>CTor</summary>
		public StatusRoEntityFactory() : base("StatusRoEntity", NinjaSoftware.Enio.EntityType.StatusRoEntity, false) { }
		
		/// <summary>Creates a new StatusRoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new StatusRoEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStatusRoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty TarifaEntity objects.</summary>
	[Serializable]
	public partial class TarifaEntityFactory : EntityFactoryBase2<TarifaEntity> {
		/// <summary>CTor</summary>
		public TarifaEntityFactory() : base("TarifaEntity", NinjaSoftware.Enio.EntityType.TarifaEntity, false) { }
		
		/// <summary>Creates a new TarifaEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TarifaEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTarifaUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(NinjaSoftware.Enio.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case NinjaSoftware.Enio.EntityType.ArtiklEntity:
					factoryToUse = new ArtiklEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.BrojacEntity:
					factoryToUse = new BrojacEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.CjenikEntity:
					factoryToUse = new CjenikEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.ConfigEntity:
					factoryToUse = new ConfigEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.KorisnikEntity:
					factoryToUse = new KorisnikEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.PartnerEntity:
					factoryToUse = new PartnerEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.RacunGlavaEntity:
					factoryToUse = new RacunGlavaEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.RacunStavkaEntity:
					factoryToUse = new RacunStavkaEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.RoleRoEntity:
					factoryToUse = new RoleRoEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.StatusRoEntity:
					factoryToUse = new StatusRoEntityFactory();
					break;
				case NinjaSoftware.Enio.EntityType.TarifaEntity:
					factoryToUse = new TarifaEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
#if CF
		/// <summary>Gets the factory of the entity with the NinjaSoftware.Enio.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(NinjaSoftware.Enio.EntityType typeOfEntity)
		{
			return GeneralEntityFactory.Create(typeOfEntity).GetEntityFactory();
		}
#else
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(NinjaSoftware.Enio.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((NinjaSoftware.Enio.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the NinjaSoftware.Enio.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(NinjaSoftware.Enio.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
#endif		
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the NinjaSoftware.Enio.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (NinjaSoftware.Enio.EntityType)Enum.Parse(typeof(NinjaSoftware.Enio.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((NinjaSoftware.Enio.EntityType)Enum.Parse(typeof(NinjaSoftware.Enio.EntityType), leftOperandEntityName, false), joinType, (NinjaSoftware.Enio.EntityType)Enum.Parse(typeof(NinjaSoftware.Enio.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the NinjaSoftware.Enio.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((NinjaSoftware.Enio.EntityType)entityTypeValue);
		}
#if !CF		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}
#endif
	}
}
