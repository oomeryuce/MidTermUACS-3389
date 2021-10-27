using System;
using System.Collections.Generic;
using System.Text;
using MidTerm.Core.Data;
using midTerm.Data.Entities;
using MidTerm.Models.Models;

namespace MidTerm.Data.Abstract
{
    public interface IAnswerDal:IEntityRepository<Answers>
    {
        List<AnswerDetailDto> GetAllAnswerDetail();

    }
}
