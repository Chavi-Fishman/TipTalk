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
    
    public partial class CardMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CardMaster()
        {
            this.MasterShift = new HashSet<MasterShift>();
        }
    
        public int cardMasterId { get; set; }
        public int userId { get; set; }
        public int categoryId { get; set; }
        public Nullable<double> priceMeeting { get; set; }
        public Nullable<int> minutesMeeting { get; set; }
        public bool status { get; set; }
        public Nullable<double> priceToExtraTime { get; set; }
        public Nullable<double> numStars { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterShift> MasterShift { get; set; }
    }
}
