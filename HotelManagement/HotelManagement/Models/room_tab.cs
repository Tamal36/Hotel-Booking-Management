//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class room_tab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public room_tab()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public int adminID { get; set; }
        public string room_type { get; set; }
        public int rate { get; set; }
        public int total_room { get; set; }
        public Nullable<int> booked_room { get; set; }
        public Nullable<int> vacant_room { get; set; }
    
        public virtual AdminPanel AdminPanel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
