using SqlSugar;
using System;

namespace Blog.Core.Model
{
    public class RootEntity<TKey> where TKey : IEquatable<TKey>
    {
        /// <summary>
        /// ID
        /// </summary>
        [SugarColumn(IsNullable = false, IsPrimaryKey = true)]
        public TKey Id { get; set; }
    }
}