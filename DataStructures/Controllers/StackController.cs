using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructures.Controllers
{
    public class StackController : Controller
    {
        //declare variable
        //creat new stack variable of type= string
        static Stack<string> myStack = new Stack<string>();
        

        // GET: Stack
        public ActionResult Index()
        {
            //add this so that when page first loads we have something added to the stack
            ViewBag.MyStack = myStack;
            return View();
        }

        //Action Result that will add one item to the string
        public ActionResult AddOne()
        {
            myStack.Push("New Entry " + (myStack.Count + 1));
            ViewBag.MyStack = myStack;
            return View("Index");
        }

        //Action result that will add huge list of items to stack
        public ActionResult HugeList()
        {
            //clears the stack
            myStack.Clear();

            //loop to add 2000 new items to the stack
            for(int i =0; i <= 2000; i++)
            {
                myStack.Push("New Entry " + (myStack.Count + 1));
            }
            ViewBag.MyStack = myStack;
            return View("Index");
        }

        //action result that will display the stack
        public ActionResult DisplayStack()
        {
            ViewBag.MyStack = myStack;
            return View("DisplayStack");
        }
        
        /*
        //action result that will delete items from the stack
        public ActionResult DeleteStack()
        {

        }
        */

        //action result that will clear the stack
        public ActionResult ClearStack()
        {
            myStack.Clear();
            ViewBag.MyStack = myStack;
            return View("Index");
        }

        /*
        //action result that will search the stack
        public ActionResult SearchStack()
        {

        }
        */

        /*action result to return to the main menu
        public ActionResult Return()
        {
            return View()
        }
        */
        
        

    }
}