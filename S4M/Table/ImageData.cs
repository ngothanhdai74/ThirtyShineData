﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class ImageData
    {
        public int Id { get; set; }
        public int? Objid { get; set; }
        public string Images { get; set; }
        public string ImageBefore { get; set; }
        public string ImageAfter { get; set; }
        public string ImageCheckBefore { get; set; }
        public string ImageCheckAfter { get; set; }
        public string Slugkey { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsAuto { get; set; }
        public string BeforeMassageImage { get; set; }
        public string ChemicalUseCard { get; set; }
        public int CustomerRejectTakeImage { get; set; }
        public int RejectTakeImageCurlingBefore { get; set; }
        public int RejectTakeImageCurlingAfter { get; set; }
        public string CheckinVideoUrl { get; set; }
        public string CheckoutVideoUrl { get; set; }
    }
}