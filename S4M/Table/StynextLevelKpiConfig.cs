﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace S4M.Table
{
    public partial class StynextLevelKpiConfig
    {
        public int Id { get; set; }
        public int LevelId { get; set; }
        public int KpiId { get; set; }
        public string KpiName { get; set; }
        public double PointTopLevel { get; set; }
        public double PointBottomLevel { get; set; }
        public double BonusPercent { get; set; }
        public double GroupBonuspercent { get; set; }
    }
}