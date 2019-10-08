using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuHW.Controllers
{
    public class StackController : Controller
    {
        static Stack<string> myStack = new Stack<string>();

        // GET: Stack
        public ActionResult Index()
        {
            ViewBag.MyStack = myStack;
            return View();
        }

        //add one entry in myStack
        public ActionResult AddOne()
        {
            myStack.Push("New Entry " + (myStack.Count + 1));
            ViewBag.MyStack = myStack;
            return View("Index");
        }

        //clear previous entries and add 2000 new entries
        public ActionResult AddAlot()
        {
            myStack.Clear();

            for (var i = 0; i < 2000; i++)
            {
                myStack.Push("New Entry " + Convert.ToString(i++));
            }

            ViewBag.MyStack = myStack;

            return View("Index");
        }

        //delete all data in stack
        public ActionResult DeleteAll()
        {
            myStack.Clear();
            ViewBag.MyStack = myStack;

            return View("Index");
        }
    }
}