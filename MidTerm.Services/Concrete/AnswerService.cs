using System;
using System.Collections.Generic;
using System.Text;
using MidTerm.Data.Abstract;
using midTerm.Data.Entities;
using MidTerm.Models.Models;
using MidTerm.Services.Abstract;

namespace MidTerm.Services.Concrete
{
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerDal _service;

        public AnswerService(IAnswerDal service)
        {
            _service = service;
        }

        public List<AnswerDetailDto> GetAllAnswerDetail()
        {
            return _service.GetAllAnswerDetail();
        }

        public List<Answers> GetAll()
        {
            return _service.GetAll();

        }

        public Answers GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Add(Answers entity)
        {
            _service.Add(entity);
        }

        public void Update(Answers entity)
        {
           _service.Update(entity);
        }

        public void Delete(Answers entity)
        {
            _service.Delete(entity);
        }
    }
}
