using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TranslateDocs.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
	    public ActionResult Import(HttpPostedFileBase importedFile)
		{
			string[] allowedTypes = {"text/plain", "application/rtf", "application/msword", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" };
			string[] allowedExtensions = {".txt", "doc", "docx", "rtf"};
			
			if (importedFile == null || importedFile.FileName == null) ModelState.AddModelError("Import", "No File");
			else if (!allowedTypes.Contains(importedFile.ContentType)) ModelState.AddModelError("Import", "Invalid File Content");
			else if (!allowedExtensions.Contains(Path.GetExtension(Path.GetFileName(importedFile.FileName).ToLower()))) ModelState.AddModelError("Import", "Invalid File Extension");
			else if (importedFile.ContentLength == 0) ModelState.AddModelError("Import", "Empty File");
			else
			{
				
			}
			return View("Index");
		}
    }
}