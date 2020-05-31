using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            if (file.ContentLength > 0)
            {
                string _FileName = Path.GetFileName(file.FileName);
                string _path = Path.Combine(Server.MapPath("~/Files"),_FileName);
                file.SaveAs(_path);
            }
            ViewBag.message = "File Uploaded Successfully";
            return View();
        }
    }
}