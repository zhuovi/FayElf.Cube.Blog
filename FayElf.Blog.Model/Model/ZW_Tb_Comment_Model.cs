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
	#region ZWTbCommentModel操作类
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
    /// ZWTbCommentModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:55
    /// </summary>
    [Table(Name = "ZW_Tb_Comment", PrimaryKey = "ID", ModelType = ModelType.Table, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class ZWTbCommentModel : Entity<ZWTbCommentModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ZWTbCommentModel() { }
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
		[DataObjectField(true, false, false, 50)]
		[Column(Name = "ID", PrimaryKey = true, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "UUID", Description = "ID", IsNullable = false, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// BlogID
        /// </summary>
        private String _BlogID;
        /// <summary>
        /// BlogID
        /// </summary>
		[DisplayName("BlogID")]
        [Description("BlogID")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "BlogID", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "0", Description = "BlogID", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String BlogID
        {
            get { return this._BlogID; }
            set
            {
                if (this._BlogID != value)
                {
                    var val = this._BlogID;
                    this._BlogID = value ?? string.Empty;
                    this.AddDirty("BlogID", val, value);
                }
            }
        }
        /// <summary>
        /// UserID
        /// </summary>
        private int? _UserID;
        /// <summary>
        /// UserID
        /// </summary>
		[DisplayName("UserID")]
        [Description("UserID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "UserID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "UserID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? UserID
        {
            get { return this._UserID; }
            set
            {
                if (!this._UserID.EqualsIgnoreCase(value))
                {
                    var val = this._UserID;
                    this._UserID = value;
                    this.AddDirty("UserID", val, value);
                }
            }
        }
        /// <summary>
        /// QQ
        /// </summary>
        private String _QQ;
        /// <summary>
        /// QQ
        /// </summary>
		[DisplayName("QQ")]
        [Description("QQ")]
		[DataObjectField(false, false, true, 20)]
		[Column(Name = "QQ", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "QQ", IsNullable = true, Length = 20, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String QQ
        {
            get { return this._QQ; }
            set
            {
                if (this._QQ != value)
                {
                    var val = this._QQ;
                    this._QQ = value ?? string.Empty;
                    this.AddDirty("QQ", val, value);
                }
            }
        }
        /// <summary>
        /// Email
        /// </summary>
        private String _Email;
        /// <summary>
        /// Email
        /// </summary>
		[DisplayName("Email")]
        [Description("Email")]
		[DataObjectField(false, false, true, 100)]
		[Column(Name = "Email", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Email", IsNullable = true, Length = 100, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Email
        {
            get { return this._Email; }
            set
            {
                if (this._Email != value)
                {
                    var val = this._Email;
                    this._Email = value ?? string.Empty;
                    this.AddDirty("Email", val, value);
                }
            }
        }
        /// <summary>
        /// UserName
        /// </summary>
        private String _UserName;
        /// <summary>
        /// UserName
        /// </summary>
		[DisplayName("UserName")]
        [Description("UserName")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "UserName", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "UserName", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String UserName
        {
            get { return this._UserName; }
            set
            {
                if (this._UserName != value)
                {
                    var val = this._UserName;
                    this._UserName = value ?? string.Empty;
                    this.AddDirty("UserName", val, value);
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
        /// ParentID
        /// </summary>
        private String _ParentID;
        /// <summary>
        /// ParentID
        /// </summary>
		[DisplayName("ParentID")]
        [Description("ParentID")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "ParentID", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "ParentID", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String ParentID
        {
            get { return this._ParentID; }
            set
            {
                if (this._ParentID != value)
                {
                    var val = this._ParentID;
                    this._ParentID = value ?? string.Empty;
                    this.AddDirty("ParentID", val, value);
                }
            }
        }
        /// <summary>
        /// UserIP
        /// </summary>
        private String _UserIP;
        /// <summary>
        /// UserIP
        /// </summary>
		[DisplayName("UserIP")]
        [Description("UserIP")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "UserIP", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "UserIP", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String UserIP
        {
            get { return this._UserIP; }
            set
            {
                if (this._UserIP != value)
                {
                    var val = this._UserIP;
                    this._UserIP = value ?? string.Empty;
                    this.AddDirty("UserIP", val, value);
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
		~ZWTbCommentModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}