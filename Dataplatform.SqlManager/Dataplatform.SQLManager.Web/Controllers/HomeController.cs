using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dataplatform.SQLManager.Web.Models;
using Dataplatform.SQLManager.Web.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Dataplatform.SQLManager.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DP_MANAGEMENT_STOREContext _context;
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            _context = new DP_MANAGEMENT_STOREContext();

        }

        public IActionResult Index()
        {

            var records = _context.Script.OrderByDescending(r => r.CreateDate).Take(10).ToList();
            return View(records);
        }

        public IActionResult Add()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,Genre,Price,ReleaseDate,Title,Rating")] Scr movie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(movie);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(movie);
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Script model)
        {
            try
            {
                DP_MANAGEMENT_STOREContext db = new DP_MANAGEMENT_STOREContext();

                model.ScriptGuid = Guid.NewGuid();
                model.CreateDate = DateTime.Now;
            
              
               db.Script.Add(model);
               db.SaveChanges();
                    
              
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Index(string keyword)
        {
            var records = _context.Script.Where(r => r.Keyword.Contains(keyword) || r.ScriptText.Contains(keyword) || r.Title.Contains(keyword) || r.SqlVersion.Contains(keyword)).ToList();
            return View(records);
        }
        
        //13.02.2020 
      
        public IActionResult Details(int Id)
        {
            var record = _context.Find(typeof(Script),Id);
            
            return View(record);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       
        
        //04.03.2020
        //05.03.2020
        public IActionResult HealtCheck()
        {
            var word = "Healtcheck";
            var record = _context.Script.Where(r => r.ScriptType.Contains(word)).ToList();
            return View(record);
        }


        public IActionResult Backup()
        {
            var word = "Backup";
            var record = _context.Script.Where(r => r.ScriptType.Contains(word)).ToList();
            return View(record);
        }

        public IActionResult Jobs()
        {
            var word = "Job";
            var record = _context.Script.Where(r => r.ScriptType.Contains(word)).ToList();
            return View(record);
        }
        public IActionResult AlwaysOn()
        {
            var word = "Alwayson";
            var record = _context.Script.Where(r => r.ScriptType.Contains(word)).ToList();
            return View(record);
        }
        
        public IActionResult Delete(int Id)
        {
            
           
            try {

                Script sc = _context.Script.Find(Id);
                _context.Remove(sc);
                _context.SaveChanges();

                
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int Id) 
        {
            var existRecord = _context.Script.Where(s => s.Id == Id).FirstOrDefault();
            return View(existRecord);
        }

        [HttpPost]
        public IActionResult Edit(Script s)
        {
            try
            {
                s.CreateDate = DateTime.Now;
                _context.Entry(s).State = EntityState.Modified;
                _context.SaveChanges();
            }

            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return RedirectToAction("Index");

        }
    }
}
