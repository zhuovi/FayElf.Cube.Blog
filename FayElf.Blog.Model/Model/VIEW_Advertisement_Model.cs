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
	#region VIEWAdvertisementModel操作类
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
    /// VIEWAdvertisementModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:56
    /// </summary>
    [View(Name = "VIEW_Advertisement", Definition = "select A.*,B.Name as CategoryName from ZW_Tb_Advertisement as A left join ZW_Tb_Advertisement as Bon A.CategoryID = B.ID")]
    [Table(Name = "VIEW_Advertisement", PrimaryKey = "", ModelType = ModelType.View, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class VIEWAdvertisementModel : Entity<VIEWAdvertisementModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public VIEWAdvertisementModel() { }
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
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "ID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "ID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
		[DataObjectField(false, false, true, 255)]
		[Column(Name = "Name", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Name", IsNullable = true, Length = 255, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// CategoryID
        /// </summary>
        private int? _CategoryID;
        /// <summary>
        /// CategoryID
        /// </summary>
		[DisplayName("CategoryID")]
        [Description("CategoryID")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "CategoryID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "CategoryID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// ImageUrl
        /// </summary>
        private String _ImageUrl;
        /// <summary>
        /// ImageUrl
        /// </summary>
		[DisplayName("ImageUrl")]
        [Description("ImageUrl")]
		[DataObjectField(false, false, true, 255)]
		[Column(Name = "ImageUrl", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "ImageUrl", IsNullable = true, Length = 255, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Url
        /// </summary>
        private String _Url;
        /// <summary>
        /// Url
        /// </summary>
		[DisplayName("Url")]
        [Description("Url")]
		[DataObjectField(false, false, true, 255)]
		[Column(Name = "Url", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Url", IsNullable = true, Length = 255, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Remark
        /// </summary>
        private String _Remark;
        /// <summary>
        /// Remark
        /// </summary>
		[DisplayName("Remark")]
        [Description("Remark")]
		[DataObjectField(false, false, true, 255)]
		[Column(Name = "Remark", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Remark", IsNullable = true, Length = 255, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Remark
        {
            get { return this._Remark; }
            set
            {
                if (this._Remark != value)
                {
                    var val = this._Remark;
                    this._Remark = value ?? string.Empty;
                    this.AddDirty("Remark", val, value);
                }
            }
        }
        /// <summary>
        /// StartTime
        /// </summary>
        private DateTime? _StartTime;
        /// <summary>
        /// StartTime
        /// </summary>
		[DisplayName("StartTime")]
        [Description("StartTime")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "StartTime", PrimaryKey = false, AutoIncrement = false, DataType = "DATETIME", DefaultValue = "", Description = "StartTime", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public DateTime? StartTime
        {
            get { return this._StartTime; }
            set
            {
                if (!this._StartTime.EqualsIgnoreCase(value))
                {
                    var val = this._StartTime;
                    this._StartTime = value;
                    this.AddDirty("StartTime", val, value);
                }
            }
        }
        /// <summary>
        /// EndTime
        /// </summary>
        private DateTime? _EndTime;
        /// <summary>
        /// EndTime
        /// </summary>
		[DisplayName("EndTime")]
        [Description("EndTime")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "EndTime", PrimaryKey = false, AutoIncrement = false, DataType = "DATETIME", DefaultValue = "", Description = "EndTime", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public DateTime? EndTime
        {
            get { return this._EndTime; }
            set
            {
                if (!this._EndTime.EqualsIgnoreCase(value))
                {
                    var val = this._EndTime;
                    this._EndTime = value;
                    this.AddDirty("EndTime", val, value);
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
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "SortID", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "SortID", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Pass
        /// </summary>
        private int? _Pass;
        /// <summary>
        /// Pass
        /// </summary>
		[DisplayName("Pass")]
        [Description("Pass")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "Pass", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "Pass", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? Pass
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
        /// ShowCounts
        /// </summary>
        private int? _ShowCounts;
        /// <summary>
        /// ShowCounts
        /// </summary>
		[DisplayName("ShowCounts")]
        [Description("ShowCounts")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "ShowCounts", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "ShowCounts", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? ShowCounts
        {
            get { return this._ShowCounts; }
            set
            {
                if (!this._ShowCounts.EqualsIgnoreCase(value))
                {
                    var val = this._ShowCounts;
                    this._ShowCounts = value;
                    this.AddDirty("ShowCounts", val, value);
                }
            }
        }
        /// <summary>
        /// ClickCounts
        /// </summary>
        private int? _ClickCounts;
        /// <summary>
        /// ClickCounts
        /// </summary>
		[DisplayName("ClickCounts")]
        [Description("ClickCounts")]
		[DataObjectField(false, false, true, 0)]
		[Column(Name = "ClickCounts", PrimaryKey = false, AutoIncrement = false, DataType = "INTEGER", DefaultValue = "", Description = "ClickCounts", IsNullable = true, Length = 0, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public int? ClickCounts
        {
            get { return this._ClickCounts; }
            set
            {
                if (!this._ClickCounts.EqualsIgnoreCase(value))
                {
                    var val = this._ClickCounts;
                    this._ClickCounts = value;
                    this.AddDirty("ClickCounts", val, value);
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
        /// CategoryName
        /// </summary>
        private String _CategoryName;
        /// <summary>
        /// CategoryName
        /// </summary>
		[DisplayName("CategoryName")]
        [Description("CategoryName")]
		[DataObjectField(false, false, true, 255)]
		[Column(Name = "CategoryName", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "CategoryName", IsNullable = true, Length = 255, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String CategoryName
        {
            get { return this._CategoryName; }
            set
            {
                if (this._CategoryName != value)
                {
                    var val = this._CategoryName;
                    this._CategoryName = value ?? string.Empty;
                    this.AddDirty("CategoryName", val, value);
                }
            }
        }
        #endregion

		#region 析构器
		/// <summary>
		/// 析构器
		/// </summary>
		~VIEWAdvertisementModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}