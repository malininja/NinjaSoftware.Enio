﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: 17. siječanj 2013. 16:50:12
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using NinjaSoftware.Enio;
using NinjaSoftware.Enio.HelperClasses;
using NinjaSoftware.Enio.FactoryClasses;
using NinjaSoftware.Enio.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.Enio.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity class which represents the entity 'StatusRo'.<br/><br/></summary>
	[Serializable]
	public partial class StatusRoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<ArtiklEntity> _artiklCollection;
		private EntityCollection<PartnerEntity> _partnerCollection;
		private EntityCollection<RacunGlavaEntity> _racunGlavaCollection;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ArtiklCollection</summary>
			public static readonly string ArtiklCollection = "ArtiklCollection";
			/// <summary>Member name PartnerCollection</summary>
			public static readonly string PartnerCollection = "PartnerCollection";
			/// <summary>Member name RacunGlavaCollection</summary>
			public static readonly string RacunGlavaCollection = "RacunGlavaCollection";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StatusRoEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public StatusRoEntity():base("StatusRoEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public StatusRoEntity(IEntityFields2 fields):base("StatusRoEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this StatusRoEntity</param>
		public StatusRoEntity(IValidator validator):base("StatusRoEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="statusId">PK value for StatusRo which data should be fetched into this StatusRo object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public StatusRoEntity(System.Int64 statusId):base("StatusRoEntity")
		{
			InitClassEmpty(null, null);
			this.StatusId = statusId;
		}

		/// <summary> CTor</summary>
		/// <param name="statusId">PK value for StatusRo which data should be fetched into this StatusRo object</param>
		/// <param name="validator">The custom validator object for this StatusRoEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public StatusRoEntity(System.Int64 statusId, IValidator validator):base("StatusRoEntity")
		{
			InitClassEmpty(validator, null);
			this.StatusId = statusId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected StatusRoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_artiklCollection = (EntityCollection<ArtiklEntity>)info.GetValue("_artiklCollection", typeof(EntityCollection<ArtiklEntity>));
				_partnerCollection = (EntityCollection<PartnerEntity>)info.GetValue("_partnerCollection", typeof(EntityCollection<PartnerEntity>));
				_racunGlavaCollection = (EntityCollection<RacunGlavaEntity>)info.GetValue("_racunGlavaCollection", typeof(EntityCollection<RacunGlavaEntity>));
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "ArtiklCollection":
					this.ArtiklCollection.Add((ArtiklEntity)entity);
					break;
				case "PartnerCollection":
					this.PartnerCollection.Add((PartnerEntity)entity);
					break;
				case "RacunGlavaCollection":
					this.RacunGlavaCollection.Add((RacunGlavaEntity)entity);
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ArtiklCollection":
					toReturn.Add(Relations.ArtiklEntityUsingStatusId);
					break;
				case "PartnerCollection":
					toReturn.Add(Relations.PartnerEntityUsingStatusId);
					break;
				case "RacunGlavaCollection":
					toReturn.Add(Relations.RacunGlavaEntityUsingStatusId);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ArtiklCollection":
					this.ArtiklCollection.Add((ArtiklEntity)relatedEntity);
					break;
				case "PartnerCollection":
					this.PartnerCollection.Add((PartnerEntity)relatedEntity);
					break;
				case "RacunGlavaCollection":
					this.RacunGlavaCollection.Add((RacunGlavaEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ArtiklCollection":
					this.PerformRelatedEntityRemoval(this.ArtiklCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PartnerCollection":
					this.PerformRelatedEntityRemoval(this.PartnerCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "RacunGlavaCollection":
					this.PerformRelatedEntityRemoval(this.RacunGlavaCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.ArtiklCollection);
			toReturn.Add(this.PartnerCollection);
			toReturn.Add(this.RacunGlavaCollection);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_artiklCollection", ((_artiklCollection!=null) && (_artiklCollection.Count>0) && !this.MarkedForDeletion)?_artiklCollection:null);
				info.AddValue("_partnerCollection", ((_partnerCollection!=null) && (_partnerCollection.Count>0) && !this.MarkedForDeletion)?_partnerCollection:null);
				info.AddValue("_racunGlavaCollection", ((_racunGlavaCollection!=null) && (_racunGlavaCollection.Count>0) && !this.MarkedForDeletion)?_racunGlavaCollection:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new StatusRoRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Artikl' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoArtiklCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ArtiklFields.StatusId, null, ComparisonOperator.Equal, this.StatusId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Partner' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPartnerCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PartnerFields.StatusId, null, ComparisonOperator.Equal, this.StatusId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RacunGlava' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRacunGlavaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RacunGlavaFields.StatusId, null, ComparisonOperator.Equal, this.StatusId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(StatusRoEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._artiklCollection);
			collectionsQueue.Enqueue(this._partnerCollection);
			collectionsQueue.Enqueue(this._racunGlavaCollection);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._artiklCollection = (EntityCollection<ArtiklEntity>) collectionsQueue.Dequeue();
			this._partnerCollection = (EntityCollection<PartnerEntity>) collectionsQueue.Dequeue();
			this._racunGlavaCollection = (EntityCollection<RacunGlavaEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._artiklCollection != null);
			toReturn |=(this._partnerCollection != null);
			toReturn |=(this._racunGlavaCollection != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ArtiklEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ArtiklEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PartnerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PartnerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RacunGlavaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ArtiklCollection", _artiklCollection);
			toReturn.Add("PartnerCollection", _partnerCollection);
			toReturn.Add("RacunGlavaCollection", _racunGlavaCollection);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Code", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StatusId", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this StatusRoEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static StatusRoRelations Relations
		{
			get	{ return new StatusRoRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Artikl' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathArtiklCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ArtiklEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ArtiklEntityFactory))), (IEntityRelation)GetRelationsForField("ArtiklCollection")[0], (int)NinjaSoftware.Enio.EntityType.StatusRoEntity, (int)NinjaSoftware.Enio.EntityType.ArtiklEntity, 0, null, null, null, null, "ArtiklCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Partner' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPartnerCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PartnerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PartnerEntityFactory))), (IEntityRelation)GetRelationsForField("PartnerCollection")[0], (int)NinjaSoftware.Enio.EntityType.StatusRoEntity, (int)NinjaSoftware.Enio.EntityType.PartnerEntity, 0, null, null, null, null, "PartnerCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RacunGlava' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRacunGlavaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<RacunGlavaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))), (IEntityRelation)GetRelationsForField("RacunGlavaCollection")[0], (int)NinjaSoftware.Enio.EntityType.StatusRoEntity, (int)NinjaSoftware.Enio.EntityType.RacunGlavaEntity, 0, null, null, null, null, "RacunGlavaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Code property of the Entity StatusRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StatusRo"."Code"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Code
		{
			get { return (System.String)GetValue((int)StatusRoFieldIndex.Code, true); }
			set	{ SetValue((int)StatusRoFieldIndex.Code, value); }
		}

		/// <summary> The Name property of the Entity StatusRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StatusRo"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StatusRoFieldIndex.Name, true); }
			set	{ SetValue((int)StatusRoFieldIndex.Name, value); }
		}

		/// <summary> The StatusId property of the Entity StatusRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StatusRo"."StatusId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bigint, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int64 StatusId
		{
			get { return (System.Int64)GetValue((int)StatusRoFieldIndex.StatusId, true); }
			set	{ SetValue((int)StatusRoFieldIndex.StatusId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ArtiklEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ArtiklEntity))]
		public virtual EntityCollection<ArtiklEntity> ArtiklCollection
		{
			get { return GetOrCreateEntityCollection<ArtiklEntity, ArtiklEntityFactory>("Status", true, false, ref _artiklCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PartnerEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PartnerEntity))]
		public virtual EntityCollection<PartnerEntity> PartnerCollection
		{
			get { return GetOrCreateEntityCollection<PartnerEntity, PartnerEntityFactory>("Status", true, false, ref _partnerCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RacunGlavaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RacunGlavaEntity))]
		public virtual EntityCollection<RacunGlavaEntity> RacunGlavaCollection
		{
			get { return GetOrCreateEntityCollection<RacunGlavaEntity, RacunGlavaEntityFactory>("Status", true, false, ref _racunGlavaCollection);	}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the NinjaSoftware.Enio.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)NinjaSoftware.Enio.EntityType.StatusRoEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}