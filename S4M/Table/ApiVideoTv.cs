﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class ApiVideoTv
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumb { get; set; }
        public long? ViewCount { get; set; }
        public long? CommentCount { get; set; }
        public long? DislikeCount { get; set; }
        public long? LikeCount { get; set; }
        public bool? IsDelete { get; set; }
        public bool? Status { get; set; }
        public DateTime? DateCreate { get; set; }
        public DateTime? DateChanged { get; set; }
        public DateTime? PublishDate { get; set; }
        public string VideoId { get; set; }
        public string Chanel { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}