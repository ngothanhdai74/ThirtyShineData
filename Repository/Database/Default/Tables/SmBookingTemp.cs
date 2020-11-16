﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("SM_BookingTemp")]
    public partial class SmBookingTemp
    {
        [Key]
        public int Id { get; set; }
        [StringLength(200)]
        public string CustomerName { get; set; }
        [StringLength(20)]
        public string CustomerPhone { get; set; }
        public int? HourId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public byte? IsDelete { get; set; }
        public int? SalonId { get; set; }
        public int? StylistId { get; set; }
        public int? UserId { get; set; }
        public string Note { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DatedBook { get; set; }
        public bool? IsMakeBill { get; set; }
        public int? FlowTimeKeepingId { get; set; }
        [Column("IsSMS")]
        public bool? IsSms { get; set; }
        [Column("SMSStatus")]
        public int? Smsstatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SendDate { get; set; }
        /// <summary>
        /// Nguồn booking : 1|Web, 2|Android, 3|iOS
        /// </summary>
        [Column("OS")]
        public int? Os { get; set; }
        public bool? NewCustomer { get; set; }
        [StringLength(300)]
        public string NoteDelete { get; set; }
        public bool? IsCall { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IsCallTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? IsCallTimeModified { get; set; }
        public bool? IsBookViaBill { get; set; }
        public bool? IsBookAtSalon { get; set; }
        public bool? IsAutoStylist { get; set; }
        [StringLength(100)]
        public string TokenClient { get; set; }
        [Column("MACAddress")]
        [StringLength(100)]
        public string Macaddress { get; set; }
        public bool? IsLimited { get; set; }
        public bool? IsSetAutoStylist { get; set; }
        public bool? IsBookOnline { get; set; }
        public bool? IsBookStylist { get; set; }
        public int? Order { get; set; }
        [Column("AuthOTP_IsSet")]
        public bool? AuthOtpIsSet { get; set; }
        [Column("AuthOTP_IsVerified")]
        public bool? AuthOtpIsVerified { get; set; }
        [Column("AuthOTP_Token")]
        [StringLength(8)]
        public string AuthOtpToken { get; set; }
        [Column("AuthOTP_TimeSend", TypeName = "datetime")]
        public DateTime? AuthOtpTimeSend { get; set; }
        [Column("AuthOTP_TimeVerified", TypeName = "datetime")]
        public DateTime? AuthOtpTimeVerified { get; set; }
        [Column("AuthOTP_SMSStatus")]
        public byte? AuthOtpSmsstatus { get; set; }
        [Column("AuthOTP_TimeReceived", TypeName = "datetime")]
        public DateTime? AuthOtpTimeReceived { get; set; }
        public int? TheadId { get; set; }
        [StringLength(50)]
        public string Version { get; set; }
        /// <summary>
        /// Salon gợi ý khách đến salon hiện tại được book
        /// </summary>
        [Column("SuggestSalonID")]
        public int? SuggestSalonId { get; set; }
        [Column("SMSNoti_IsSend")]
        public bool? SmsnotiIsSend { get; set; }
        [Column("SMSNoti_SendTime", TypeName = "datetime")]
        public DateTime? SmsnotiSendTime { get; set; }
        [Column("SMSNoti_Status")]
        public int? SmsnotiStatus { get; set; }
        [Column("CancelBook_IsSendSMS")]
        public bool? CancelBookIsSendSms { get; set; }
        [Column("CancelBook_TimeSend", TypeName = "datetime")]
        public DateTime? CancelBookTimeSend { get; set; }
        [Column("CancelBook_SMSStatus")]
        public byte? CancelBookSmsstatus { get; set; }
        [Column("CancelBook_From")]
        public byte? CancelBookFrom { get; set; }
        /// <summary>
        /// Ghi chú của Khách hàng khi book lịch
        /// </summary>
        [StringLength(450)]
        public string TextNote1 { get; set; }
        /// <summary>
        /// Ghi chú của Khách hàng khi book lịch (Khách update trên trang cảm ơn)
        /// </summary>
        [StringLength(450)]
        public string TextNote2 { get; set; }
        [StringLength(300)]
        public string SalonNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeSalonNote { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public double CustomerScore { get; set; }
        public int? SubHour { get; set; }
        public int? CustomerId { get; set; }
        public int? SecondSubHour { get; set; }
    }
}