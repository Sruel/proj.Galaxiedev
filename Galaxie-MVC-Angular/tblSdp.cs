//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galaxie_MVC_Angular
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSdp
    {
        public tblSdp()
        {
            this.tblItem = new HashSet<tblItem>();
        }
    
        public int SdpID { get; set; }
        public string SdpCode { get; set; }
        public string SdpDescription1 { get; set; }
        public string SdpDescription2 { get; set; }
        public string SdpDescription3 { get; set; }
        public string SdpDptCode { get; set; }
        public int TaxGrpCode { get; set; }
    
        public virtual ICollection<tblItem> tblItem { get; set; }
    }
}