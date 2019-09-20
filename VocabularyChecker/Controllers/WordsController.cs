using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using VocabularyChecker.Repository;
using VocabularyChecker_Model;

namespace VocabularyChecker.Controllers
{
    public class WordsController : Controller
    {
        private VocabularyCheckerContext db = new VocabularyCheckerContext();

        // GET: Words
        public ActionResult Index()
        {
            return View(db.Words.ToList());
        }

        // GET: Words/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Word word = db.Words.Find(id);
            if (word == null)
            {
                return HttpNotFound();
            }
            return View(word);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
