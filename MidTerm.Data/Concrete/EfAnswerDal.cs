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
    public class EfAnswerDal:EfEntityRepository<Answers,MidTermDbContext>,IAnswerDal
    {
        public List<AnswerDetailDto> GetAllAnswerDetail()
        {
            using (var context = new MidTermDbContext())
            {
                var result = from answer in context.Answers
                    join option in context.Options on answer.OptionId equals option.Id
                    join q in context.Questions on option.QuestionId equals q.Id
                    join user in context.SurveyUsers on answer.UserId equals user.Id
                    select new AnswerDetailDto
                    {
                        Id = answer.Id,
                        UserName = user.FirstName,
                        UserSurname = user.LastName,
                        UserCountry = user.Country,
                        OptionsText = option.Text,
                        QuestionDescription = q.Description,
                        QuestionText = q.Text
                    };
                return result.ToList();
            }
        }
    }
}
