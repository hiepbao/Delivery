using Delivery.Models;

namespace Delivery.Controllers
{
    public class NhanVienValidator : INhanVienValidator
    {
        public bool Validate(NhanVien_ChuaTK_Result nhanVien)
        {
            // Thêm bất kỳ logic kiểm tra chung nào ở đây
            return true;
        }

    }

}