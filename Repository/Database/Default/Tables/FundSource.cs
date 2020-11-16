﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("Fund_Source")]
    public partial class FundSource
    {
        /// <summary>
        /// Nguồn tiền như salon, mỹ phẩm, đào tạo...
        /// </summary>
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? Publish { get; set; }
        public bool? IsDelete { get; set; }
        /// <summary>
        /// Đánh dấu,&apos;salon&apos; | kiểu nguồn là salon
        /// </summary>
        [StringLength(50)]
        public string Hint { get; set; }
        /// <summary>
        /// Giá trị đi kèm cùng Hint
        /// </summary>
        [StringLength(50)]
        public string Key { get; set; }
        public int? Order { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}