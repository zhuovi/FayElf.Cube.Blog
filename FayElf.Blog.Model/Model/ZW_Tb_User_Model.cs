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
	#region ZWTbUserModel操作类
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
    /// ZWTbUserModel 操作类
    /// Version : 1.0.0
    /// Author : jacky
    /// Email : jacky@zhuovi.com
    /// QQ : 7092734
    /// Site : www.zhuovi.com
    /// Update Time : 2023-04-24 09:38:56
    /// </summary>
    [Table(Name = "ZW_Tb_User", PrimaryKey = "ID", ModelType = ModelType.Table, ConnName = "FayElf.Cube.Blog", ConnIndex = 0)]
    public class ZWTbUserModel : Entity<ZWTbUserModel>
	{
        #region 构造器
        /// <summary>
        /// 无参构造器
        /// </summary>
        public ZWTbUserModel() { }
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
        /// Account
        /// </summary>
        private String _Account;
        /// <summary>
        /// Account
        /// </summary>
		[DisplayName("Account")]
        [Description("Account")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "Account", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Account", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Account
        {
            get { return this._Account; }
            set
            {
                if (this._Account != value)
                {
                    var val = this._Account;
                    this._Account = value ?? string.Empty;
                    this.AddDirty("Account", val, value);
                }
            }
        }
        /// <summary>
        /// Password
        /// </summary>
        private String _Password;
        /// <summary>
        /// Password
        /// </summary>
		[DisplayName("Password")]
        [Description("Password")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "Password", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Password", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Password
        {
            get { return this._Password; }
            set
            {
                if (this._Password != value)
                {
                    var val = this._Password;
                    this._Password = value ?? string.Empty;
                    this.AddDirty("Password", val, value);
                }
            }
        }
        /// <summary>
        /// NickName
        /// </summary>
        private String _NickName;
        /// <summary>
        /// NickName
        /// </summary>
		[DisplayName("NickName")]
        [Description("NickName")]
		[DataObjectField(false, false, true, 50)]
		[Column(Name = "NickName", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "NickName", IsNullable = true, Length = 50, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String NickName
        {
            get { return this._NickName; }
            set
            {
                if (this._NickName != value)
                {
                    var val = this._NickName;
                    this._NickName = value ?? string.Empty;
                    this.AddDirty("NickName", val, value);
                }
            }
        }
        /// <summary>
        /// Sex
        /// </summary>
        private Int32? _Sex;
        /// <summary>
        /// Sex
        /// </summary>
		[DisplayName("Sex")]
        [Description("Sex")]
		[DataObjectField(false, false, true, 1)]
		[Column(Name = "Sex", PrimaryKey = false, AutoIncrement = false, DataType = "INT", DefaultValue = "0", Description = "Sex", IsNullable = true, Length = 1, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public Int32? Sex
        {
            get { return this._Sex; }
            set
            {
                if (!this._Sex.EqualsIgnoreCase(value))
                {
                    var val = this._Sex;
                    this._Sex = value;
                    this.AddDirty("Sex", val, value);
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
		[DataObjectField(false, false, true, 200)]
		[Column(Name = "Email", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Email", IsNullable = true, Length = 200, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
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
        /// Phone
        /// </summary>
        private String _Phone;
        /// <summary>
        /// Phone
        /// </summary>
		[DisplayName("Phone")]
        [Description("Phone")]
		[DataObjectField(false, false, true, 30)]
		[Column(Name = "Phone", PrimaryKey = false, AutoIncrement = false, DataType = "VARCHAR", DefaultValue = "", Description = "Phone", IsNullable = true, Length = 30, Digit = 0, IsUnique = false, IsIndex = false, AutoIncrementSeed = 0, AutoIncrementStep = 0)]
        public String Phone
        {
            get { return this._Phone; }
            set
            {
                if (this._Phone != value)
                {
                    var val = this._Phone;
                    this._Phone = value ?? string.Empty;
                    this.AddDirty("Phone", val, value);
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
		~ZWTbUserModel() { base.Dispose(true); }
		#endregion
	}
    #endregion
}