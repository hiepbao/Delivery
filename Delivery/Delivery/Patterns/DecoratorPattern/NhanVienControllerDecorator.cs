using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Delivery.Patterns.DecoratorPattern
{
    public abstract class NhanVienControllerDecorator : INhanVienController
    {
        protected readonly INhanVienController _decoratedController;
      

        public NhanVienControllerDecorator(INhanVienController decoratedController)
        {
            _decoratedController = decoratedController;
        }

        public virtual ActionResult Index(string sortOrder, string MaNV, string tenNV, string khuvuc)
        {
            // Thực hiện các chức năng bổ sung trước khi gọi đến đối tượng gốc
            // ...

            // Gọi đến phương thức Index của đối tượng gốc
            return _decoratedController.Index(sortOrder, MaNV, tenNV, khuvuc);
        }

        public virtual ActionResult Create()
        {
            // Thực hiện các chức năng bổ sung trước khi gọi đến đối tượng gốc
            // ...

            // Gọi đến phương thức Create của đối tượng gốc
            return _decoratedController.Create();
        }

        public virtual ActionResult Delete(int? id)
        {
            // Thực hiện các chức năng bổ sung trước khi gọi đến đối tượng gốc
            // ...

            // Gọi đến phương thức Delete của đối tượng gốc
            return _decoratedController.Delete(id);
        }
    }
}