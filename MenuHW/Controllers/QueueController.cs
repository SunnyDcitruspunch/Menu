using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuHW.Controllers
{
    public class QueueController : Controller
    {
        static Queue<string> myQueue = new Queue<string>();

        // GET: Queue
        public ActionResult Index()
        {
            ViewBag.MyQueue = myQueue;
            return View();
        }

        //add one entry in myQueue
        public ActionResult AddOne()
        {
            myQueue.Enqueue("New Entry " + (myQueue.Count + 1));
            ViewBag.MyQueue = myQueue;
            return View("Index");
        }

        //clear previous entries and add 2000 new entries
        public ActionResult AddAlot()
        {
            myQueue.Clear();

            for (var i = 0; i < 2000; i++)
            {
                myQueue.Enqueue("New Entry " + i);
            }

            ViewBag.MyQueue = myQueue;
            return View("Index");
        }

        //delete all data in queue
        public ActionResult DeleteAll()
        {
            myQueue.Clear();
            ViewBag.MyQueue = myQueue;
            return View("Index");
        }
    }
}