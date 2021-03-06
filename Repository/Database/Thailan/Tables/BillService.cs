﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Thailan.Tables
{
    public partial class BillService
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string CustomerCode { get; set; }
        [Column("Staff_Hairdresser_Id")]
        public int? StaffHairdresserId { get; set; }
        public int? ServiceId { get; set; }
        public string ProductIds { get; set; }
        public int? TotalMoney { get; set; }
        public byte? Vote { get; set; }
        public DateTime? CreatedDate { get; set; }
        [Column("Staff_HairMassage_Id")]
        public int? StaffHairMassageId { get; set; }
        [Column("Staff_MakeBill")]
        public int? StaffMakeBill { get; set; }
        [Column(TypeName = "ntext")]
        public string Note { get; set; }
        public int? Mark { get; set; }
        public byte? IsDelete { get; set; }
        public string ServiceIds { get; set; }
        [StringLength(600)]
        public string Images { get; set; }
        [StringLength(600)]
        public string ImagesRating { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SalonId { get; set; }
        public int? SellerId { get; set; }
        public bool? CustomerNoInfo { get; set; }
        public byte? Pending { get; set; }
        [StringLength(20)]
        public string BillCode { get; set; }
        [Column("PDFBillCode")]
        [StringLength(30)]
        public string PdfbillCode { get; set; }
        public bool? ServiceError { get; set; }
        public bool? IsCusFamiliar { get; set; }
        public int? TimesUsedService { get; set; }
        public int? TeamId { get; set; }
        public bool? IsBooking { get; set; }
        public bool? IsBooked { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AppointmentTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShampooTime0 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ShampooTime1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HairCutTime0 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? HairCutTime1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinishTime { get; set; }
        public byte? Status { get; set; }
        public int? ReceptionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompleteBillTime { get; set; }
        [StringLength(50)]
        public string CustomerCode1 { get; set; }
        public int? CustomerId { get; set; }
        [Column("VIPCard")]
        public bool? Vipcard { get; set; }
        [Column("VIPCardGive")]
        [StringLength(10)]
        public string VipcardGive { get; set; }
        [Column("VIPCardUse")]
        [StringLength(10)]
        public string VipcardUse { get; set; }
        public bool? IsOnline { get; set; }
        public int? PayMethodId { get; set; }
        public bool? Paid { get; set; }
        public int? BillStatusId { get; set; }
        /// <summary>
        /// Phí COD (trả cho đối tác vận chuyển) - Bán hàng online
        /// </summary>
        [Column("FeeCOD")]
        public int? FeeCod { get; set; }
        /// <summary>
        /// Phí thu thêm (Áp dụng cho bán hàng online, có thể là tiền vận chuyển)
        /// </summary>
        public int? FeeExtra { get; set; }
        public bool? IsPayByCard { get; set; }
        public bool? IsX2 { get; set; }
        /// <summary>
        /// Mốc thời gian khách bắt đầu bước vào quy trình gội, cắt (Tính từ khi skinner gội đầu và nhập mã nhân viên trên app Staff 30S)
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? InProcedureTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InProcedureTimeModifed { get; set; }
        public int? BookingId { get; set; }
        [StringLength(100)]
        public string ImageStatusId { get; set; }
        [StringLength(600)]
        public string ImageChecked1 { get; set; }
        [StringLength(600)]
        public string ImageChecked2 { get; set; }
        [StringLength(600)]
        public string ImageChecked3 { get; set; }
        [StringLength(600)]
        public string ImageChecked4 { get; set; }
        [StringLength(600)]
        public string ErrorNote { get; set; }
        [Column("HCItem")]
        [StringLength(50)]
        public string Hcitem { get; set; }
        [StringLength(600)]
        public string NoteByStylist { get; set; }
        public int? EstimateTimeCut { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UploadImageTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EstimateTimeCutTime { get; set; }
        /// <summary>
        /// Xác nhận làm hóa chất
        /// </summary>
        public bool? IsSulphite { get; set; }
        public int? CheckoutId { get; set; }
        public Guid? Uid { get; set; }
        public byte? MigrateStatus { get; set; }
        public int? CustomerUsedNumber { get; set; }
        [StringLength(600)]
        public string QueueCheckoutInfo { get; set; }
        public int? SecurityId { get; set; }
        public int CustomerConfirm { get; set; }
        public bool? IsImages { get; set; }
        public int? MoneyPrePaid { get; set; }
        public int? MoneyDeductions { get; set; }
        public int? MoneyInBill { get; set; }
        public bool? IsWrongImage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StylistStartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StylistEndTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndProcedureTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StylistConfirmServeTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SkinnerConfirmServeTime { get; set; }
    }
}