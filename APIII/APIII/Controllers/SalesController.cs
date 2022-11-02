using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIII.Models;
using System.Collections.Generic;
using System.Linq;

namespace APIII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {

        private Freshers_Training2022Context _pContext;
        public SalesController(Freshers_Training2022Context context)
        {
            _pContext = context;
        }

        [HttpGet]
        public List<RrSalesOpp> GetSale()
        {

            return _pContext.RrSalesOpp.ToList();
        }
        //[HttpGet("{id}")]
        //public RrSalesOpp GetSale(int id)
        //{
        //    var sale = _pContext.RrSalesOpp.Where(x => x.SaleId == id).SingleOrDefault();

        //    return sale;
        //}

        //[HttpGet]

        //public IEnumerable<RrSalesOpp> Get()
        //{
        //    using (var context = new Freshers_Training2022Context())
        //    {
        //        return context.RrSalesOpp.ToList();
        //    }
        //}

        [HttpPost("AddSale/{id}")]
        public IActionResult AddSale(RrSalesOpp rsales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Not A Valid Product");

            }
            var context = new Freshers_Training2022Context();

            context.RrSalesOpp.Add(rsales);
            context.SaveChanges();
            return Ok(rsales);
        }

        [HttpPut("Update/{id}")]
        public IActionResult Update([FromRoute] int id, RrSalesOpp rsales)

        {
            var context = new Freshers_Training2022Context();
            var sale = context.RrSalesOpp.Find(id);

            if (id != sale.SaleId)
            {
                return BadRequest("Id Not found");

            }

           
            if (sale != null)
            {
                sale.SalesOpportunitySoname = rsales.SalesOpportunitySoname;
                sale.SalesOpportunityBusname = rsales.SalesOpportunityBusname;
                sale.Buname = rsales.Buname;
                sale.SoRegionId = rsales.SoRegionId;
                sale.SalesOpportunityDivname = rsales.SalesOpportunityDivname;
                sale.SoMarketId = rsales.SoMarketId;
                sale.PrjtType = rsales.PrjtType;
                sale.JobType = rsales.JobType;
                sale.SowName = rsales.SowName;
                sale.PriDollarAmt = rsales.PriDollarAmt;
                sale.SoNumSites = rsales.SoNumSites;
                sale.UspGetSalesOpportunityData = rsales.UspGetSalesOpportunityData;
                sale.Phase = rsales.Phase;
                sale.PhsPrc = rsales.PhsPrc;
                sale.SalesOpportunityWeightedAmount = rsales.SalesOpportunityWeightedAmount;
                sale.SalesOpportunityActiveSalesEmployee = rsales.SalesOpportunityActiveSalesEmployee;
                sale.SalesOpportunitySoPhaseStartDate = rsales.SalesOpportunitySoPhaseStartDate;
                sale.SalesOpportunitySalesEmployee = rsales.SalesOpportunitySalesEmployee;
                sale.SalesOpprotunityManager = rsales.SalesOpprotunityManager;
                sale.SalesOpportunitySoStartDate = rsales.SalesOpportunitySoStartDate;
                sale.SalesOpportunitySoEndDate = rsales.SalesOpportunitySoEndDate;
                sale.SalesOpportunitySoClosingDate = rsales.SalesOpportunitySoClosingDate;
                sale.SalesOpportunitySloEstWorkDate = rsales.SalesOpportunitySloEstWorkDate;
                sale.Intlevel = rsales.Intlevel;
                sale.SosStatus = rsales.SosStatus;
                sale.SosReason = rsales.SosReason;
                context.SaveChanges();
                return Ok(rsales);


            }
            else
            {
                return NoContent();
            }


        }
    }
}




