﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("Staff_Salon_History")]
    public partial class StaffSalonHistory
    {
        [Key]
        public int Id { get; set; }
        public int StaffId { get; set; }
        public int OlderSalonId { get; set; }
        public int CurrentSalonId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDate { get; set; }
        public bool? IsDelete { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
    }
}