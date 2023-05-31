using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager mmg = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messagevalues = mmg.GetListInbox();
            return View(messagevalues); 
        }
        public ActionResult Sendbox()
        {
            var messagevalues = mmg.GetListSendbox();
            return View(messagevalues);
        }
        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mmg.GetByID(id);
            return View(values);
        }
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            return View();
        }
    }
}