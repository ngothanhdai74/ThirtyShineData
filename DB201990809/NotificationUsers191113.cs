﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class NotificationUsers191113
    {
        public int Id { get; set; }
        public int? NotiId { get; set; }
        public int? UserId { get; set; }
        public string SlugKey { get; set; }
        public int? Status { get; set; }
        public bool IsPublish { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}