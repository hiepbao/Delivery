using Delivery.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Delivery.Pattern
{
    public class CheckValid : IProxy
    {

        private GiaoHangEntities database = new GiaoHangEntities();


        public bool IsValid(string username)    
        {
            var check = database.NhanViens.Where(x => x.TenTaiKhoan.Equals(username)).FirstOrDefault();
            if(check != null)
                return false;

            return true;
        }
    }
}