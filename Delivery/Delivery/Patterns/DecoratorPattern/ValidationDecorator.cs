using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Delivery.Patterns.DecoratorPattern
{
    public class ValidationDecorator : NhanVienControllerDecorator
    {
        public ValidationDecorator(INhanVienController decoratedController) : base(decoratedController)
        {
        }

        public override ActionResult Create()
        {
            // Thực hiện chức năng bổ sung: Kiểm tra dữ liệu đầu vào trước khi gọi đến đối tượng gốc
            if (!IsValidInput())
            {
                // Xử lý khi dữ liệu đầu vào không hợp lệ, ví dụ: trả về thông báo lỗi, chuyển hướng đến trang lỗi, vv.
                return BadRequest("Invalid input data");
            }

            // Gọi đến phương thức Create của đối tượng gốc
            return base.Create();
        }

        private ContentResult BadRequest(string message)
        {
            // Xử lý khi dữ liệu đầu vào không hợp lệ
            // Ví dụ: Trả về một ContentResult tương ứng với thông báo lỗi
            return new ContentResult { Content = message };
        }

        private bool IsValidInput()
        {
            // Thực hiện kiểm tra dữ liệu đầu vào
            // Ví dụ: Kiểm tra tên nhân viên không chứa số hoặc ký tự đặc biệt
            if (!IsNameValid())
            {
                return false;
            }

            // Ví dụ: Kiểm tra mã khu vực hoạt động chỉ thuộc 1-17
            if (!IsKhuVucValid())
            {
                return false;
            }

            // Trả về true nếu dữ liệu đầu vào hợp lệ
            return true;
        }
        private string GetEmployeeNameFromInput(string input)
        {
            // Xử lý và trả về tên nhân viên từ dữ liệu đầu vào
            return input;
        }

        private int GetKhuVucFromInput(int input)
        {
            // Xử lý và trả về mã khu vực từ dữ liệu đầu vào
            return input;
        }

        private bool IsNameValid()
        {
            // Kiểm tra tên nhân viên không chứa số hoặc ký tự đặc biệt
            // Ví dụ: Kiểm tra tên nhân viên chỉ chứa chữ cái và khoảng trắng
            string name = GetEmployeeNameFromInput(HttpContext.Current.Request.Form["TenNhanVien"]); // Lấy tên nhân viên từ dữ liệu đầu vào
            bool isValid = !Regex.IsMatch(name, @"[^a-zA-Z\s]");
            return isValid;
        }

        private bool IsKhuVucValid()
        {
            // Kiểm tra mã khu vực hoạt động chỉ thuộc 1-17
            // Ví dụ: Kiểm tra mã khu vực từ dữ liệu đầu vào
            int khuVuc = GetKhuVucFromInput(int.Parse(HttpContext.Current.Request.Form["MaKhuVuc"])); // Lấy mã khu vực từ dữ liệu đầu vào
            bool isValid = khuVuc >= 1 && khuVuc <= 17;
            return isValid;
        }

    }
}