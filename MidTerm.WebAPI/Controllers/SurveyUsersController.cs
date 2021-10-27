using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using midTerm.Data.Entities;
using MidTerm.Services.Abstract;

namespace MidTerm.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyUsersController : ControllerBase
    {
        private ISurveyUserService _service;

        public SurveyUsersController(ISurveyUserService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
            
        }

        [HttpGet("GetById")]
        public ActionResult GetAll(int id)
        {
            var result = _service.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();

        }

        [HttpPost("Add")]
        public ActionResult Add(SurveyUser entity)
        {
            _service.Add(entity);
            return Ok();
        }

        [HttpPut("Update")]
        public ActionResult Update(SurveyUser entity)
        {
            _service.Update(entity);
            return Ok();
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(SurveyUser entity)
        {
            _service.Delete(entity);
            return Ok();
        }
    }
}
