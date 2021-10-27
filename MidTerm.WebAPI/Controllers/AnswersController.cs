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
    public class AnswersController : ControllerBase
    {
        private readonly IAnswerService _service;

        public AnswersController(IAnswerService service)
        {
            _service = service;
        }

        [HttpGet("GetAllAnswerDetail")]
        public ActionResult GetAllAnswerDetail()
        {
            var result = _service.GetAllAnswerDetail();
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result!=null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("GetById")]
        public ActionResult GetById(int id)
        {
            var result = _service.GetById(id);
            if (result != null)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("Add")]
        public ActionResult Add(Answers entity)
        {
            _service.Add(entity);
            return Ok();
        }

        [HttpPut("Update")]
        public ActionResult Update(Answers entity)
        {
            _service.Update(entity);
            return Ok();
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(Answers entity)
        {
            _service.Delete(entity);
            return Ok();
        }
    }
}
