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
	#region ZWTbCategoryModel操作类
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
    /// ZWTbCategoryModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:55
    /// </summary>
    [Table(Name = "ZW_Tb_Category", PrimaryKey = "ID", ModelType = ModelType.Table, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class ZWTbCategoryModel : Entity<ZWTbCategoryModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ZWTbCategoryModel() { }
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
		[DataObjectField(true, true, false, 0)]
		[Column(Name = "ID", PrimaryKey = true, AutoIncrement = true, DataType = "INTEGER", DefaultValue = "", Description = "ID", IsNullable = false, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 1, AutoIncrementStep = 1)]
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
		[DataObjectField(false, false, false, 50)]
		[Column(Name = "Name", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Name", IsNullable = false, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// ParentID
        /// </summary>
        private int? _ParentID;
        /// <summary>
        /// ParentID
        /// </summary>
		[DisplayName("ParentID")]
        [Description("ParentID")]
		[DataObjectField(false, false, false, 0)]
		[Column(Name = "ParentID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "0", Description = "ParentID", IsNullable = false, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Url
        /// </summary>
        private String _Url;
        /// <summary>
        /// Url
        /// </summary>
		[DisplayName("Url")]
        [Description("Url")]
		[DataObjectField(false, false, true, 150)]
		[Column(Name = "Url", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Url", IsNullable = true, Length = 150, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Url
        {
            get { return this._Url; }
            set
            {
                if (this._Url != value)
                {
                    var val = this._Url;
                    this._Url = value ?? string.Empty;
                    this.AddDirty("Url", val, value);
                }
            }
        }
        /// <summary>
        /// Attribute
        /// </summary>
        private Int32? _Attribute;
        /// <summary>
        /// Attribute
        /// </summary>
		[DisplayName("Attribute")]
        [Description("Attribute")]
		[DataObjectField(false, false, false, 1)]
		[Column(Name = "Attribute", PrimaryKey = false, AutoIncrement = false, DataType = "INT", DefaultValue = "0", Description = "Attribute", IsNullable = false, Length = 1, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public Int32? Attribute
        {
            get { return this._Attribute; }
            set
            {
                if (!this._Attribute.EqualsIgnoreCase(value))
                {
                    var val = this._Attribute;
                    this._Attribute = value;
                    this.AddDirty("Attribute", val, value);
                }
            }
        }
        /// <summary>
        /// Pass
        /// </summary>
        private Int32? _Pass;
        /// <summary>
        /// Pass
        /// </summary>
		[DisplayName("Pass")]
        [Description("Pass")]
		[DataObjectField(false, false, false, 1)]
		[Column(Name = "Pass", PrimaryKey = false, AutoIncrement = false, DataType = "INT", DefaultValue = "1", Description = "Pass", IsNullable = false, Length = 1, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public Int32? Pass
        {
            get { return this._Pass; }
            set
            {
                if (!this._Pass.EqualsIgnoreCase(value))
                {
                    var val = this._Pass;
                    this._Pass = value;
                    this.AddDirty("Pass", val, value);
                }
            }
        }
        /// <summary>
        /// SortID
        /// </summary>
        private int? _SortID;
        /// <summary>
        /// SortID
        /// </summary>
		[DisplayName("SortID")]
        [Description("SortID")]
		[DataObjectField(false, false, false, 0)]
		[Column(Name = "SortID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "100000", Description = "SortID", IsNullable = false, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? SortID
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
		[DataObjectField(false, false, false, 0)]
		[Column(Name = "AddDate", PrimaryKey = false, AutoIncrement = false, DataType = "DATETIME", DefaultValue = "NOW", Description = "AddDate", IsNullable = false, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// UpdateDate
        /// </summary>
        private DateTime? _UpdateDate;
        /// <summary>
        /// UpdateDate
        /// </summary>
		[DisplayName("UpdateDate")]
        [Description("UpdateDate")]
		[DataObjectField(false, false, false, 0)]
		[Column(Name = "UpdateDate", PrimaryKey = false, AutoIncrement = false, DataType = "DATETIME", DefaultValue = "NOW", Description = "UpdateDate", IsNullable = false, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public DateTime? UpdateDate
        {
            get { return this._UpdateDate; }
            set
            {
                if (!this._UpdateDate.EqualsIgnoreCase(value))
                {
                    var val = this._UpdateDate;
                    this._UpdateDate = value;
                    this.AddDirty("UpdateDate", val, value);
                }
            }
        }
        #endregion

		#region 析构器
		/// <summary>
		/// 析构器
		/// </summary>
		~ZWTbCategoryModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}