using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLKho.Service.Units;

namespace QLKho.WebAPI.Controllers
{
    [Route("api/Unit")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        IUnits _IUnits;
        public UnitsController(IUnits Bill)
        {
            _IUnits = Bill;
        }
        [Route("GetAll")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var listBill = _IUnits.GetAll();
            return Ok(listBill);
        }
    }
}