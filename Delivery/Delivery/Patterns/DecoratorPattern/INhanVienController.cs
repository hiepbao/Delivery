using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Delivery.Patterns.DecoratorPattern
{
    public interface INhanVienController
    {
        ActionResult Index(string sortOrder, string MaNV, string tenNV, string khuvuc);
        ActionResult Create();
        ActionResult Delete(int? id);
    }
}
