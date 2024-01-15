using Delivery.Models;

namespace Delivery.Controllers
{
    public interface INhanVienValidator
    {
        bool Validate(NhanVien_ChuaTK_Result nhanVien);
    }
}