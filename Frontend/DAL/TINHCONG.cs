//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TINHCONG
    {
        public int MATC { get; set; }
        public System.DateTime NGAY { get; set; }
        public System.TimeSpan GIOVAO { get; set; }
        public System.TimeSpan GIORA { get; set; }
        public int MANV { get; set; }
        public int MALC { get; set; }
    
        public virtual LOAICONG LOAICONG { get; set; }
        public virtual NHANSU NHANSU { get; set; }
    }
}
