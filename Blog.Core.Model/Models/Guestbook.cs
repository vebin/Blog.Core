using SqlSugar;
using System;

namespace Blog.Core.Model.Models
{
    public class Guestbook : RootEntity<int>
    {

        /// <summary>
        /// 
        /// </summary>
        public int? blogId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime createdate { get; set; }

        [SugarColumn(ColumnDataType = "nvarchar", Length = 2000, IsNullable = true)]
        public string username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar", Length = 2000, IsNullable = true)]
        public string phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar", Length = 2000, IsNullable = true)]
        public string QQ { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar", Length = 2000, IsNullable = true)]
        public string body { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar", Length = 2000, IsNullable = true)]
        public string ip { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool isshow { get; set; }

        [SugarColumn(IsIgnore = true)]
        public BlogArticle blogarticle { get; set; }
    }
}
