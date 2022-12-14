using Microsoft.AspNetCore.Mvc;
using DangThiAnhBTH.Models.Process;

namespace DangThiAnhBTH.Controllers
{
    public class DemoController : Controller
    {
     // Giải phương trình bậc nhất
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
    
           public IActionResult Index(string heSoA, string heSoB)
           {
            double a = Convert.ToDouble(heSoA);
            double b = Convert.ToDouble(heSoB);
            string thongBao =  gpt.GiaiPhuongTrinhBacNhat(a,b);
            ViewBag.mess = thongBao;
              return View();
           }
         [HttpPost] 
           public IActionResult Index (string a, string b, string c)
           {
            double hesoA = Convert.ToDouble(a);
            double hesoB = Convert.ToDouble(b);
            double hesoC = Convert.ToDouble(c);
            string ptbac2 = gpt.GiaiPhuongTrinhBacHai(hesoA,hesoB,hesoC);
            ViewBag.mes = ptbac2;
            return View();
           }      
    }
}