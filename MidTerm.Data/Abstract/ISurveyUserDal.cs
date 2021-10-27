using System;
using System.Collections.Generic;
using System.Text;
using MidTerm.Core.Data;
using MidTerm.Data.Context;
using midTerm.Data.Entities;
using MidTerm.Models.Models;

namespace MidTerm.Data.Abstract
{
    public interface ISurveyUserDal:IEntityRepository<SurveyUser>
    {
    }
}
