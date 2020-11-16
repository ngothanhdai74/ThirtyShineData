﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    public partial class CustomerHairAttribute
    {
        [Key]
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        [StringLength(50)]
        public string ChatToc { get; set; }
        [StringLength(50)]
        public string DoCung { get; set; }
        [StringLength(50)]
        public string KhuonMat { get; set; }
        [StringLength(50)]
        public string DangCam { get; set; }
        [StringLength(50)]
        public string AnMac { get; set; }
        [StringLength(50)]
        public string ThoiQuenVuotSap { get; set; }
        [StringLength(50)]
        public string ThoiQuenSay { get; set; }
        [StringLength(50)]
        public string NgheNghiep { get; set; }
        [StringLength(50)]
        public string GhiChuKhac { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public int? BillServiceId { get; set; }
        public int? SessionId { get; set; }
        [StringLength(1000)]
        public string Note { get; set; }
    }
}