using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrototypeAdal.Domain.Entities;
using PrototypeAdal.Domain.Abstract;

namespace PrototypeAdal.WebUI.Controllers
{
    public class ReleaseRequestController : Controller
    {
        private IReleaseRequestRepository repository;

        public ReleaseRequestController(IReleaseRequestRepository releaseRequestRepository)
        {
            this.repository = releaseRequestRepository;
        }

        public ViewResult List()
        {
            return View(repository.ReleaseRequests);
        }
    }
}