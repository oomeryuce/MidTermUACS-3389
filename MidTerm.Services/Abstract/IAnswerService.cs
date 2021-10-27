using System;
using System.Collections.Generic;
using System.Text;
using midTerm.Data.Entities;
using MidTerm.Models.Models;

namespace MidTerm.Services.Abstract
{
    public interface IAnswerService
    {
        List<AnswerDetailDto> GetAllAnswerDetail();
        List<Answers> GetAll();
        Answers GetById(int id);
        void Add(Answers entity);
        void Update(Answers entity);
        void Delete(Answers entity);
    }
}
