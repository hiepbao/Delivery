
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Delivery.Models
{

using System;
    using System.Collections.Generic;
    
public partial class KhuVuc
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public KhuVuc()
    {

        this.NhanViens = new HashSet<NhanVien>();

    }


    public int MaKhuVuc { get; set; }

    public string TenKhuVuc { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<NhanVien> NhanViens { get; set; }

}

}
