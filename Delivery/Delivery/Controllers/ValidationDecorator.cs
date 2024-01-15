using Delivery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delivery.Controllers
{
    public class ValidationDecorator : NhanVienValidatorBase
    {
        public ValidationDecorator(INhanVienValidator validator) : base(validator)
        {
        }

        public override bool Validate(NhanVien_ChuaTK_Result nhanVien)
        {
            // Kiểm tra TenNhanVien không có số và ký tự đặc biệt
            if (!string.IsNullOrEmpty(nhanVien.TenNhanVien))
            {
                bool isValid = nhanVien.TenNhanVien.Any(c => char.IsDigit(c));
                if (isValid)
                {
                    // Xử lý khi TenNhanVien không hợp lệ
                    return false;
                }
            }

            // Gọi phương thức Validate của decorator cha
            return base.Validate(nhanVien);
        }

    }
}