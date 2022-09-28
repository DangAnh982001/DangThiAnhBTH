using DangThiAnhBTH.Models.Process;
using Microsoft.AspNetCore.Mvc;

namespace DangThiAnhBTH.Controllers
{
    public class stringProcessController : Controller
    {
        stringProcess strPro = new stringProcess();
        [HttpPost]
        public IActionResult Index(string strInput)
        {
            string thongBao = strPro.RemoveRemainingWhiteSpace(strInput);
            ViewBag.result = thongBao;
            return View();
        }
    }
}