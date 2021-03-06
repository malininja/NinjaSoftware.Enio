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
using System.Data;
using System.Data.Common;
using System.Configuration;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.Api.CoolJ;

using SD.LLBLGen.Pro.DQE.PostgreSql;

namespace NinjaSoftware.Enio.CoolJ.PostgreSql.DatabaseSpecific
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Data access adapter class, which controls the complete database interaction with the database for all objects.</summary>
	/// <remarks>Use a DataAccessAdapter object solely per thread, and per connection. A DataAccessAdapter object contains 1 active connection 
	/// and no thread-access scheduling code. This means that you need to create a new DataAccessAdapter object if you want to utilize
	/// in another thread a new connection and a new transaction or want to open a new connection.</remarks>
	public partial class DataAccessAdapter : DataAccessAdapterBase, INsDataAccessAdapter
	{
		#region Public static members
		/// <summary>The name of the key in the *.config file of the executing application which contains the connection string.</summary>
		/// <remarks>Default: the value set in the LLBLGen Pro project properties</remarks>
		public static string ConnectionStringKeyName="ConnectionString.PostgreSql (Npgsql)";
		#endregion

		/// <summary>CTor</summary>
		public DataAccessAdapter() : this(ReadConnectionStringFromConfig(), false, null, null)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		public DataAccessAdapter(bool keepConnectionOpen) : this(ReadConnectionStringFromConfig(), keepConnectionOpen, null, null)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		public DataAccessAdapter(string connectionString) : this(connectionString, false, null, null)
		{
		}

		/// <summary>CTor</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen) : this(connectionString, keepConnectionOpen, null, null)
		{
		}
		
		/// <summary>CTor.</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		/// <param name="catalogNameUsageSetting"> Configures this data access adapter object how to threat catalog names in persistence information.</param>
		/// <param name="catalogNameToUse"> The name to use if catalogNameUsageSetting is set to ForceName. Ignored otherwise.</param>
		/// <remarks>For backwards compatibility.</remarks>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen, CatalogNameUsage catalogNameUsageSetting, string catalogNameToUse) 
				: base(PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(connectionString, keepConnectionOpen, catalogNameUsageSetting, SchemaNameUsage.Default, catalogNameToUse, string.Empty, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		/// <param name="schemaNameUsageSetting">Configures this data access adapter object how to threat schema names in persistence information.</param>
		/// <param name="schemaNameToUse">Oracle specific. The name to use if schemaNameUsageSetting is set to ForceName. Ignored otherwise.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen, SchemaNameUsage schemaNameUsageSetting, string schemaNameToUse) 
				: base(PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(connectionString, keepConnectionOpen, CatalogNameUsage.Default, schemaNameUsageSetting, string.Empty, schemaNameToUse, null, null);
		}

		/// <summary>CTor.</summary>
		/// <param name="connectionString">The connection string to use when connecting to the database.</param>
		/// <param name="keepConnectionOpen">when true, the DataAccessAdapter will not close an opened connection. Use this for multi action usage.</param>
		/// <param name="catalogNameOverwrites"> The from-to name value pairs and setting for the overwriting of catalog names. Can be null.</param>
		/// <param name="schemaNameOverwrites"> The from-to name value pairs and setting for the overwriting of schema names. Can be null.</param>
		public DataAccessAdapter(string connectionString, bool keepConnectionOpen, CatalogNameOverwriteHashtable catalogNameOverwrites, SchemaNameOverwriteHashtable schemaNameOverwrites) 
				: base(PersistenceInfoProviderSingleton.GetInstance())
		{
			InitClassPhase2(connectionString, keepConnectionOpen, CatalogNameUsage.Default, SchemaNameUsage.Default, string.Empty, string.Empty, catalogNameOverwrites, schemaNameOverwrites);
		}


		/// <summary>Creates a new Dynamic Query engine object and passes in the defined catalog/schema overwrite hashtables.</summary>
		protected override DynamicQueryEngineBase CreateDynamicQueryEngine()
		{
			return this.PostProcessNewDynamicQueryEngine(new DynamicQueryEngine());
		}

		/// <summary>Reads the value of the setting with the key ConnectionStringKeyName from the *.config file and stores that value as the active connection string to use for this object.</summary>
		/// <returns>connection string read</returns>
		private static string ReadConnectionStringFromConfig()
		{
			return ConfigFileHelper.ReadConnectionStringFromConfig(ConnectionStringKeyName);
		}
		


		#region Custom DataAccessAdapter code.
		
		public long? UserId { get; set; }		
		
        /// <summary>
        /// Throws exception 'cos AuditInfo can't be implemented this way.
        /// </summary>
        protected override void OnDeleteEntitiesDirectly(IActionQuery deleteQuery)
        {
            throw new NotImplementedException("Audit info se ne može implementirati ovim načinom (ne prosljeđuje se entitet).");
            //base.OnDeleteEntitiesDirectly(deleteQuery);
        }

        /// <summary>
        /// Throws exception 'cos AuditInfo can't be implemented this way.
        /// </summary>
        protected override void OnUpdateEntitiesDirectly(IActionQuery updateQuery)
        {
            throw new NotImplementedException("Audit info se ne može implementirati ovim načinom (ne prosljeđuje se entitet).");
            //base.OnUpdateEntitiesDirectly(updateQuery);
        }
		
        protected override void OnBeforeEntitySave(IEntity2 entitySaved, bool insertAction)
        {
            if (entitySaved.IsDirty)
            {
                string concurrencyFieldName = ConfigurationManager.AppSettings["ConcurrencyFieldName"];
                entitySaved.Fields[concurrencyFieldName].CurrentValue = System.Guid.NewGuid().ToString();
            }

            base.OnBeforeEntitySave(entitySaved, insertAction);
        }

        protected override void OnSaveEntityComplete(IActionQuery saveQuery, IEntity2 entityToSave)
        {
            if (!(entityToSave is NinjaSoftware.Enio.CoolJ.EntityClasses.AuditInfoEntity) &&
                !(entityToSave is NinjaSoftware.Enio.CoolJ.EntityClasses.ErrorEntity))
            {
                if (entityToSave.IsNew)
                {
                    AuditInfo(entityToSave, NinjaSoftware.Enio.CoolJ.Enums.AuditInfoActionTypeEnum.Insert);
                }
                else
                {
                    AuditInfo(entityToSave, NinjaSoftware.Enio.CoolJ.Enums.AuditInfoActionTypeEnum.Update);
                }
            }

            base.OnSaveEntityComplete(saveQuery, entityToSave);
        }

        protected override void OnDeleteEntityComplete(IActionQuery deleteQuery, IEntity2 entityToDelete)
        {
            AuditInfo(entityToDelete, NinjaSoftware.Enio.CoolJ.Enums.AuditInfoActionTypeEnum.Delete);
            base.OnDeleteEntityComplete(deleteQuery, entityToDelete);
        }
		
        /// <summary>
        /// Saves data from changed fields in JSON.
        /// Enables to track entity history.
        /// </summary>
        private void AuditInfo(IEntity2 entity, NinjaSoftware.Enio.CoolJ.Enums.AuditInfoActionTypeEnum auditInfoActionTypeEnum)
        {
            NinjaSoftware.Enio.CoolJ.EntityClasses.AuditInfoEntity auditInfo = new NinjaSoftware.Enio.CoolJ.EntityClasses.AuditInfoEntity();
            auditInfo.ActionDateTime = DateTime.Now;
            auditInfo.AuditInfoActionTypeId = (long)auditInfoActionTypeEnum;
            auditInfo.EntityId = (long)(NinjaSoftware.Enio.CoolJ.Enums.EntityEnum)Enum.Parse(typeof(NinjaSoftware.Enio.CoolJ.Enums.EntityEnum), entity.LLBLGenProEntityName.Replace("Entity", ""));
            auditInfo.UserId = this.UserId.Value;

            System.Collections.Generic.Dictionary<string, object> fieldsDictionary = new System.Collections.Generic.Dictionary<string, object>();

            foreach (IEntityField2 field in entity.Fields)
            {
                string concurrencyFieldName = ConfigurationManager.AppSettings["ConcurrencyFieldName"];
                // Saves all fields if is not update.
                // If it is update, saves only changed fileds.
                if (field.IsPrimaryKey)
                {
                    // primary key is saved in separately
                    auditInfo.PrimaryKeyValue = (long)field.CurrentValue;
                }
                else if (NinjaSoftware.Enio.CoolJ.Enums.AuditInfoActionTypeEnum.Delete == auditInfoActionTypeEnum)
                {
                    // nothing, you can recreate entity from other audit infos for this entity
                }
                else if ((auditInfoActionTypeEnum != NinjaSoftware.Enio.CoolJ.Enums.AuditInfoActionTypeEnum.Update || field.IsChanged) &&
                    !field.IsPrimaryKey &&
                    field.Name != concurrencyFieldName)
                {
                    fieldsDictionary.Add(field.Name, field.CurrentValue);
                }
            }

            auditInfo.JsonData = Newtonsoft.Json.JsonConvert.SerializeObject(fieldsDictionary);

            this.SaveEntity(auditInfo, false, false);
        }
		
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomDataAccessAdapterCode

		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Code

		#endregion
	}
}
