﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class GamificationQuest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public int Type { get; set; }
        public int Point { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int? GradeId { get; set; }
        public bool IsDelete { get; set; }
        public int? Loop { get; set; }
    }
}