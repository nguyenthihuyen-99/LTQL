using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ltql.Controllers
{
    public class giaiptbac2Controller : Controller
    {
        // GET: giaiptbac2
        public ActionResult giaiptbac2(string hesoA, string hesoB, string hesoC)
        {
            Double a, b, c, delta, x1 = 0, x2 = 0, x = 0; 
            string ketqua = "";
            a = Convert.ToDouble(hesoA);
            b = Convert.ToDouble(hesoB);
            c = Convert.ToDouble(hesoC);
            delta = b * b - 4 * a * c;
            if (a == 0)
            {
                if (b == 0 && c != 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                {
                    x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem " + x.ToString());
                }
            }
          else
            {
                if (delta < 0)
                    Console.WriteLine("phuong trinh vo nghiem");
                else if(delta==0)
                {
                    x = -b / 2 * a;
                    Console.WriteLine("phuong trinh co nghiem kep" + x.ToString());
                    else
                    {
                        x1 = (-b - (double)Math.Sqrt(delta)) / 2 * a;
                        x2 = (-b - (double)Math.Sqrt(delta)) / 2 * a;
                    }    
                }    
            }    
            return View();
        }
    }
}