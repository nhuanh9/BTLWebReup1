//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhap()
        {
            this.ChiTietHDNs = new HashSet<ChiTietHDN>();
        }
    
        public string SoHDN { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
