﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class SurveyMapQa
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Publish { get; set; }
        public int? Order { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}