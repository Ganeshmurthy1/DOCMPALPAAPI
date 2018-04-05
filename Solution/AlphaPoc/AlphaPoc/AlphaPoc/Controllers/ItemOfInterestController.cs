using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlphaPoc.ViewModels;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlphaPoc.Controllers
{
    
    [Route("api/[controller]")]
    public class ItemOfInterestController : Controller
    {
        private IUnitOfWork _unitOfWork;



        public ItemOfInterestController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("ioi/{id}")]
        [Produces(typeof(ItemofInterestDetailViewModel))]
        public IActionResult GetIoiDetails(int id)
        {
            //first get investigations
            var result = _unitOfWork.Investigations.GetSingleOrDefault(o => o.ItemOfInterestId == id);

            var ioivm = new ItemofInterestDetailViewModel();
            var violationDetails = new List<ViolationDetail>();

            //then get any violations which are open
            if (result!=null)
            {
                ioivm.InvestigationDetail = new InvestigationDetail
                {
                    Description=result.Description,
                    ItemofInterestId=result.ItemOfInterestId,
                    Status=result.Status,
                    Id=result.Id
                };

                var violations = _unitOfWork.Violations.Find(o => o.InvestigationId == result.Id);

                if (violations!=null && violations.Any())
                {
                    foreach(var item in violations)
                    {
                        violationDetails.Add(new ViolationDetail
                        {
                            Description=item.Description,
                            Id=item.Id,
                            InvestigationId=item.InvestigationId,
                            Status=item.Status,
                            ViolationType=item.ViolationType,
                            IsResolved=item.IsResolved
                        });
                    }
                    ioivm.ViolationDetails = violationDetails;
                }

            }
            return Ok(ioivm);

        }
    }
}