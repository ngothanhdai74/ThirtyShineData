﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class ServiceTemp
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public bool IsExfoliate { get; set; }
        public bool IsMasked { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}