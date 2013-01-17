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
	
	/// <summary>Entity class which represents the entity 'Partner'.<br/><br/></summary>
	[Serializable]
	public partial class PartnerEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<CjenikEntity> _cjenikCollection;
		private EntityCollection<RacunGlavaEntity> _racunGlavaCollection;
		private StatusRoEntity _status;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Status</summary>
			public static readonly string Status = "Status";
			/// <summary>Member name CjenikCollection</summary>
			public static readonly string CjenikCollection = "CjenikCollection";
			/// <summary>Member name RacunGlavaCollection</summary>
			public static readonly string RacunGlavaCollection = "RacunGlavaCollection";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PartnerEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public PartnerEntity():base("PartnerEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PartnerEntity(IEntityFields2 fields):base("PartnerEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PartnerEntity</param>
		public PartnerEntity(IValidator validator):base("PartnerEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="partnerId">PK value for Partner which data should be fetched into this Partner object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PartnerEntity(System.Int64 partnerId):base("PartnerEntity")
		{
			InitClassEmpty(null, null);
			this.PartnerId = partnerId;
		}

		/// <summary> CTor</summary>
		/// <param name="partnerId">PK value for Partner which data should be fetched into this Partner object</param>
		/// <param name="validator">The custom validator object for this PartnerEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PartnerEntity(System.Int64 partnerId, IValidator validator):base("PartnerEntity")
		{
			InitClassEmpty(validator, null);
			this.PartnerId = partnerId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PartnerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_cjenikCollection = (EntityCollection<CjenikEntity>)info.GetValue("_cjenikCollection", typeof(EntityCollection<CjenikEntity>));
				_racunGlavaCollection = (EntityCollection<RacunGlavaEntity>)info.GetValue("_racunGlavaCollection", typeof(EntityCollection<RacunGlavaEntity>));
				_status = (StatusRoEntity)info.GetValue("_status", typeof(StatusRoEntity));
				if(_status!=null)
				{
					_status.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((PartnerFieldIndex)fieldIndex)
			{
				case PartnerFieldIndex.StatusId:
					DesetupSyncStatus(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Status":
					this.Status = (StatusRoEntity)entity;
					break;
				case "CjenikCollection":
					this.CjenikCollection.Add((CjenikEntity)entity);
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
				case "Status":
					toReturn.Add(Relations.StatusRoEntityUsingStatusId);
					break;
				case "CjenikCollection":
					toReturn.Add(Relations.CjenikEntityUsingPartnerId);
					break;
				case "RacunGlavaCollection":
					toReturn.Add(Relations.RacunGlavaEntityUsingPartnerId);
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
				case "Status":
					SetupSyncStatus(relatedEntity);
					break;
				case "CjenikCollection":
					this.CjenikCollection.Add((CjenikEntity)relatedEntity);
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
				case "Status":
					DesetupSyncStatus(false, true);
					break;
				case "CjenikCollection":
					this.PerformRelatedEntityRemoval(this.CjenikCollection, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_status!=null)
			{
				toReturn.Add(_status);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.CjenikCollection);
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
				info.AddValue("_cjenikCollection", ((_cjenikCollection!=null) && (_cjenikCollection.Count>0) && !this.MarkedForDeletion)?_cjenikCollection:null);
				info.AddValue("_racunGlavaCollection", ((_racunGlavaCollection!=null) && (_racunGlavaCollection.Count>0) && !this.MarkedForDeletion)?_racunGlavaCollection:null);
				info.AddValue("_status", (!this.MarkedForDeletion?_status:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PartnerRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Cjenik' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCjenikCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CjenikFields.PartnerId, null, ComparisonOperator.Equal, this.PartnerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RacunGlava' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRacunGlavaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RacunGlavaFields.PartnerId, null, ComparisonOperator.Equal, this.PartnerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'StatusRo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStatus()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StatusRoFields.StatusId, null, ComparisonOperator.Equal, this.StatusId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(PartnerEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._cjenikCollection);
			collectionsQueue.Enqueue(this._racunGlavaCollection);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._cjenikCollection = (EntityCollection<CjenikEntity>) collectionsQueue.Dequeue();
			this._racunGlavaCollection = (EntityCollection<RacunGlavaEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._cjenikCollection != null);
			toReturn |=(this._racunGlavaCollection != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CjenikEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CjenikEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RacunGlavaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Status", _status);
			toReturn.Add("CjenikCollection", _cjenikCollection);
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
			_fieldsCustomProperties.Add("Adresa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ConcurrencyGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Mjesto", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Naziv", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Oib", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PartnerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Posta", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StatusId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Valuta", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _status</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStatus(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _status, new PropertyChangedEventHandler( OnStatusPropertyChanged ), "Status", NinjaSoftware.Enio.RelationClasses.StaticPartnerRelations.StatusRoEntityUsingStatusIdStatic, true, signalRelatedEntity, "PartnerCollection", resetFKFields, new int[] { (int)PartnerFieldIndex.StatusId } );
			_status = null;
		}

		/// <summary> setups the sync logic for member _status</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStatus(IEntityCore relatedEntity)
		{
			if(_status!=relatedEntity)
			{
				DesetupSyncStatus(true, true);
				_status = (StatusRoEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _status, new PropertyChangedEventHandler( OnStatusPropertyChanged ), "Status", NinjaSoftware.Enio.RelationClasses.StaticPartnerRelations.StatusRoEntityUsingStatusIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnStatusPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PartnerEntity</param>
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
		public  static PartnerRelations Relations
		{
			get	{ return new PartnerRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Cjenik' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCjenikCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CjenikEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CjenikEntityFactory))), (IEntityRelation)GetRelationsForField("CjenikCollection")[0], (int)NinjaSoftware.Enio.EntityType.PartnerEntity, (int)NinjaSoftware.Enio.EntityType.CjenikEntity, 0, null, null, null, null, "CjenikCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RacunGlava' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRacunGlavaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<RacunGlavaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory))), (IEntityRelation)GetRelationsForField("RacunGlavaCollection")[0], (int)NinjaSoftware.Enio.EntityType.PartnerEntity, (int)NinjaSoftware.Enio.EntityType.RacunGlavaEntity, 0, null, null, null, null, "RacunGlavaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StatusRo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStatus
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(StatusRoEntityFactory))),	(IEntityRelation)GetRelationsForField("Status")[0], (int)NinjaSoftware.Enio.EntityType.PartnerEntity, (int)NinjaSoftware.Enio.EntityType.StatusRoEntity, 0, null, null, null, null, "Status", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The Adresa property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."Adresa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Adresa
		{
			get { return (System.String)GetValue((int)PartnerFieldIndex.Adresa, true); }
			set	{ SetValue((int)PartnerFieldIndex.Adresa, value); }
		}

		/// <summary> The ConcurrencyGuid property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)PartnerFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)PartnerFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The Mjesto property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."Mjesto"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Mjesto
		{
			get { return (System.String)GetValue((int)PartnerFieldIndex.Mjesto, true); }
			set	{ SetValue((int)PartnerFieldIndex.Mjesto, value); }
		}

		/// <summary> The Naziv property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."Naziv"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Naziv
		{
			get { return (System.String)GetValue((int)PartnerFieldIndex.Naziv, true); }
			set	{ SetValue((int)PartnerFieldIndex.Naziv, value); }
		}

		/// <summary> The Oib property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."Oib"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 11<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Oib
		{
			get { return (System.String)GetValue((int)PartnerFieldIndex.Oib, true); }
			set	{ SetValue((int)PartnerFieldIndex.Oib, value); }
		}

		/// <summary> The PartnerId property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."PartnerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bigint, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int64 PartnerId
		{
			get { return (System.Int64)GetValue((int)PartnerFieldIndex.PartnerId, true); }
			set	{ SetValue((int)PartnerFieldIndex.PartnerId, value); }
		}

		/// <summary> The Posta property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."Posta"<br/>
		/// Table field type characteristics (type, precision, scale, length): Varchar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Posta
		{
			get { return (System.String)GetValue((int)PartnerFieldIndex.Posta, true); }
			set	{ SetValue((int)PartnerFieldIndex.Posta, value); }
		}

		/// <summary> The StatusId property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."StatusId"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bigint, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int64 StatusId
		{
			get { return (System.Int64)GetValue((int)PartnerFieldIndex.StatusId, true); }
			set	{ SetValue((int)PartnerFieldIndex.StatusId, value); }
		}

		/// <summary> The Valuta property of the Entity Partner<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Partner"."Valuta"<br/>
		/// Table field type characteristics (type, precision, scale, length): Smallint, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 Valuta
		{
			get { return (System.Int16)GetValue((int)PartnerFieldIndex.Valuta, true); }
			set	{ SetValue((int)PartnerFieldIndex.Valuta, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CjenikEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CjenikEntity))]
		public virtual EntityCollection<CjenikEntity> CjenikCollection
		{
			get { return GetOrCreateEntityCollection<CjenikEntity, CjenikEntityFactory>("Partner", true, false, ref _cjenikCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RacunGlavaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RacunGlavaEntity))]
		public virtual EntityCollection<RacunGlavaEntity> RacunGlavaCollection
		{
			get { return GetOrCreateEntityCollection<RacunGlavaEntity, RacunGlavaEntityFactory>("Partner", true, false, ref _racunGlavaCollection);	}
		}

		/// <summary> Gets / sets related entity of type 'StatusRoEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual StatusRoEntity Status
		{
			get	{ return _status; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncStatus(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PartnerCollection", "Status", _status, true); 
				}
			}
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
			get { return (int)NinjaSoftware.Enio.EntityType.PartnerEntity; }
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