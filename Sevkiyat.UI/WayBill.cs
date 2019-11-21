//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sevkiyat.UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class WayBill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WayBill()
        {
            this.WayBillDetails = new HashSet<WayBillDetail>();
        }
    
        public System.Guid ID { get; set; }
        public System.Guid DriverID { get; set; }
        public System.Guid VehicleID { get; set; }
        public System.Guid SenderID { get; set; }
        public System.Guid ReceiverID { get; set; }
        public System.DateTime ShipmentDate { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public byte BillType { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid CreatedUserID { get; set; }
    
        public virtual Driver Driver { get; set; }
        public virtual Payer Payer { get; set; }
        public virtual Payer Payer1 { get; set; }
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WayBillDetail> WayBillDetails { get; set; }
    }
}
