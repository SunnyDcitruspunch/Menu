using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuHW.Controllers
{
    public class DictionaryController : Controller
    {
        static Dictionary<int, string> myDictionary = new Dictionary<int, string>();
        
        // GET: Dictionary
        public ActionResult Index()
        {
            ViewBag.MyDictionary = myDictionary;
            return View();
        }

        //add one entry in myDictionary
        public ActionResult AddOne()
        {
            myDictionary.Add(myDictionary.Count, "New Entry " + myDictionary.Count);
            ViewBag.MyDictionary = myDictionary;
            return View("Index");
        }

        //clear out previous entries and add 2000 new entries
        public ActionResult AddAlot()
        {
            for(int i = 0; i< 2000; i++)
            {
                myDictionary.Add(i, "New Entry");
            }

            ViewBag.MyDictionary = myDictionary;
            return View("Index");
        }

        public ActionResult Display()
        {
            foreach(KeyValuePair<int, string> dict in myDictionary)
            {
                ViewBag.MyDictionary = myDictionary;
            }

            return View("Index");
        }

        //delete all data in dictionary
        public ActionResult DeleteAll()
        {
            myDictionary.Clear();
            ViewBag.MyDictionary = myDictionary;
            return View("Index");
        }
    }
}