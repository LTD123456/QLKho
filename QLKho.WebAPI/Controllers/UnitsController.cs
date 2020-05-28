using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLKho.Data.Entities;
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
        public IActionResult GetAll()
        {
            var listBill = _IUnits.GetAll();
            return Ok(listBill);
        }
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(Unit unit)
        {

            return Ok(_IUnits.Add(unit));
        }
        [Route("Update")]
        [HttpPost]
        public IActionResult Update(Unit unit)
        {

            return Ok(_IUnits.Update(unit));
        }
        [Route("UpdateRange")]
        [HttpPost]
        public IActionResult UpdateRange(IEnumerable<Unit> listUnit)
        {
            try
            {
                _IUnits.UpdateRange(listUnit);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
        [Route("AddRange")]
        [HttpPost]
        public IActionResult AddRange(ICollection<Unit> listUnit)
        {
            try
            {
                return Ok(_IUnits.AddRange(listUnit));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
        [Route("Delete")]
        [HttpPost]
        public IActionResult Delete(Unit unit)
        {
            try
            {
                return Ok(_IUnits.Delete(unit));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}