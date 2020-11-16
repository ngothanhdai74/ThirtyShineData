﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class SocialThread
    {
        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        [Column(TypeName = "ntext")]
        public string Description { get; set; }
        public byte? Publish { get; set; }
        public DateTime? CreatedDate { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Kiểu nguồn thông tin : 1|Nguồn thông tin biết đến cửa hàng, 2|Nguồn thông tin khảo sát nhân viên
        /// </summary>
        [Column("stType")]
        public int? StType { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}