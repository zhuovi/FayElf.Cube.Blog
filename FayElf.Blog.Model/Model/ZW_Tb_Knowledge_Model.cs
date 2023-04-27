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
	#region ZWTbKnowledgeModel操作类
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
    /// ZWTbKnowledgeModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:55
    /// </summary>
    [Table(Name = "ZW_Tb_Knowledge", PrimaryKey = "ID", ModelType = ModelType.Table, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class ZWTbKnowledgeModel : Entity<ZWTbKnowledgeModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ZWTbKnowledgeModel() { }
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
        /// Title
        /// </summary>
        private String _Title;
        /// <summary>
        /// Title
        /// </summary>
		[DisplayName("Title")]
        [Description("Title")]
		[DataObjectField(false, false, false, 100)]
		[Column(Name = "Title", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Title", IsNullable = false, Length = 100, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Image
        /// </summary>
        private String _Image;
        /// <summary>
        /// Image
        /// </summary>
		[DisplayName("Image")]
        [Description("Image")]
		[DataObjectField(false, false, true, 200)]
		[Column(Name = "Image", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Image", IsNullable = true, Length = 200, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Image
        {
            get { return this._Image; }
            set
            {
                if (this._Image != value)
                {
                    var val = this._Image;
                    this._Image = value ?? string.Empty;
                    this.AddDirty("Image", val, value);
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
		[DataObjectField(false, false, true, 1)]
		[Column(Name = "Pass", PrimaryKey = false, AutoIncrement = false, DataType = "INT", DefaultValue = "1", Description = "Pass", IsNullable = true, Length = 1, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
		~ZWTbKnowledgeModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}