﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    [Table("DCustomerSMS")]
    public partial class DcustomerSms
    {
        [Key]
        [Column("IdCustomerSMS")]
        public int IdCustomerSms { get; set; }
        public int CustomerId { get; set; }
        [Column("DateTimeSMS", TypeName = "datetime")]
        public DateTime? DateTimeSms { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeSend { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTimeReceived { get; set; }
        [Column("TypeOfSMSId")]
        public int? TypeOfSmsid { get; set; }
        [Column("DeviceIMEI")]
        [StringLength(200)]
        public string DeviceImei { get; set; }
        public int? SalonId { get; set; }
        public int? DepartmentId { get; set; }
        public int? StaffId { get; set; }
        [Column("SMSId")]
        public int Smsid { get; set; }
        public int? BookingId { get; set; }
    }
}