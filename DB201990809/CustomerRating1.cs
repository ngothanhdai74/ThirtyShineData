﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class CustomerRating1
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        public int CustomerId { get; set; }
        public int RatingTypeId { get; set; }
        public int RatingConfigPointId { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiredTime { get; set; }
    }
}