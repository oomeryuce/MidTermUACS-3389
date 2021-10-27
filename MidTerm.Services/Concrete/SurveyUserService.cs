using System;
using System.Collections.Generic;
using System.Text;
using MidTerm.Data.Abstract;
using midTerm.Data.Entities;
using MidTerm.Services.Abstract;

namespace MidTerm.Services.Concrete
{
    public class SurveyUserService:ISurveyUserService
    {
        private readonly ISurveyUserDal _service;

        public SurveyUserService(ISurveyUserDal service)
        {
            _service = service;
        }

        public List<SurveyUser> GetAll()
        {
           return _service.GetAll();
        }

        public SurveyUser GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Add(SurveyUser entity)
        {
            _service.Add(entity);
        }

        public void Update(SurveyUser entity)
        {
            _service.Update(entity);
        }

        public void Delete(SurveyUser entity)
        {
            _service.Delete(entity);
        }
    }
}
