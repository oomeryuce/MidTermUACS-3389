using System;
using System.Collections.Generic;
using System.Text;
using midTerm.Data.Entities;

namespace MidTerm.Services.Abstract
{
    public interface ISurveyUserService
    {
        List<SurveyUser> GetAll();
        SurveyUser GetById(int id);
        void Add(SurveyUser entity);
        void Update(SurveyUser entity);
        void Delete(SurveyUser entity);
    }
}
