using Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Delivery.Controllers
{
    public abstract class NhanVienValidatorBase : INhanVienValidator
    {
        protected INhanVienValidator _validator;

        public NhanVienValidatorBase(INhanVienValidator validator)
        {
            _validator = validator;
        }

        public virtual bool Validate(NhanVien_ChuaTK_Result nhanVien)
        {
            return _validator.Validate(nhanVien);
        }
    }
}