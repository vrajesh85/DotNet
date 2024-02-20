using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvitesProject.Models;

namespace PartyInvitesProject.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid){
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }    
            return View();
        }

        public ViewResult ListResponses()
        {
            var responses = Repository.Responses.Where(x => x.WillAttend == true);
            return View("ListResponses", responses);
        }
    }
}
