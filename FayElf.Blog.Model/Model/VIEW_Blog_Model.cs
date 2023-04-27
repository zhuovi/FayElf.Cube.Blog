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
	#region VIEWBlogModel操作类
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
    /// VIEWBlogModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:56
    /// </summary>
    [View(Name = "VIEW_Blog", Definition = "select A.*,B.Title as KnowledgeName,C.Name as CatalogueName from ZW_Tb_Blog as Aleft join ZW_Tb_Knowledge as Bon A.KnowledgeID = B.IDleft join ZW_Tb_Catalogue as Con A.CatalogueID = C.ID")]
    [Table(Name = "VIEW_Blog", PrimaryKey = "", ModelType = ModelType.View, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class VIEWBlogModel : Entity<VIEWBlogModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public VIEWBlogModel() { }
		#endregion

		#region 属性
        /// <summary>
        /// ID
        /// </summary>
        private String _ID;
        /// <summary>
        /// ID
        /// </summary>
		[DisplayName("ID")]
        [Description("ID")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "ID", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "ID", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String ID
        {
            get { return this._ID; }
            set
            {
                if (this._ID != value)
                {
                    var val = this._ID;
                    this._ID = value ?? string.Empty;
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
		[DataObjectField(false, false, true, 300)]
		[Column(Name = "Title", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Title", IsNullable = true, Length = 300, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Image
        /// </summary>
        private String _Image;
        /// <summary>
        /// Image
        /// </summary>
		[DisplayName("Image")]
        [Description("Image")]
		[DataObjectField(false, false, true, 300)]
		[Column(Name = "Image", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Image", IsNullable = true, Length = 300, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// KnowledgeID
        /// </summary>
        private int? _KnowledgeID;
        /// <summary>
        /// KnowledgeID
        /// </summary>
		[DisplayName("KnowledgeID")]
        [Description("KnowledgeID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "KnowledgeID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "KnowledgeID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// CatalogueID
        /// </summary>
        private int? _CatalogueID;
        /// <summary>
        /// CatalogueID
        /// </summary>
		[DisplayName("CatalogueID")]
        [Description("CatalogueID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "CatalogueID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "CatalogueID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? CatalogueID
        {
            get { return this._CatalogueID; }
            set
            {
                if (!this._CatalogueID.EqualsIgnoreCase(value))
                {
                    var val = this._CatalogueID;
                    this._CatalogueID = value;
                    this.AddDirty("CatalogueID", val, value);
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
        /// ContentMD
        /// </summary>
        private String _ContentMD;
        /// <summary>
        /// ContentMD
        /// </summary>
		[DisplayName("ContentMD")]
        [Description("ContentMD")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "ContentMD", PrimaryKey = false, AutoIncrement = false, DataType = "TEXT", DefaultValue = "", Description = "ContentMD", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String ContentMD
        {
            get { return this._ContentMD; }
            set
            {
                if (this._ContentMD != value)
                {
                    var val = this._ContentMD;
                    this._ContentMD = value ?? string.Empty;
                    this.AddDirty("ContentMD", val, value);
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
		[Column(Name = "Pass", PrimaryKey = false, AutoIncrement = false, DataType = "INT", DefaultValue = "", Description = "Pass", IsNullable = true, Length = 1, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
		[Column(Name = "SortID", PrimaryKey = false, AutoIncrement = false, DataType = "BIGINT", DefaultValue = "", Description = "SortID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Author
        /// </summary>
        private String _Author;
        /// <summary>
        /// Author
        /// </summary>
		[DisplayName("Author")]
        [Description("Author")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "Author", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Author", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Author
        {
            get { return this._Author; }
            set
            {
                if (this._Author != value)
                {
                    var val = this._Author;
                    this._Author = value ?? string.Empty;
                    this.AddDirty("Author", val, value);
                }
            }
        }
        /// <summary>
        /// Hits
        /// </summary>
        private Int64? _Hits;
        /// <summary>
        /// Hits
        /// </summary>
		[DisplayName("Hits")]
        [Description("Hits")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "Hits", PrimaryKey = false, AutoIncrement = false, DataType = "BIGINT", DefaultValue = "", Description = "Hits", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public Int64? Hits
        {
            get { return this._Hits; }
            set
            {
                if (!this._Hits.EqualsIgnoreCase(value))
                {
                    var val = this._Hits;
                    this._Hits = value;
                    this.AddDirty("Hits", val, value);
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
		[Column(Name = "AddDate", PrimaryKey = false, AutoIncrement = false, DataType = "DATETIME", DefaultValue = "", Description = "AddDate", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
		[Column(Name = "AddTimestamp", PrimaryKey = false, AutoIncrement = false, DataType = "BIGINT", DefaultValue = "", Description = "AddTimestamp", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// <summary>
        /// KnowledgeName
        /// </summary>
        private String _KnowledgeName;
        /// <summary>
        /// KnowledgeName
        /// </summary>
		[DisplayName("KnowledgeName")]
        [Description("KnowledgeName")]
		[DataObjectField(false, false, true, 100)]
		[Column(Name = "KnowledgeName", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "KnowledgeName", IsNullable = true, Length = 100, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String KnowledgeName
        {
            get { return this._KnowledgeName; }
            set
            {
                if (this._KnowledgeName != value)
                {
                    var val = this._KnowledgeName;
                    this._KnowledgeName = value ?? string.Empty;
                    this.AddDirty("KnowledgeName", val, value);
                }
            }
        }
        /// <summary>
        /// CatalogueName
        /// </summary>
        private String _CatalogueName;
        /// <summary>
        /// CatalogueName
        /// </summary>
		[DisplayName("CatalogueName")]
        [Description("CatalogueName")]
		[DataObjectField(false, false, true, 100)]
		[Column(Name = "CatalogueName", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "CatalogueName", IsNullable = true, Length = 100, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String CatalogueName
        {
            get { return this._CatalogueName; }
            set
            {
                if (this._CatalogueName != value)
                {
                    var val = this._CatalogueName;
                    this._CatalogueName = value ?? string.Empty;
                    this.AddDirty("CatalogueName", val, value);
                }
            }
        }
        #endregion

		#region 析构器
		/// <summary>
		/// 析构器
		/// </summary>
		~VIEWBlogModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}