﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class GiaoHangEntities : DbContext
{
    public GiaoHangEntities()
        : base("name=GiaoHangEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<ChucNang> ChucNangs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<KhuVuc> KhuVucs { get; set; }

    public virtual DbSet<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }


    public virtual ObjectResult<DonHang__Table_NhanDon_Result> DonHang__Table_NhanDon()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DonHang__Table_NhanDon_Result>("DonHang__Table_NhanDon");
    }


    public virtual ObjectResult<DonHang_Find_detail_Result> DonHang_Find_detail(Nullable<int> maDonHang)
    {

        var maDonHangParameter = maDonHang.HasValue ?
            new ObjectParameter("MaDonHang", maDonHang) :
            new ObjectParameter("MaDonHang", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DonHang_Find_detail_Result>("DonHang_Find_detail", maDonHangParameter);
    }


    public virtual ObjectResult<DonHang_GetChuaNhan_Result> DonHang_GetChuaNhan()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DonHang_GetChuaNhan_Result>("DonHang_GetChuaNhan");
    }


    public virtual ObjectResult<DonHang_GetListDonHang_Result> DonHang_GetListDonHang(Nullable<int> maTrangThai)
    {

        var maTrangThaiParameter = maTrangThai.HasValue ?
            new ObjectParameter("MaTrangThai", maTrangThai) :
            new ObjectParameter("MaTrangThai", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DonHang_GetListDonHang_Result>("DonHang_GetListDonHang", maTrangThaiParameter);
    }


    public virtual int DonHang_PhanPhoi(Nullable<int> maDonHang, Nullable<int> nhanVienPhanPhoi, Nullable<int> nhanVienGiao)
    {

        var maDonHangParameter = maDonHang.HasValue ?
            new ObjectParameter("MaDonHang", maDonHang) :
            new ObjectParameter("MaDonHang", typeof(int));


        var nhanVienPhanPhoiParameter = nhanVienPhanPhoi.HasValue ?
            new ObjectParameter("NhanVienPhanPhoi", nhanVienPhanPhoi) :
            new ObjectParameter("NhanVienPhanPhoi", typeof(int));


        var nhanVienGiaoParameter = nhanVienGiao.HasValue ?
            new ObjectParameter("NhanVienGiao", nhanVienGiao) :
            new ObjectParameter("NhanVienGiao", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DonHang_PhanPhoi", maDonHangParameter, nhanVienPhanPhoiParameter, nhanVienGiaoParameter);
    }


    public virtual ObjectResult<DonHang_PhanPhoiSelectList_KhuVuc_NhanVien_Result> DonHang_PhanPhoiSelectList_KhuVuc_NhanVien(string diaChiQuan)
    {

        var diaChiQuanParameter = diaChiQuan != null ?
            new ObjectParameter("DiaChiQuan", diaChiQuan) :
            new ObjectParameter("DiaChiQuan", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DonHang_PhanPhoiSelectList_KhuVuc_NhanVien_Result>("DonHang_PhanPhoiSelectList_KhuVuc_NhanVien", diaChiQuanParameter);
    }


    public virtual ObjectResult<DonHang_TimKiemTheoTenNG_Result> DonHang_TimKiemTheoTenNG(string tenNguoiGui)
    {

        var tenNguoiGuiParameter = tenNguoiGui != null ?
            new ObjectParameter("TenNguoiGui", tenNguoiGui) :
            new ObjectParameter("TenNguoiGui", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DonHang_TimKiemTheoTenNG_Result>("DonHang_TimKiemTheoTenNG", tenNguoiGuiParameter);
    }


    public virtual ObjectResult<GetByYear_Result> GetByYear(Nullable<int> year)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetByYear_Result>("GetByYear", yearParameter);
    }


    public virtual ObjectResult<MenuOf_Result> MenuOf(Nullable<int> maNhanVien)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MenuOf_Result>("MenuOf", maNhanVienParameter);
    }


    public virtual ObjectResult<NhanVien_ChuaTK_Result> NhanVien_ChuaTK()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_ChuaTK_Result>("NhanVien_ChuaTK");
    }


    public virtual ObjectResult<NhanVien_DanhSach_Result> NhanVien_DanhSach()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_DanhSach_Result>("NhanVien_DanhSach");
    }


    public virtual ObjectResult<NhanVien_KhuVuc_Result> NhanVien_KhuVuc()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_KhuVuc_Result>("NhanVien_KhuVuc");
    }


    public virtual ObjectResult<NhanVien_LoaiTK_Result> NhanVien_LoaiTK()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_LoaiTK_Result>("NhanVien_LoaiTK");
    }


    public virtual ObjectResult<Nullable<int>> NhanVien_Xoa(Nullable<int> maNhanVien)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("NhanVien_Xoa", maNhanVienParameter);
    }


    public virtual ObjectResult<sp_Shiper_Don_Hang_Can_Giao_Result> sp_Shiper_Don_Hang_Can_Giao(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Shiper_Don_Hang_Can_Giao_Result>("sp_Shiper_Don_Hang_Can_Giao", idParameter);
    }


    public virtual ObjectResult<sp_Shiper_Thong_Tin_Don_Hang_Result> sp_Shiper_Thong_Tin_Don_Hang(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("id", id) :
            new ObjectParameter("id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Shiper_Thong_Tin_Don_Hang_Result>("sp_Shiper_Thong_Tin_Don_Hang", idParameter);
    }


    public virtual ObjectResult<Nullable<int>> sp_Xac_Nhan_Da_Giao_Hang(Nullable<int> idDonHang)
    {

        var idDonHangParameter = idDonHang.HasValue ?
            new ObjectParameter("idDonHang", idDonHang) :
            new ObjectParameter("idDonHang", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Xac_Nhan_Da_Giao_Hang", idDonHangParameter);
    }


    public virtual ObjectResult<Nullable<int>> sp_Xac_Nhan_Da_Lay_Hang(Nullable<int> idDonHang)
    {

        var idDonHangParameter = idDonHang.HasValue ?
            new ObjectParameter("idDonHang", idDonHang) :
            new ObjectParameter("idDonHang", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Xac_Nhan_Da_Lay_Hang", idDonHangParameter);
    }


    public virtual ObjectResult<Nullable<int>> sp_Xac_Nhan_Dang_Giao_Hang(Nullable<int> idDonHang)
    {

        var idDonHangParameter = idDonHang.HasValue ?
            new ObjectParameter("idDonHang", idDonHang) :
            new ObjectParameter("idDonHang", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Xac_Nhan_Dang_Giao_Hang", idDonHangParameter);
    }


    public virtual int TaiKhoan_ChiTiet(Nullable<int> manv)
    {

        var manvParameter = manv.HasValue ?
            new ObjectParameter("manv", manv) :
            new ObjectParameter("manv", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TaiKhoan_ChiTiet", manvParameter);
    }


    public virtual ObjectResult<TaiKhoan_DangNhap_Shiper_Result> TaiKhoan_DangNhap_Shiper(string tenTaiKhoan, string matKhau)
    {

        var tenTaiKhoanParameter = tenTaiKhoan != null ?
            new ObjectParameter("TenTaiKhoan", tenTaiKhoan) :
            new ObjectParameter("TenTaiKhoan", typeof(string));


        var matKhauParameter = matKhau != null ?
            new ObjectParameter("MatKhau", matKhau) :
            new ObjectParameter("MatKhau", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaiKhoan_DangNhap_Shiper_Result>("TaiKhoan_DangNhap_Shiper", tenTaiKhoanParameter, matKhauParameter);
    }


    public virtual ObjectResult<TaiKhoan_DanhSach_Result> TaiKhoan_DanhSach()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaiKhoan_DanhSach_Result>("TaiKhoan_DanhSach");
    }


    public virtual ObjectResult<Nullable<int>> TaiKhoan_DoiMK(Nullable<int> maNhanVien, string matKhau)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        var matKhauParameter = matKhau != null ?
            new ObjectParameter("MatKhau", matKhau) :
            new ObjectParameter("MatKhau", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TaiKhoan_DoiMK", maNhanVienParameter, matKhauParameter);
    }


    public virtual ObjectResult<string> TaiKhoan_LayTen(Nullable<int> manv)
    {

        var manvParameter = manv.HasValue ?
            new ObjectParameter("manv", manv) :
            new ObjectParameter("manv", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TaiKhoan_LayTen", manvParameter);
    }


    public virtual int TaiKhoan_Profile(Nullable<int> maNhanVien)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TaiKhoan_Profile", maNhanVienParameter);
    }


    public virtual int TaiKhoan_ResetPass(Nullable<int> manv)
    {

        var manvParameter = manv.HasValue ?
            new ObjectParameter("manv", manv) :
            new ObjectParameter("manv", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TaiKhoan_ResetPass", manvParameter);
    }


    public virtual ObjectResult<string> TaiKhoan_Them(string username, string password, Nullable<int> maNV, Nullable<int> lTK)
    {

        var usernameParameter = username != null ?
            new ObjectParameter("Username", username) :
            new ObjectParameter("Username", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(string));


        var maNVParameter = maNV.HasValue ?
            new ObjectParameter("MaNV", maNV) :
            new ObjectParameter("MaNV", typeof(int));


        var lTKParameter = lTK.HasValue ?
            new ObjectParameter("LTK", lTK) :
            new ObjectParameter("LTK", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TaiKhoan_Them", usernameParameter, passwordParameter, maNVParameter, lTKParameter);
    }


    public virtual ObjectResult<ThongKe_DaNhan_Result> ThongKe_DaNhan(Nullable<int> year, Nullable<int> month)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        var monthParameter = month.HasValue ?
            new ObjectParameter("month", month) :
            new ObjectParameter("month", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ThongKe_DaNhan_Result>("ThongKe_DaNhan", yearParameter, monthParameter);
    }


    public virtual ObjectResult<Nullable<int>> ThongKe_LayNam()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ThongKe_LayNam");
    }


    public virtual ObjectResult<Nullable<int>> ThongKe_LayThang()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ThongKe_LayThang");
    }


    public virtual ObjectResult<string> TaiKhoan_Add(string username, string password, Nullable<int> maNV, Nullable<int> lTK)
    {

        var usernameParameter = username != null ?
            new ObjectParameter("Username", username) :
            new ObjectParameter("Username", typeof(string));


        var passwordParameter = password != null ?
            new ObjectParameter("Password", password) :
            new ObjectParameter("Password", typeof(string));


        var maNVParameter = maNV.HasValue ?
            new ObjectParameter("MaNV", maNV) :
            new ObjectParameter("MaNV", typeof(int));


        var lTKParameter = lTK.HasValue ?
            new ObjectParameter("LTK", lTK) :
            new ObjectParameter("LTK", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TaiKhoan_Add", usernameParameter, passwordParameter, maNVParameter, lTKParameter);
    }


    public virtual int DonHang_XacNhanDon(Nullable<int> maDonHang, Nullable<int> maNhanVien)
    {

        var maDonHangParameter = maDonHang.HasValue ?
            new ObjectParameter("MaDonHang", maDonHang) :
            new ObjectParameter("MaDonHang", typeof(int));


        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DonHang_XacNhanDon", maDonHangParameter, maNhanVienParameter);
    }


    public virtual ObjectResult<NhanVien_ChiTiet_Result> NhanVien_ChiTiet(Nullable<int> maNhanVien)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_ChiTiet_Result>("NhanVien_ChiTiet", maNhanVienParameter);
    }


    public virtual ObjectResult<Nullable<int>> NhanVien_Sua(Nullable<int> maNhanVien, string tenNhanVien, Nullable<System.DateTime> ngaySinh, string email, string soDienThoai, Nullable<int> maKhuVuc)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        var tenNhanVienParameter = tenNhanVien != null ?
            new ObjectParameter("TenNhanVien", tenNhanVien) :
            new ObjectParameter("TenNhanVien", typeof(string));


        var ngaySinhParameter = ngaySinh.HasValue ?
            new ObjectParameter("NgaySinh", ngaySinh) :
            new ObjectParameter("NgaySinh", typeof(System.DateTime));


        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));


        var soDienThoaiParameter = soDienThoai != null ?
            new ObjectParameter("SoDienThoai", soDienThoai) :
            new ObjectParameter("SoDienThoai", typeof(string));


        var maKhuVucParameter = maKhuVuc.HasValue ?
            new ObjectParameter("MaKhuVuc", maKhuVuc) :
            new ObjectParameter("MaKhuVuc", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("NhanVien_Sua", maNhanVienParameter, tenNhanVienParameter, ngaySinhParameter, emailParameter, soDienThoaiParameter, maKhuVucParameter);
    }


    public virtual ObjectResult<Profile_Get_Result> Profile_Get(Nullable<int> id)
    {

        var idParameter = id.HasValue ?
            new ObjectParameter("Id", id) :
            new ObjectParameter("Id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Profile_Get_Result>("Profile_Get", idParameter);
    }


    public virtual ObjectResult<Nullable<int>> Profile_Sua(Nullable<int> maNhanVien, string tenNhanVien, Nullable<System.DateTime> ngaySinh, string email, string soDienThoai, byte[] imgData, string imgExt)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        var tenNhanVienParameter = tenNhanVien != null ?
            new ObjectParameter("TenNhanVien", tenNhanVien) :
            new ObjectParameter("TenNhanVien", typeof(string));


        var ngaySinhParameter = ngaySinh.HasValue ?
            new ObjectParameter("NgaySinh", ngaySinh) :
            new ObjectParameter("NgaySinh", typeof(System.DateTime));


        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));


        var soDienThoaiParameter = soDienThoai != null ?
            new ObjectParameter("SoDienThoai", soDienThoai) :
            new ObjectParameter("SoDienThoai", typeof(string));


        var imgDataParameter = imgData != null ?
            new ObjectParameter("ImgData", imgData) :
            new ObjectParameter("ImgData", typeof(byte[]));


        var imgExtParameter = imgExt != null ?
            new ObjectParameter("ImgExt", imgExt) :
            new ObjectParameter("ImgExt", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Profile_Sua", maNhanVienParameter, tenNhanVienParameter, ngaySinhParameter, emailParameter, soDienThoaiParameter, imgDataParameter, imgExtParameter);
    }


    public virtual ObjectResult<string> Account_Password(string username)
    {

        var usernameParameter = username != null ?
            new ObjectParameter("username", username) :
            new ObjectParameter("username", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Account_Password", usernameParameter);
    }


    public virtual ObjectResult<Account_Session_Result> Account_Session(string tenTaiKhoan)
    {

        var tenTaiKhoanParameter = tenTaiKhoan != null ?
            new ObjectParameter("TenTaiKhoan", tenTaiKhoan) :
            new ObjectParameter("TenTaiKhoan", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Account_Session_Result>("Account_Session", tenTaiKhoanParameter);
    }


    public virtual ObjectResult<string> Profile_Password(Nullable<int> manv)
    {

        var manvParameter = manv.HasValue ?
            new ObjectParameter("manv", manv) :
            new ObjectParameter("manv", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Profile_Password", manvParameter);
    }


    public virtual ObjectResult<NhanVien_Xoa_ChiTiet_Result> NhanVien_Xoa_ChiTiet(Nullable<int> maNhanVien)
    {

        var maNhanVienParameter = maNhanVien.HasValue ?
            new ObjectParameter("MaNhanVien", maNhanVien) :
            new ObjectParameter("MaNhanVien", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_Xoa_ChiTiet_Result>("NhanVien_Xoa_ChiTiet", maNhanVienParameter);
    }


    public virtual ObjectResult<Nullable<int>> TaiKhoan_Reset(Nullable<int> manv, string pass)
    {

        var manvParameter = manv.HasValue ?
            new ObjectParameter("manv", manv) :
            new ObjectParameter("manv", typeof(int));


        var passParameter = pass != null ?
            new ObjectParameter("pass", pass) :
            new ObjectParameter("pass", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TaiKhoan_Reset", manvParameter, passParameter);
    }


    public virtual ObjectResult<ThongKe_DaNhan1_Result> ThongKe_DaNhan1(Nullable<int> year, Nullable<int> month)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        var monthParameter = month.HasValue ?
            new ObjectParameter("month", month) :
            new ObjectParameter("month", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ThongKe_DaNhan1_Result>("ThongKe_DaNhan1", yearParameter, monthParameter);
    }


    public virtual ObjectResult<Nullable<int>> ThongKe_LayNam1()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ThongKe_LayNam1");
    }


    public virtual ObjectResult<Nullable<int>> ThongKe_LayThang1()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ThongKe_LayThang1");
    }


    public virtual ObjectResult<NhanVien_TimKiem_Result> NhanVien_TimKiem(Nullable<int> manv, string tennv, string khuvuc)
    {

        var manvParameter = manv.HasValue ?
            new ObjectParameter("manv", manv) :
            new ObjectParameter("manv", typeof(int));


        var tennvParameter = tennv != null ?
            new ObjectParameter("tennv", tennv) :
            new ObjectParameter("tennv", typeof(string));


        var khuvucParameter = khuvuc != null ?
            new ObjectParameter("khuvuc", khuvuc) :
            new ObjectParameter("khuvuc", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NhanVien_TimKiem_Result>("NhanVien_TimKiem", manvParameter, tennvParameter, khuvucParameter);
    }


    public virtual ObjectResult<TaiKhoan_TimKiem_Result> TaiKhoan_TimKiem(string tentk, string hoten, string loaitk)
    {

        var tentkParameter = tentk != null ?
            new ObjectParameter("tentk", tentk) :
            new ObjectParameter("tentk", typeof(string));


        var hotenParameter = hoten != null ?
            new ObjectParameter("hoten", hoten) :
            new ObjectParameter("hoten", typeof(string));


        var loaitkParameter = loaitk != null ?
            new ObjectParameter("loaitk", loaitk) :
            new ObjectParameter("loaitk", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TaiKhoan_TimKiem_Result>("TaiKhoan_TimKiem", tentkParameter, hotenParameter, loaitkParameter);
    }


    public virtual ObjectResult<ThongKeDonDaGiao_Result> ThongKeDonDaGiao(Nullable<int> year, Nullable<int> month)
    {

        var yearParameter = year.HasValue ?
            new ObjectParameter("year", year) :
            new ObjectParameter("year", typeof(int));


        var monthParameter = month.HasValue ?
            new ObjectParameter("month", month) :
            new ObjectParameter("month", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ThongKeDonDaGiao_Result>("ThongKeDonDaGiao", yearParameter, monthParameter);
    }


    public virtual ObjectResult<Nullable<int>> ThongKeDonDaGiao_LayNam()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ThongKeDonDaGiao_LayNam");
    }


    public virtual ObjectResult<Nullable<int>> ThongKeDonDaGiao_LayThang()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ThongKeDonDaGiao_LayThang");
    }


    public virtual ObjectResult<string> NhanVien_Add(string tenNhanVien, Nullable<System.DateTime> ngaySinh, string email, string sdt, Nullable<int> maKhuVuc)
    {

        var tenNhanVienParameter = tenNhanVien != null ?
            new ObjectParameter("TenNhanVien", tenNhanVien) :
            new ObjectParameter("TenNhanVien", typeof(string));


        var ngaySinhParameter = ngaySinh.HasValue ?
            new ObjectParameter("NgaySinh", ngaySinh) :
            new ObjectParameter("NgaySinh", typeof(System.DateTime));


        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));


        var sdtParameter = sdt != null ?
            new ObjectParameter("Sdt", sdt) :
            new ObjectParameter("Sdt", typeof(string));


        var maKhuVucParameter = maKhuVuc.HasValue ?
            new ObjectParameter("MaKhuVuc", maKhuVuc) :
            new ObjectParameter("MaKhuVuc", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("NhanVien_Add", tenNhanVienParameter, ngaySinhParameter, emailParameter, sdtParameter, maKhuVucParameter);
    }


    public virtual ObjectResult<string> TaiKhoan_RSPass(string tentk, string pass)
    {

        var tentkParameter = tentk != null ?
            new ObjectParameter("tentk", tentk) :
            new ObjectParameter("tentk", typeof(string));


        var passParameter = pass != null ?
            new ObjectParameter("pass", pass) :
            new ObjectParameter("pass", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("TaiKhoan_RSPass", tentkParameter, passParameter);
    }

}

}

