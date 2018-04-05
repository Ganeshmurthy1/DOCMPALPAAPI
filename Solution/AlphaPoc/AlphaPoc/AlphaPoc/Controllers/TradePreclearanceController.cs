using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlphaPoc.Controllers
{
    
    [Route("api/TradePreclearance")]
    public class TradePreclearanceController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public TradePreclearanceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }
        

    }
}