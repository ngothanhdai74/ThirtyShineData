﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Database.Default.Tables
{
    [Table("lock_block", Schema = "dba")]
    public partial class LockBlock
    {
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("BlockedSessionID")]
        public short BlockedSessionId { get; set; }
        [Column("BlockingSessionID")]
        public short BlockingSessionId { get; set; }
        [Column("BlockedSession_TSQL")]
        public string BlockedSessionTsql { get; set; }
        [Column("BlockingSession_TSQL")]
        public string BlockingSessionTsql { get; set; }
        [Column("BlockedSession_SQLHandle")]
        [MaxLength(64)]
        public byte[] BlockedSessionSqlhandle { get; set; }
        [Column("BlockingSession_SQLHandle")]
        [MaxLength(64)]
        public byte[] BlockingSessionSqlhandle { get; set; }
        [Required]
        [Column("BlockingSession_LoginName")]
        [StringLength(128)]
        public string BlockingSessionLoginName { get; set; }
        [Column("BlockingSession_ApplicationName")]
        [StringLength(128)]
        public string BlockingSessionApplicationName { get; set; }
        [Column("BlockingSession_HostName")]
        [StringLength(128)]
        public string BlockingSessionHostName { get; set; }
    }
}