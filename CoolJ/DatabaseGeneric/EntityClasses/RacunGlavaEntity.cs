﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
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
using NinjaSoftware.Enio.CoolJ;
using NinjaSoftware.Enio.CoolJ.HelperClasses;
using NinjaSoftware.Enio.CoolJ.FactoryClasses;
using NinjaSoftware.Enio.CoolJ.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;
using Newtonsoft.Json;
using NinjaSoftware.Api.CoolJ;

namespace NinjaSoftware.Enio.CoolJ.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'RacunGlava'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)]	
	public partial class RacunGlavaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<RacunStavkaEntity> _racunStavkaCollection;
		private PartnerEntity _partner;
		private StatusRoEntity _status;
		private TarifaEntity _tarifa;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Partner</summary>
			public static readonly string Partner = "Partner";
			/// <summary>Member name Status</summary>
			public static readonly string Status = "Status";
			/// <summary>Member name Tarifa</summary>
			public static readonly string Tarifa = "Tarifa";
			/// <summary>Member name RacunStavkaCollection</summary>
			public static readonly string RacunStavkaCollection = "RacunStavkaCollection";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new RacunGlavaEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<RacunGlavaEntity> FetchRacunGlavaCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(RacunGlavaFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<RacunGlavaEntity> toReturn = new EntityCollection<RacunGlavaEntity>(new RacunGlavaEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<RacunGlavaEntity> FetchRacunGlavaCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<RacunGlavaEntity> toReturn = new EntityCollection<RacunGlavaEntity>(new RacunGlavaEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static RacunGlavaEntity FetchRacunGlava(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long RacunGlavaId)
		{
			RacunGlavaEntity _RacunGlavaEntity = new RacunGlavaEntity(RacunGlavaId);
			adapter.FetchEntity(_RacunGlavaEntity, prefetchPath);
			return _RacunGlavaEntity;
		}

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RacunGlavaEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public RacunGlavaEntity():base("RacunGlavaEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RacunGlavaEntity(IEntityFields2 fields):base("RacunGlavaEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RacunGlavaEntity</param>
		public RacunGlavaEntity(IValidator validator):base("RacunGlavaEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="racunGlavaId">PK value for RacunGlava which data should be fetched into this RacunGlava object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RacunGlavaEntity(System.Int64 racunGlavaId):base("RacunGlavaEntity")
		{
			InitClassEmpty(null, null);
			this.RacunGlavaId = racunGlavaId;
		}

		/// <summary> CTor</summary>
		/// <param name="racunGlavaId">PK value for RacunGlava which data should be fetched into this RacunGlava object</param>
		/// <param name="validator">The custom validator object for this RacunGlavaEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RacunGlavaEntity(System.Int64 racunGlavaId, IValidator validator):base("RacunGlavaEntity")
		{
			InitClassEmpty(validator, null);
			this.RacunGlavaId = racunGlavaId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RacunGlavaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_racunStavkaCollection = (EntityCollection<RacunStavkaEntity>)info.GetValue("_racunStavkaCollection", typeof(EntityCollection<RacunStavkaEntity>));
				_partner = (PartnerEntity)info.GetValue("_partner", typeof(PartnerEntity));
				if(_partner!=null)
				{
					_partner.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_status = (StatusRoEntity)info.GetValue("_status", typeof(StatusRoEntity));
				if(_status!=null)
				{
					_status.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_tarifa = (TarifaEntity)info.GetValue("_tarifa", typeof(TarifaEntity));
				if(_tarifa!=null)
				{
					_tarifa.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((RacunGlavaFieldIndex)fieldIndex)
			{
				case RacunGlavaFieldIndex.PartnerId:
					DesetupSyncPartner(true, false);
					break;
				case RacunGlavaFieldIndex.StatusId:
					DesetupSyncStatus(true, false);
					break;
				case RacunGlavaFieldIndex.TarifaId:
					DesetupSyncTarifa(true, false);
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
				case "Partner":
					this.Partner = (PartnerEntity)entity;
					break;
				case "Status":
					this.Status = (StatusRoEntity)entity;
					break;
				case "Tarifa":
					this.Tarifa = (TarifaEntity)entity;
					break;
				case "RacunStavkaCollection":
					this.RacunStavkaCollection.Add((RacunStavkaEntity)entity);
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
				case "Partner":
					toReturn.Add(Relations.PartnerEntityUsingPartnerId);
					break;
				case "Status":
					toReturn.Add(Relations.StatusRoEntityUsingStatusId);
					break;
				case "Tarifa":
					toReturn.Add(Relations.TarifaEntityUsingTarifaId);
					break;
				case "RacunStavkaCollection":
					toReturn.Add(Relations.RacunStavkaEntityUsingRacunGlavaId);
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
				case "Partner":
					SetupSyncPartner(relatedEntity);
					break;
				case "Status":
					SetupSyncStatus(relatedEntity);
					break;
				case "Tarifa":
					SetupSyncTarifa(relatedEntity);
					break;
				case "RacunStavkaCollection":
					this.RacunStavkaCollection.Add((RacunStavkaEntity)relatedEntity);
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
				case "Partner":
					DesetupSyncPartner(false, true);
					break;
				case "Status":
					DesetupSyncStatus(false, true);
					break;
				case "Tarifa":
					DesetupSyncTarifa(false, true);
					break;
				case "RacunStavkaCollection":
					this.PerformRelatedEntityRemoval(this.RacunStavkaCollection, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_partner!=null)
			{
				toReturn.Add(_partner);
			}
			if(_status!=null)
			{
				toReturn.Add(_status);
			}
			if(_tarifa!=null)
			{
				toReturn.Add(_tarifa);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.RacunStavkaCollection);
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
				info.AddValue("_racunStavkaCollection", ((_racunStavkaCollection!=null) && (_racunStavkaCollection.Count>0) && !this.MarkedForDeletion)?_racunStavkaCollection:null);
				info.AddValue("_partner", (!this.MarkedForDeletion?_partner:null));
				info.AddValue("_status", (!this.MarkedForDeletion?_status:null));
				info.AddValue("_tarifa", (!this.MarkedForDeletion?_tarifa:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new RacunGlavaRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'RacunStavka' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRacunStavkaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RacunStavkaFields.RacunGlavaId, null, ComparisonOperator.Equal, this.RacunGlavaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Partner' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPartner()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PartnerFields.PartnerId, null, ComparisonOperator.Equal, this.PartnerId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Tarifa' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTarifa()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TarifaFields.TarifaId, null, ComparisonOperator.Equal, this.TarifaId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(RacunGlavaEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._racunStavkaCollection);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._racunStavkaCollection = (EntityCollection<RacunStavkaEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._racunStavkaCollection != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<RacunStavkaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunStavkaEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Partner", _partner);
			toReturn.Add("Status", _status);
			toReturn.Add("Tarifa", _tarifa);
			toReturn.Add("RacunStavkaCollection", _racunStavkaCollection);
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
			_fieldsCustomProperties.Add("BrojRacuna", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ConcurrencyGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Datum", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Godina", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MjestoRadaAdresa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MjestoRadaNaziv", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PartnerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RacunGlavaId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StatusId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TarifaId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TarifaStopa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Valuta", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Vrijeme", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _partner</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPartner(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _partner, new PropertyChangedEventHandler( OnPartnerPropertyChanged ), "Partner", NinjaSoftware.Enio.CoolJ.RelationClasses.StaticRacunGlavaRelations.PartnerEntityUsingPartnerIdStatic, true, signalRelatedEntity, "RacunGlavaCollection", resetFKFields, new int[] { (int)RacunGlavaFieldIndex.PartnerId } );
			_partner = null;
		}

		/// <summary> setups the sync logic for member _partner</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPartner(IEntityCore relatedEntity)
		{
			if(_partner!=relatedEntity)
			{
				DesetupSyncPartner(true, true);
				_partner = (PartnerEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _partner, new PropertyChangedEventHandler( OnPartnerPropertyChanged ), "Partner", NinjaSoftware.Enio.CoolJ.RelationClasses.StaticRacunGlavaRelations.PartnerEntityUsingPartnerIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPartnerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _status</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncStatus(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _status, new PropertyChangedEventHandler( OnStatusPropertyChanged ), "Status", NinjaSoftware.Enio.CoolJ.RelationClasses.StaticRacunGlavaRelations.StatusRoEntityUsingStatusIdStatic, true, signalRelatedEntity, "RacunGlavaCollection", resetFKFields, new int[] { (int)RacunGlavaFieldIndex.StatusId } );
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
				this.PerformSetupSyncRelatedEntity( _status, new PropertyChangedEventHandler( OnStatusPropertyChanged ), "Status", NinjaSoftware.Enio.CoolJ.RelationClasses.StaticRacunGlavaRelations.StatusRoEntityUsingStatusIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _tarifa</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTarifa(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _tarifa, new PropertyChangedEventHandler( OnTarifaPropertyChanged ), "Tarifa", NinjaSoftware.Enio.CoolJ.RelationClasses.StaticRacunGlavaRelations.TarifaEntityUsingTarifaIdStatic, true, signalRelatedEntity, "RacunGlavaCollection", resetFKFields, new int[] { (int)RacunGlavaFieldIndex.TarifaId } );
			_tarifa = null;
		}

		/// <summary> setups the sync logic for member _tarifa</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTarifa(IEntityCore relatedEntity)
		{
			if(_tarifa!=relatedEntity)
			{
				DesetupSyncTarifa(true, true);
				_tarifa = (TarifaEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _tarifa, new PropertyChangedEventHandler( OnTarifaPropertyChanged ), "Tarifa", NinjaSoftware.Enio.CoolJ.RelationClasses.StaticRacunGlavaRelations.TarifaEntityUsingTarifaIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTarifaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RacunGlavaEntity</param>
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
		public  static RacunGlavaRelations Relations
		{
			get	{ return new RacunGlavaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RacunStavka' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRacunStavkaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<RacunStavkaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(RacunStavkaEntityFactory))), (IEntityRelation)GetRelationsForField("RacunStavkaCollection")[0], (int)NinjaSoftware.Enio.CoolJ.EntityType.RacunGlavaEntity, (int)NinjaSoftware.Enio.CoolJ.EntityType.RacunStavkaEntity, 0, null, null, null, null, "RacunStavkaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Partner' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPartner
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PartnerEntityFactory))),	(IEntityRelation)GetRelationsForField("Partner")[0], (int)NinjaSoftware.Enio.CoolJ.EntityType.RacunGlavaEntity, (int)NinjaSoftware.Enio.CoolJ.EntityType.PartnerEntity, 0, null, null, null, null, "Partner", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StatusRo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStatus
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(StatusRoEntityFactory))),	(IEntityRelation)GetRelationsForField("Status")[0], (int)NinjaSoftware.Enio.CoolJ.EntityType.RacunGlavaEntity, (int)NinjaSoftware.Enio.CoolJ.EntityType.StatusRoEntity, 0, null, null, null, null, "Status", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Tarifa' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTarifa
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(TarifaEntityFactory))),	(IEntityRelation)GetRelationsForField("Tarifa")[0], (int)NinjaSoftware.Enio.CoolJ.EntityType.RacunGlavaEntity, (int)NinjaSoftware.Enio.CoolJ.EntityType.TarifaEntity, 0, null, null, null, null, "Tarifa", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The BrojRacuna property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."BrojRacuna"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int32 BrojRacuna
		{
			get { return (System.Int32)GetValue((int)RacunGlavaFieldIndex.BrojRacuna, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.BrojRacuna, value); }
		}

		/// <summary> The ConcurrencyGuid property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)RacunGlavaFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The Datum property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."Datum"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.DateTime Datum
		{
			get { return (System.DateTime)GetValue((int)RacunGlavaFieldIndex.Datum, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.Datum, value); }
		}

		/// <summary> The Godina property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."Godina"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int16 Godina
		{
			get { return (System.Int16)GetValue((int)RacunGlavaFieldIndex.Godina, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.Godina, value); }
		}

		/// <summary> The MjestoRadaAdresa property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."MjestoRadaAdresa"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual System.String MjestoRadaAdresa
		{
			get { return (System.String)GetValue((int)RacunGlavaFieldIndex.MjestoRadaAdresa, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.MjestoRadaAdresa, value); }
		}

		/// <summary> The MjestoRadaNaziv property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."MjestoRadaNaziv"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual System.String MjestoRadaNaziv
		{
			get { return (System.String)GetValue((int)RacunGlavaFieldIndex.MjestoRadaNaziv, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.MjestoRadaNaziv, value); }
		}

		/// <summary> The PartnerId property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."PartnerId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int64 PartnerId
		{
			get { return (System.Int64)GetValue((int)RacunGlavaFieldIndex.PartnerId, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.PartnerId, value); }
		}

		/// <summary> The RacunGlavaId property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."RacunGlavaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]		
		public virtual System.Int64 RacunGlavaId
		{
			get { return (System.Int64)GetValue((int)RacunGlavaFieldIndex.RacunGlavaId, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.RacunGlavaId, value); }
		}

		/// <summary> The StatusId property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."StatusId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int64 StatusId
		{
			get { return (System.Int64)GetValue((int)RacunGlavaFieldIndex.StatusId, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.StatusId, value); }
		}

		/// <summary> The TarifaId property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."TarifaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int64 TarifaId
		{
			get { return (System.Int64)GetValue((int)RacunGlavaFieldIndex.TarifaId, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.TarifaId, value); }
		}

		/// <summary> The TarifaStopa property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."TarifaStopa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal TarifaStopa
		{
			get { return (System.Decimal)GetValue((int)RacunGlavaFieldIndex.TarifaStopa, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.TarifaStopa, value); }
		}

		/// <summary> The Valuta property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."Valuta"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int16 Valuta
		{
			get { return (System.Int16)GetValue((int)RacunGlavaFieldIndex.Valuta, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.Valuta, value); }
		}

		/// <summary> The Vrijeme property of the Entity RacunGlava<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RacunGlava"."Vrijeme"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String Vrijeme
		{
			get { return (System.String)GetValue((int)RacunGlavaFieldIndex.Vrijeme, true); }
			set	{ SetValue((int)RacunGlavaFieldIndex.Vrijeme, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'RacunStavkaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(RacunStavkaEntity))]
		public virtual EntityCollection<RacunStavkaEntity> RacunStavkaCollection
		{
			get { return GetOrCreateEntityCollection<RacunStavkaEntity, RacunStavkaEntityFactory>("RacunGlava", true, false, ref _racunStavkaCollection);	}
		}

		/// <summary> Gets / sets related entity of type 'PartnerEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual PartnerEntity Partner
		{
			get	{ return _partner; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPartner(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "RacunGlavaCollection", "Partner", _partner, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'StatusRoEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
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
					SetSingleRelatedEntityNavigator(value, "RacunGlavaCollection", "Status", _status, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'TarifaEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual TarifaEntity Tarifa
		{
			get	{ return _tarifa; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncTarifa(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "RacunGlavaCollection", "Tarifa", _tarifa, true); 
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
		
		/// <summary>Returns the NinjaSoftware.Enio.CoolJ.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)NinjaSoftware.Enio.CoolJ.EntityType.RacunGlavaEntity; }
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
