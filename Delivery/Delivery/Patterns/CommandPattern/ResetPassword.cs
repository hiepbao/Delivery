using Delivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Delivery.Pattern.CommandPattern
{
    public class ResetPassword : ICommand
    {

        private GiaoHangEntities db;
        private int? id;
        private string prevPass;

        public ResetPassword(GiaoHangEntities db ,int? id)
        {
           this.db = db;
            this.id = id;
        }

        public void Execute()
        {
            var nv = db.NhanViens.Find(id);
            if (nv != null)
            {
                prevPass = nv.MatKhau;
            }

            string pass = "user@GHK2P";
            db.TaiKhoan_Reset(id, PasswordOption.Encrypt(pass)).Single();

        }

        public void Undo()
        {
            var nv = db.NhanViens.Find(id);
            if (nv != null)
            {
                nv.MatKhau = prevPass; 
                db.SaveChanges();
            }
        }
    }
}