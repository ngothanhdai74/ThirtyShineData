﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class CustomerAppRating
    {
        public int CustomerId { get; set; }
        public int BillId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Rating { get; set; }
        public int? SalonId { get; set; }
        public string Services { get; set; }
        public string Products { get; set; }
        public string CustomerPhone { get; set; }
        public string Departments { get; set; }
        public string Note { get; set; }
        public int? CorrectPrice { get; set; }
    }
}