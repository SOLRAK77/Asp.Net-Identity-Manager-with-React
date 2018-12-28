using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using ProjectMars.Models.Data;
using ProjectMars.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ProjectMars.Controllers
{
    [Authorize]
    public class StudentsController : ApiController
    {
        private ApplicationUserManager _userManager;

        public StudentsController()
        {
        }

        public StudentsController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        public HttpResponseMessage Get()
        {
            using (ApplicationDbContext entities = new ApplicationDbContext())
            {
                //return Request.CreateResponse(HttpStatusCode.OK, entities.Student.ToList());
                var user = UserManager.FindById(User.Identity.GetUserId());
                return Request.CreateResponse(HttpStatusCode.OK, entities.Student.Where(e => e.Id == user.Id).ToList()); 
            }
        }
    }
}
