using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Net;
using System.ComponentModel;
using XiaoFeng;
using XiaoFeng.Data;
using XiaoFeng.Model;

namespace FayElf.Blog.Model
{
	#region ZWTbCatalogueModel操作类
	/*
     ===================================================================
        Author : jacky
        Email : jacky@zhuovi.com
        QQ : 7092734
        Site : www.zhuovi.com
        Create Time : 2023-04-24 09:38:55
        Description : 本类有XiaoFeng类库自动生成
     ===================================================================
     */
    /// <summary>
    /// ZWTbCatalogueModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:55
    /// </summary>
    [Table(Name = "ZW_Tb_Catalogue", PrimaryKey = "ID", ModelType = ModelType.Table, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class ZWTbCatalogueModel : Entity<ZWTbCatalogueModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ZWTbCatalogueModel() { }
		#endregion

		#region 属性
        /// <summary>
        /// ID
        /// </summary>
        private int? _ID;
        /// <summary>
        /// ID
        /// </summary>
		[DisplayName("ID")]
        [Description("ID")]
		[DataObjectField(true, true, true, 0)]
		[Column(Name = "ID", PrimaryKey = true, AutoIncrement = true, DataType = "INTEGER", DefaultValue = "", Description = "ID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 1, AutoIncrementStep = 1)]
        public int? ID
        {
            get { return this._ID; }
            set
            {
                if (!this._ID.EqualsIgnoreCase(value))
                {
                    var val = this._ID;
                    this._ID = value;
                    this.AddDirty("ID", val, value);
                }
            }
        }
        /// <summary>
        /// Name
        /// </summary>
        private String _Name;
        /// <summary>
        /// Name
        /// </summary>
		[DisplayName("Name")]
        [Description("Name")]
		[DataObjectField(false, false, true, 100)]
		[Column(Name = "Name", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Name", IsNullable = true, Length = 100, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Name
        {
            get { return this._Name; }
            set
            {
                if (this._Name != value)
                {
                    var val = this._Name;
                    this._Name = value ?? string.Empty;
                    this.AddDirty("Name", val, value);
                }
            }
        }
        /// <summary>
        /// KnowledgeID
        /// </summary>
        private int? _KnowledgeID;
        /// <summary>
        /// KnowledgeID
        /// </summary>
		[DisplayName("KnowledgeID")]
        [Description("KnowledgeID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "KnowledgeID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "0", Description = "KnowledgeID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? KnowledgeID
        {
            get { return this._KnowledgeID; }
            set
            {
                if (!this._KnowledgeID.EqualsIgnoreCase(value))
                {
                    var val = this._KnowledgeID;
                    this._KnowledgeID = value;
                    this.AddDirty("KnowledgeID", val, value);
                }
            }
        }
        /// <summary>
        /// ParentID
        /// </summary>
        private int? _ParentID;
        /// <summary>
        /// ParentID
        /// </summary>
		[DisplayName("ParentID")]
        [Description("ParentID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "ParentID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "0", Description = "ParentID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? ParentID
        {
            get { return this._ParentID; }
            set
            {
                if (!this._ParentID.EqualsIgnoreCase(value))
                {
                    var val = this._ParentID;
                    this._ParentID = value;
                    this.AddDirty("ParentID", val, value);
                }
            }
        }
        /// <summary>
        /// Description
        /// </summary>
        private String _Description;
        /// <summary>
        /// Description
        /// </summary>
		[DisplayName("Description")]
        [Description("Description")]
		[DataObjectField(false, false, true, 500)]
		[Column(Name = "Description", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Description", IsNullable = true, Length = 500, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Description
        {
            get { return this._Description; }
            set
            {
                if (this._Description != value)
                {
                    var val = this._Description;
                    this._Description = value ?? string.Empty;
                    this.AddDirty("Description", val, value);
                }
            }
        }
        /// <summary>
        /// SortID
        /// </summary>
        private Int64? _SortID;
        /// <summary>
        /// SortID
        /// </summary>
		[DisplayName("SortID")]
        [Description("SortID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "SortID", PrimaryKey = false, AutoIncrement = false, DataType = "BIGINT", DefaultValue = "100000", Description = "SortID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public Int64? SortID
        {
            get { return this._SortID; }
            set
            {
                if (!this._SortID.EqualsIgnoreCase(value))
                {
                    var val = this._SortID;
                    this._SortID = value;
                    this.AddDirty("SortID", val, value);
                }
            }
        }
        /// <summary>
        /// AddDate
        /// </summary>
        private DateTime? _AddDate;
        /// <summary>
        /// AddDate
        /// </summary>
		[DisplayName("AddDate")]
        [Description("AddDate")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "AddDate", PrimaryKey = false, AutoIncrement = false, DataType = "DATETIME", DefaultValue = "NOW", Description = "AddDate", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public DateTime? AddDate
        {
            get { return this._AddDate; }
            set
            {
                if (!this._AddDate.EqualsIgnoreCase(value))
                {
                    var val = this._AddDate;
                    this._AddDate = value;
                    this.AddDirty("AddDate", val, value);
                }
            }
        }
        /// <summary>
        /// AddTimestamp
        /// </summary>
        private Int64? _AddTimestamp;
        /// <summary>
        /// AddTimestamp
        /// </summary>
		[DisplayName("AddTimestamp")]
        [Description("AddTimestamp")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "AddTimestamp", PrimaryKey = false, AutoIncrement = false, DataType = "BIGINT", DefaultValue = "TIMESTAMP", Description = "AddTimestamp", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public Int64? AddTimestamp
        {
            get { return this._AddTimestamp; }
            set
            {
                if (!this._AddTimestamp.EqualsIgnoreCase(value))
                {
                    var val = this._AddTimestamp;
                    this._AddTimestamp = value;
                    this.AddDirty("AddTimestamp", val, value);
                }
            }
        }
        #endregion

		#region 析构器
		/// <summary>
		/// 析构器
		/// </summary>
		~ZWTbCatalogueModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}