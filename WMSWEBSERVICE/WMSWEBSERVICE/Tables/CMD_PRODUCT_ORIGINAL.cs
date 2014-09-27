﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WMSWEBSERVICE.Tables
{
    /// <summary>
    /// 烟叶产地
    /// </summary>
    public class CMD_PRODUCT_ORIGINAL
    {
        [DBField("id", EnumDBFieldUsage.PrimaryKey, "烟叶产地ID", "VARCHAR", "12", "必传")]
        public string id { get; set; }
        [DBField("code", EnumDBFieldUsage.None, "烟叶产地代码", "VARCHAR", "6", "必传")]
        public string code { get; set; }
        [DBField("name", EnumDBFieldUsage.None, "烟叶产地名称", "VARCHAR", "50", "必传")]
        public string name { get; set; }
        [DBField("parent_id", EnumDBFieldUsage.None, "上级产地", "VARCHAR", "12", "")]
        public string parent_id { get; set; }
        [DBField("pricelevel", EnumDBFieldUsage.None, "价区", "VARCHAR", "15", "")]
        public string pricelevel { get; set; }
        [DBField("status", EnumDBFieldUsage.None, "状态", "VARCHAR", "2", "必传")]
        public string status { get; set; }
        [DBField("creator", EnumDBFieldUsage.None, "创建人", "VARCHAR", "30", "")]
        public string creator { get; set; }
        [DBField("createtime", EnumDBFieldUsage.None, "创建日期", "TIMESTAMP", "19", "")]
        public string createtime { get; set; }
        [DBField("modifier", EnumDBFieldUsage.None, "修改者", "VARCHAR", "30", "")]
        public string modifier { get; set; }
        [DBField("modifytime", EnumDBFieldUsage.None, "修改日期", "TIMESTAMP", "19", "")]
        public string modifytime { get; set; }
    }
}