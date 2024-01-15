using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using Delivery.Models;
using Delivery.Pattern;
using Delivery.Pattern.CommandPattern;

namespace Delivery.Controllers
{
    public class TaiKhoanController : BaseController
    {
        private GiaoHangEntities db = new GiaoHangEntities();
        private IProxy proxy;
        private Invoker invoker = new Invoker();

        // GET: TaiKhoan

        public ActionResult Index(string tenTK, string hoten, string loaiTK)
        {
            if (!String.IsNullOrEmpty(tenTK))
            {
                var listTKSearch = db.TaiKhoan_TimKiem(tenTK, null, null);
                return View(listTKSearch.ToList());
            }
            else if (!String.IsNullOrEmpty(hoten))
            {
                var listTKSearch = db.TaiKhoan_TimKiem(null, hoten, null);
                return View(listTKSearch.ToList());
            }
            else if (!String.IsNullOrEmpty(loaiTK))
            {
                var listTKSearch = db.TaiKhoan_TimKiem(null, null, loaiTK);
                return View(listTKSearch.ToList());
            }

            var ListTK = db.TaiKhoan_TimKiem(null, null, null);
            ShowRouterInfo();
            return View(ListTK.ToList());
        }

        // GET: TaiKhoan/Create
        public ActionResult Create()
        {
            ViewBag.LoaiTaiKhoan = new SelectList(db.NhanVien_LoaiTK(), "MaLoaiTaiKhoan", "LoaiTaiKhoan");
            ViewBag.MaNhanVien = new SelectList(db.NhanVien_ChuaTK(), "MaNhanVien", "TenNhanVien");

            ShowRouterInfo();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhanVien,LoaiTaiKhoan,TenTaiKhoan,MatKhau")] NhanVien_ChuaTK_Result taiKhoan)
        {
            proxy = new Proxy();
            if (taiKhoan.TenTaiKhoan != null && taiKhoan.MatKhau != null)
            {

                if (proxy.IsValid(taiKhoan.TenTaiKhoan))
                {
                    var result = db.TaiKhoan_Add(taiKhoan.TenTaiKhoan, PasswordOption.Encrypt(taiKhoan.MatKhau), taiKhoan.MaNhanVien, taiKhoan.LoaiTaiKhoan).SingleOrDefault();
                    if (result != "Thêm thành công")
                    {
                        ModelState.AddModelError("CreateFailed", result);
                    }
                    else
                    {
                        TempData["SuccessMessage"] = "Thêm thành công";
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("CreateFailed", "Tên tài khoản đã tồn tại");
                }


            }
            else
            {
                ModelState.AddModelError("Error", "Mời nhập tên tài khoản và mật khẩu");
            }
            ViewBag.LoaiTaiKhoan = new SelectList(db.NhanVien_LoaiTK(), "MaLoaiTaiKhoan", "LoaiTaiKhoan", taiKhoan.LoaiTaiKhoan);
            ViewBag.MaNhanVien = new SelectList(db.NhanVien_ChuaTK(), "MaNhanVien", "TenNhanVien", taiKhoan.MaNhanVien);
            return View(taiKhoan);
        }



        public ActionResult Reset(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            try
            {
                //string pass = "user@GHK2P";
                //var reset = database.TaiKhoan_Reset(id, PasswordOption.Encrypt(pass)).Single();
                //var reset = database.TaiKhoan_ResetPass(id);

                ICommand reset = new ResetPassword(db, id);
                invoker.AddCommand(reset);
                invoker.ExecuteCommands();
                TempData["SuccessMessage"] = "Reset thành công";
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", "Có lỗi xảy ra: " + e.Message);

                invoker.UndoLastCommand();
            }
            return RedirectToAction("Index");
        }

        // GET: NhanViens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            else
            {
                var nhanVien = db.NhanVien_ChiTiet(id).SingleOrDefault();
                ViewBag.ChiTietNhanVien = nhanVien;
                ViewBag.MaKhuVuc = new SelectList(db.NhanVien_KhuVuc(), "MaKhuVuc", "TenKhuVuc");
                ShowRouterInfo();
                return View();
            }
        }

        //POST: NhanViens/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(DateTime ngaysinh)
        {
            int id = int.Parse(Request.Form["id"]);
            var hoten = Request.Form["hoten"];
            var email = Request.Form["email"];
            string sdt = (string)Request.Form["sdt"];
            int khuvuc = int.Parse(Request.Form["khuvuc"]);
            //ViewBag.MaKhuVuc = new SelectList(db.NhanVien_KhuVuc(), "MaKhuVuc", "TenKhuVuc");
            db.NhanVien_Sua(id, hoten, ngaysinh, email, sdt, khuvuc).SingleOrDefault();
            db.SaveChanges();
            return RedirectToAction("/Details/" + id);
        }

        // hiep lam
        // GET: NhanViens/Dulicate/5
        public ActionResult Duplicate(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            else
            {
                var nhanVien = db.NhanVien_ChiTiet(id).SingleOrDefault();
                ViewBag.ChiTietNhanVien = nhanVien;
                ViewBag.MaKhuVuc = new SelectList(db.NhanVien_KhuVuc(), "MaKhuVuc", "TenKhuVuc");
                ShowRouterInfo();
                return View();
            }
        }

        //POST: NhanViens/Details/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Duplicate(int id)
        {
            NhanVien sourceAccount = db.NhanViens.Find(id);

            if (sourceAccount == null)
            {
                return HttpNotFound();
            }

            // Create a new NhanVien based on the existing NhanVien
            //NhanVien clonedAccount = new NhanVien
            //{
            //    TenNhanVien = sourceAccount.TenNhanVien,
            //    NgaySinh = sourceAccount.NgaySinh,
            //    Email = sourceAccount.Email,
            //    SoDienThoai = sourceAccount.SoDienThoai,
            //    TrangThai = sourceAccount.TrangThai,
            //    MaKhuVuc = sourceAccount.MaKhuVuc,
            //    TenTaiKhoan = sourceAccount.TenTaiKhoan,
            //    MatKhau = sourceAccount.MatKhau,
            //    LoaiTaiKhoan = sourceAccount.LoaiTaiKhoan,
            //    ImageData = sourceAccount.ImageData,
            //    ImageExtension = sourceAccount.ImageExtension
            //};
            var clonedAccount = sourceAccount.Clone();

            db.NhanViens.Add((NhanVien)clonedAccount);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
