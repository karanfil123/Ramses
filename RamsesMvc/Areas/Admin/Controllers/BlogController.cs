using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RamsesMvc.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RamsesMvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExceBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");//exel sayfa adı ekleme
                worksheet.Cell(1, 1).Value = "Blog ID";//1satır 1 sütuna hücresine blog ıd başlığı ekleme
                worksheet.Cell(1, 2).Value = "Blog Name";//1satır 2 sütuna  hücresine blog adı başlığı  ekleme

                int BlogRowCount = 2; //2. satırda itibaren değer ekleme sayacı

                foreach (var item in GetListBlogModel())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.BlogId;//1satır 1 sütuna hücresine modelden gelen id değeri
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;//1satır 1 sütuna hücresine modelden gelen name değeri
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);//çalışma sayfasını kaydet
                    var content = stream.ToArray();//içeriği diziye dönüştür
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Exel_Adi.xlsx"); //içerik formatı ve uzantısı
                }
            }
        }
        public List<BlogModel> GetListBlogModel()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{BlogId=1,BlogName="Abc"},
                new BlogModel{BlogId=2,BlogName="Def"},
                new BlogModel{BlogId=3,BlogName="Klm"}
            };
            return bm;

        }
        public IActionResult BlogExcelTest()
        {
            return View();
        }
    }
}
