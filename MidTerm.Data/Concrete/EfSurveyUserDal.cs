using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MidTerm.Core.Data.EfCore;
using MidTerm.Data.Abstract;
using MidTerm.Data.Context;
using midTerm.Data.Entities;
using MidTerm.Models.Models;

namespace MidTerm.Data.Concrete
{
    public class EfSurveyUserDal:EfEntityRepository<SurveyUser,MidTermDbContext>,ISurveyUserDal
    {
    }
}
