
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
    public interface postPrototype
    {
        postPrototype Clone();
    }
    public partial class NhanVien : postPrototype
    {

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NhanVien()
    {

        this.DonHangs = new HashSet<DonHang>();

        this.DonHangs1 = new HashSet<DonHang>();

        this.DonHangs2 = new HashSet<DonHang>();

    }


    public int MaNhanVien { get; set; }

    public string TenNhanVien { get; set; }

    public Nullable<System.DateTime> NgaySinh { get; set; }

    public string Email { get; set; }

    public string SoDienThoai { get; set; }

    public Nullable<bool> TrangThai { get; set; }

    public Nullable<int> MaKhuVuc { get; set; }

    public string TenTaiKhoan { get; set; }

    public string MatKhau { get; set; }

    public Nullable<int> LoaiTaiKhoan { get; set; }

    public byte[] ImageData { get; set; }

    public string ImageExtension { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DonHang> DonHangs { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DonHang> DonHangs1 { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DonHang> DonHangs2 { get; set; }

    public virtual KhuVuc KhuVuc { get; set; }

    public virtual LoaiTaiKhoan LoaiTaiKhoan1 { get; set; }


        public postPrototype Clone()
        {
            NhanVien clonedAccount = new NhanVien();

            clonedAccount.TenNhanVien = this.TenNhanVien;
            clonedAccount.NgaySinh = this.NgaySinh;
            clonedAccount.Email = this.Email;
            clonedAccount.SoDienThoai = this.SoDienThoai;
            clonedAccount.TrangThai = this.TrangThai;
            clonedAccount.MaKhuVuc = this.MaKhuVuc;
            clonedAccount.TenTaiKhoan = this.TenTaiKhoan;
            clonedAccount.MatKhau = this.MatKhau;
            clonedAccount.LoaiTaiKhoan = this.LoaiTaiKhoan;
            clonedAccount.ImageData = this.ImageData;
            clonedAccount.ImageExtension = this.ImageExtension;

            return clonedAccount;
        }

    }

}
