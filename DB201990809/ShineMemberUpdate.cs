﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace DB201990809
{
    public partial class ShineMemberUpdate
    {
        public int Id { get; set; }
        public int? OldCustomerId { get; set; }
        public string OldCustomerPhone { get; set; }
        public int? NewCustomerId { get; set; }
        public string NewCustomerPhone { get; set; }
        public int? UserUpdate { get; set; }
        public string NoteUpdate { get; set; }
        public int? Confirm { get; set; }
        public int? ReasonId { get; set; }
        public string TelesaleNote { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsDelete { get; set; }
        public int? BillId { get; set; }
        public int? Status { get; set; }
        public DateTime? TimeConfirm { get; set; }
        public DateTime? TimeChange { get; set; }
        public int? UserConfirm { get; set; }
        public int? UserUpdateChange { get; set; }
    }
}