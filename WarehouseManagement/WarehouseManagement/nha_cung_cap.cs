//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarehouseManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class nha_cung_cap
    {
        public nha_cung_cap()
        {
            this.hang_hoa = new HashSet<hang_hoa>();
        }
    
        public int ma_nha_cung_cap { get; set; }
        public string ten_nha_cung_cap { get; set; }
        public string dia_chi { get; set; }
        public string so_dien_thoai { get; set; }
    
        public virtual ICollection<hang_hoa> hang_hoa { get; set; }
    }
}