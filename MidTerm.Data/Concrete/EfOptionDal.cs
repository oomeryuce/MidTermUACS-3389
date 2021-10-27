using System;
using System.Collections.Generic;
using System.Text;
using MidTerm.Core.Data.EfCore;
using MidTerm.Data.Abstract;
using MidTerm.Data.Context;
using midTerm.Data.Entities;

namespace MidTerm.Data.Concrete
{
    public class EfOptionDal:EfEntityRepository<Option,MidTermDbContext>,IOptionDal
    {
    }
}
