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
	#region ZWTbPublichtmlModel操作类
	/*
     ===================================================================
        Author : jacky
        Email : jacky@zhuovi.com
        QQ : 7092734
        Site : www.zhuovi.com
        Create Time : 2023-04-24 09:38:56
        Description : 本类有XiaoFeng类库自动生成
     ===================================================================
     */
    /// <summary>
    /// ZWTbPublichtmlModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:56
    /// </summary>
    [Table(Name = "ZW_Tb_Publichtml", PrimaryKey = "ID", ModelType = ModelType.Table, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class ZWTbPublichtmlModel : Entity<ZWTbPublichtmlModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ZWTbPublichtmlModel() { }
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
        /// CategoryID
        /// </summary>
        private int? _CategoryID;
        /// <summary>
        /// CategoryID
        /// </summary>
		[DisplayName("CategoryID")]
        [Description("CategoryID")]
		[DataObjectField(false, false, false, 0)]
		[Column(Name = "CategoryID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "CategoryID", IsNullable = false, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? CategoryID
        {
            get { return this._CategoryID; }
            set
            {
                if (!this._CategoryID.EqualsIgnoreCase(value))
                {
                    var val = this._CategoryID;
                    this._CategoryID = value;
                    this.AddDirty("CategoryID", val, value);
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
        /// Title
        /// </summary>
        private String _Title;
        /// <summary>
        /// Title
        /// </summary>
		[DisplayName("Title")]
        [Description("Title")]
		[DataObjectField(false, false, false, 200)]
		[Column(Name = "Title", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Title", IsNullable = false, Length = 200, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Title
        {
            get { return this._Title; }
            set
            {
                if (this._Title != value)
                {
                    var val = this._Title;
                    this._Title = value ?? string.Empty;
                    this.AddDirty("Title", val, value);
                }
            }
        }
        /// <summary>
        /// ImageUrl
        /// </summary>
        private String _ImageUrl;
        /// <summary>
        /// ImageUrl
        /// </summary>
		[DisplayName("ImageUrl")]
        [Description("ImageUrl")]
		[DataObjectField(false, false, true, 300)]
		[Column(Name = "ImageUrl", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "ImageUrl", IsNullable = true, Length = 300, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String ImageUrl
        {
            get { return this._ImageUrl; }
            set
            {
                if (this._ImageUrl != value)
                {
                    var val = this._ImageUrl;
                    this._ImageUrl = value ?? string.Empty;
                    this.AddDirty("ImageUrl", val, value);
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
		[DataObjectField(false, false, true, 300)]
		[Column(Name = "Description", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Description", IsNullable = true, Length = 300, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// KeyWords
        /// </summary>
        private String _KeyWords;
        /// <summary>
        /// KeyWords
        /// </summary>
		[DisplayName("KeyWords")]
        [Description("KeyWords")]
		[DataObjectField(false, false, true, 300)]
		[Column(Name = "KeyWords", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "KeyWords", IsNullable = true, Length = 300, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String KeyWords
        {
            get { return this._KeyWords; }
            set
            {
                if (this._KeyWords != value)
                {
                    var val = this._KeyWords;
                    this._KeyWords = value ?? string.Empty;
                    this.AddDirty("KeyWords", val, value);
                }
            }
        }
        /// <summary>
        /// Content
        /// </summary>
        private String _Content;
        /// <summary>
        /// Content
        /// </summary>
		[DisplayName("Content")]
        [Description("Content")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "Content", PrimaryKey = false, AutoIncrement = false, DataType = "TEXT", DefaultValue = "", Description = "Content", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Content
        {
            get { return this._Content; }
            set
            {
                if (this._Content != value)
                {
                    var val = this._Content;
                    this._Content = value ?? string.Empty;
                    this.AddDirty("Content", val, value);
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
        #endregion

		#region 析构器
		/// <summary>
		/// 析构器
		/// </summary>
		~ZWTbPublichtmlModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}