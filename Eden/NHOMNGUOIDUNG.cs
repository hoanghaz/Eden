//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eden
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHOMNGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHOMNGUOIDUNG()
        {
            this.NGUOIDUNGs = new HashSet<NGUOIDUNG>();
            this.CHUCNANGs = new HashSet<CHUCNANG>();
        }
    
        public int id { get; set; }
        public string MaNhomNguoiDung { get; set; }
        public string TenNhomNguoiDung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUOIDUNG> NGUOIDUNGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUCNANG> CHUCNANGs { get; set; }
    }
}
