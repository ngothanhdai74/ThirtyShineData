﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class CheckProductFreeze
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? SoTon { get; set; }
        public int? Freeze { get; set; }
        public int? QlclInput { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public DateTime? Createdate { get; set; }
        public int? UserId { get; set; }
        public int? StaffId { get; set; }
        public string ProductName { get; set; }
        public int? Price { get; set; }
        public DateTime? CheckCreateDate { get; set; }
        public string MaSp { get; set; }
        public string LyDo { get; set; }
        public int InventoryCurrentId { get; set; }
        public int? NumEndBeforeProcess { get; set; }
    }
}